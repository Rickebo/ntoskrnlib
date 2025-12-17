using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PS_INTERLOCKED_TIMER_DELAY_VALUES")]
    public sealed class _PS_INTERLOCKED_TIMER_DELAY_VALUES : DynamicStructure
    {
        public ulong DelayMs { get; }
        public ulong CoalescingWindowMs { get; }
        public ulong Reserved { get; }
        public ulong NewTimerWheel { get; }
        public ulong Retry { get; }
        public ulong Locked { get; }
        public ulong All { get; }

        public _PS_INTERLOCKED_TIMER_DELAY_VALUES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PS_INTERLOCKED_TIMER_DELAY_VALUES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PS_INTERLOCKED_TIMER_DELAY_VALUES.DelayMs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_INTERLOCKED_TIMER_DELAY_VALUES.CoalescingWindowMs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_INTERLOCKED_TIMER_DELAY_VALUES.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_INTERLOCKED_TIMER_DELAY_VALUES.NewTimerWheel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_INTERLOCKED_TIMER_DELAY_VALUES.Retry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_INTERLOCKED_TIMER_DELAY_VALUES.Locked),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PS_INTERLOCKED_TIMER_DELAY_VALUES.All),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PS_INTERLOCKED_TIMER_DELAY_VALUES>((mem, ptr) => new _PS_INTERLOCKED_TIMER_DELAY_VALUES(mem, ptr), offsets);
        }
    }
}