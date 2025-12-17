using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_TIMER_QUEUE")]
    public sealed class _TPP_TIMER_QUEUE : DynamicStructure
    {
        public _RTL_SRWLOCK Lock { get; }
        public _TPP_TIMER_SUBQUEUE AbsoluteQueue { get; }
        public _TPP_TIMER_SUBQUEUE RelativeQueue { get; }
        public int AllocatedTimerCount { get; }

        public _TPP_TIMER_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_TIMER_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_TIMER_QUEUE.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_TIMER_QUEUE.AbsoluteQueue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TPP_TIMER_QUEUE.RelativeQueue),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_TPP_TIMER_QUEUE.AllocatedTimerCount),
                    new ulong[]
                    {
                        248UL
                    }
                }
            };
            Register<_TPP_TIMER_QUEUE>((mem, ptr) => new _TPP_TIMER_QUEUE(mem, ptr), offsets);
        }
    }
}