using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace RobocupSSLController.Gamepad
{
    internal class EventStream : IDisposable
    {
        private readonly FileStream _stream;
        
        public EventStream(FileStream s)
        {
            _stream = s;
        }

        public unsafe input_event ReadEvent()
        {
            var length = sizeof(input_event);
            input_event @event;

            if (_stream.Read(new Span<byte>(&@event, length)) != length)
                throw new EndOfStreamException();

            return @event;
        }

        public void Dispose()
        {
            _stream.Close();
        }
    }
}