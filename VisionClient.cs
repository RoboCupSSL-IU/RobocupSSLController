using System;
using System.Buffers;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace RobocupSSLController
{
    public class VisionClient : IDisposable
    {
        public static readonly IPEndPoint DefaultSslVisionListenEndpoint = IPEndPoint.Parse("224.5.23.2:10006");

        public class Builder
        {
            public IPEndPoint ListenEndpoint { get; set; } = DefaultSslVisionListenEndpoint;
            public int MaxPacketSize { get; set; } = 4096;

            public VisionClient Build(CancellationToken cancellationToken = default(CancellationToken))
            {
                var r = new VisionClient
                {
                    _cancellationTokenSource = new CancellationTokenSource()
                };
                r._cancellationToken = r._cancellationTokenSource.Token;

                r._workerThread = new Thread(() => r.Worker(ListenEndpoint, MaxPacketSize));
                r._workerThread.Start();

                return r;
            }
        }

        private UdpClient _udpClient;
        private Thread _workerThread;
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationToken _cancellationToken;

        private VisionClient()
        {
        }

        private void OnPacket(byte[] buffer, Task<int> task)
        {
            int gotBytes = task.Result;
            
            var wrapperPacket = SSL_WrapperPacket.Parser.ParseFrom(buffer, 0, gotBytes);
            Console.WriteLine(wrapperPacket);
        }

        private void Worker(IPEndPoint ep, int maxSize)
        {
            try
            {
                _udpClient = new UdpClient();
                _udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, ep.Port));
                _udpClient.JoinMulticastGroup(ep.Address);


                var buffer = new byte[maxSize];
                while (!_cancellationToken.IsCancellationRequested)
                {
                    var task = _udpClient.Client.ReceiveAsync(buffer, SocketFlags.None, _cancellationToken)
                        // ReSharper disable once MethodSupportsCancellation
                        .AsTask().ContinueWith(t => OnPacket(buffer, t));
                    task.Wait(_cancellationToken);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
            _workerThread.Join();
        }

        public void Dispose()
        {
            if (_workerThread?.IsAlive ?? false)
                Stop();
        }
    }
}