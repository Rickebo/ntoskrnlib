using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_TIMER_SUBQUEUE")]
    public sealed class _TPP_TIMER_SUBQUEUE : DynamicStructure
    {
        public long Expiration { get; }
        public _TPP_PH WindowStart { get; }
        public _TPP_PH WindowEnd { get; }
        public IntPtr Timer { get; }
        public IntPtr TimerPkt { get; }
        public _TP_DIRECT Direct { get; }
        public uint ExpirationWindow { get; }

        public _TPP_TIMER_SUBQUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_TIMER_SUBQUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_TIMER_SUBQUEUE.Expiration),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_TIMER_SUBQUEUE.WindowStart),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TPP_TIMER_SUBQUEUE.WindowEnd),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TPP_TIMER_SUBQUEUE.Timer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TPP_TIMER_SUBQUEUE.TimerPkt),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TPP_TIMER_SUBQUEUE.Direct),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TPP_TIMER_SUBQUEUE.ExpirationWindow),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_TPP_TIMER_SUBQUEUE>((mem, ptr) => new _TPP_TIMER_SUBQUEUE(mem, ptr), offsets);
        }
    }
}