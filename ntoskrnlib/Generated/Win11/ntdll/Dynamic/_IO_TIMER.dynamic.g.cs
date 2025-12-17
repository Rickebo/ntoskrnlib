using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IO_TIMER")]
    public sealed class _IO_TIMER : DynamicStructure
    {
        public short Type { get; }
        public short TimerFlag { get; }
        public _LIST_ENTRY TimerList { get; }
        public IntPtr TimerRoutine { get; }
        public IntPtr Context { get; }
        public IntPtr DeviceObject { get; }

        public _IO_TIMER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_TIMER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_TIMER.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_TIMER.TimerFlag),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IO_TIMER.TimerList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_TIMER.TimerRoutine),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IO_TIMER.Context),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IO_TIMER.DeviceObject),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_IO_TIMER>((mem, ptr) => new _IO_TIMER(mem, ptr), offsets);
        }
    }
}