using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RobocupSSLController.Gamepad
{
    public class Gamepad : IDisposable
    {
        private readonly EventStream _eventStream;
        private readonly object _lock = new object();
        private readonly Thread _workerThread;
        
        internal Gamepad(EvDevDeviceInfo device)
        {
            _eventStream = device.OpenEventStream();

            var axes = new Dictionary<EvDevAbsoluteAxis, AbsoluteAxis>();

            foreach (var x in device.AbsoluteAxes)
            {
                var axis = new AbsoluteAxis(x.Value);
                axes[x.Key] = axis;
            }

            AbsoluteAxes = axes;

            _workerThread = new Thread(Worker);
            _workerThread.Start();
        }

        public IReadOnlyDictionary<EvDevAbsoluteAxis, AbsoluteAxis> AbsoluteAxes { get; }
        
        /* TODO: abstract away this mapping */
        public AbsoluteAxis LeftX => AbsoluteAxes[EvDevAbsoluteAxis.ABS_Z];
        public AbsoluteAxis LeftY => AbsoluteAxes[EvDevAbsoluteAxis.ABS_RX];

        public AbsoluteAxis RightX => AbsoluteAxes[EvDevAbsoluteAxis.ABS_RY];
        public AbsoluteAxis RightY => AbsoluteAxes[EvDevAbsoluteAxis.ABS_RZ];
        
        private void Worker()
        {
            ulong evid = 0;
            
            while (true)
            {
                input_event @event;

                try
                {
                    @event = _eventStream.ReadEvent();
                }
                catch (ObjectDisposedException)
                {
                    break;
                }

                switch ((EvDevEventType) @event.type)
                {
                    case EvDevEventType.EV_SYN:
                        break;
                    case EvDevEventType.EV_ABS:
                        //Console.WriteLine($"ABS {(EvDevAbsoluteAxis)@event.code} {@event.value}");
                        AbsoluteAxes[(EvDevAbsoluteAxis) @event.code].FeedValue(@event.value);
                        break;
                }

                //Console.WriteLine("{0} {1} {2}", (EvDevEventType)@event.type, @event.code, @event.value);
            }
        }

        public void Dispose()
        {
            _eventStream?.Dispose();
            _workerThread?.Join();
        }

        public class AbsoluteAxis
        {
            public AbsoluteAxis(EvDevAbsAxisInfo info)
            {
                _maxValue = info.Max;
                _minValue = info.Min;
                _scale = 1.0 / Math.Max(Math.Abs(info.Min), Math.Abs(info.Max));
            }
            
            private int _maxValue;
            private int _minValue;
            private readonly double _scale;
            
            public double Value { get; private set; }

            internal void FeedValue(int eventValue)
            {
                if (Math.Abs(eventValue * _scale) > 0.05)
                    Value = eventValue * _scale;
                else
                    Value = 0.0;
            }
        }
    }
}