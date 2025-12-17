using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ACTIVE_PFN")]
    public sealed class _MI_ACTIVE_PFN : DynamicStructure
    {
        public _unnamed_tag_ Leaf { get; }
        public _unnamed_tag_ PageTable { get; }
        public ulong EntireActiveField { get; }

        public _MI_ACTIVE_PFN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ACTIVE_PFN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ACTIVE_PFN.Leaf),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_ACTIVE_PFN.PageTable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_ACTIVE_PFN.EntireActiveField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_ACTIVE_PFN>((mem, ptr) => new _MI_ACTIVE_PFN(mem, ptr), offsets);
        }
    }
}