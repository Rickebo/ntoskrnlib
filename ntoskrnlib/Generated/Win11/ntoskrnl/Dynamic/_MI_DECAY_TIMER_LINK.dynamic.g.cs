using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_DECAY_TIMER_LINK")]
    public sealed class _MI_DECAY_TIMER_LINK : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }

        public _MI_DECAY_TIMER_LINK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_DECAY_TIMER_LINK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_DECAY_TIMER_LINK.u1),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_DECAY_TIMER_LINK>((mem, ptr) => new _MI_DECAY_TIMER_LINK(mem, ptr), offsets);
        }
    }
}