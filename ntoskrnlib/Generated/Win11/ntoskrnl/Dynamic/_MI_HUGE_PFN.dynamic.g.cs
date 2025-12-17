using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_HUGE_PFN")]
    public sealed class _MI_HUGE_PFN : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }

        public _MI_HUGE_PFN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_HUGE_PFN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_HUGE_PFN.u1),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_HUGE_PFN>((mem, ptr) => new _MI_HUGE_PFN(mem, ptr), offsets);
        }
    }
}