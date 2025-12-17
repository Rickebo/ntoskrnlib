using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_DECAY_TIMER_LINKAGE")]
    public sealed class _MI_DECAY_TIMER_LINKAGE : DynamicStructure
    {
        public ulong Spare0 { get; }
        public ulong PreviousDecayPfn { get; }
        public ulong TimerRemoved { get; }
        public ulong NextDecayPfn { get; }

        public _MI_DECAY_TIMER_LINKAGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_DECAY_TIMER_LINKAGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_DECAY_TIMER_LINKAGE.Spare0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DECAY_TIMER_LINKAGE.PreviousDecayPfn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DECAY_TIMER_LINKAGE.TimerRemoved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_DECAY_TIMER_LINKAGE.NextDecayPfn),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_DECAY_TIMER_LINKAGE>((mem, ptr) => new _MI_DECAY_TIMER_LINKAGE(mem, ptr), offsets);
        }
    }
}