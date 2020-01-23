using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Google.Protobuf;

namespace RobocupSSLController
{
    public class GrSimCommandsOutput : ICommandsOutput
    {
        public const int MaxQueueSize = 16;
        public const int MaxPacketSize = 8192;
        
        private readonly BlockingCollection<RobotCommand[]> _commandQueue = new BlockingCollection<RobotCommand[]>();
        private readonly RobocupTeam _team;
        private readonly byte[] _buffer = new byte[MaxPacketSize];
        private readonly Socket _socket;
        private readonly Thread _workerThread;
        private readonly CancellationTokenSource _cancellationTokenSource;
        private readonly CancellationToken _cancellationToken;

        public GrSimCommandsOutput(RobocupTeam team, IPEndPoint endPoint)
        {
            _team = team;
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.Connect(endPoint);
            
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;
            
            _workerThread = new Thread(Worker);
            _workerThread.Start();
        }
        
        public void PostCommands(RobotCommand[] commands)
        {
            // We (should) have only one reader and one writer
            if (_commandQueue.Count >= MaxQueueSize)
                return; // Drop exceeding commands
            // ReSharper disable once MethodSupportsCancellation
            _commandQueue.Add(commands);
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
            _workerThread.Join();
            _socket.Dispose();
        }

        private void Worker()
        {
            try
            {
                while (true)
                {
                    var commands = _commandQueue.Take(_cancellationToken);

                    var grSimCommands = commands.Select((c, i) => new grSim_Robot_Command
                    {
                        Id = (uint) i,

                        Velnormal = (float) c.VelocityNormal,
                        Veltangent = (float) c.VelocityTangent,
                        Velangular = (float) c.AngularVelocity,

                        Kickspeedx = (float) c.KickSpeedX,
                        Kickspeedz = (float) c.KickSpeedZ,

                        Spinner = c.EnableDribbler,

                        Wheelsspeed = false,
                    });

                    var grSimCommandsPacket = new grSim_Commands
                    {
                        Isteamyellow = _team == RobocupTeam.Yellow,
                        Timestamp = ((DateTimeOffset) DateTime.UtcNow).ToUnixTimeSeconds(),
                        RobotCommands = {grSimCommands}
                    };
                    
                    var grSimPacket = new grSim_Packet
                    {
                        Commands = grSimCommandsPacket
                    };

                    var cos = new CodedOutputStream(_buffer);
                    grSimPacket.WriteTo(cos);
                    var message = new ArraySegment<byte>(_buffer, 0, (int) cos.Position);

                    // ReSharper disable once MethodSupportsCancellation
                    _socket.SendAsync(message, SocketFlags.None, _cancellationToken).AsTask().GetAwaiter().GetResult();
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

        public void Dispose()
        {
            if (_workerThread?.IsAlive ?? false)
                Stop();
        }
    }
}