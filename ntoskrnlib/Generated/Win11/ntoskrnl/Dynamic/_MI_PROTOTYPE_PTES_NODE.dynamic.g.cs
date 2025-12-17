using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PROTOTYPE_PTES_NODE")]
    public sealed class _MI_PROTOTYPE_PTES_NODE : DynamicStructure
    {
        public _RTL_BALANCED_NODE Node { get; }
        public _unnamed_tag_ u1 { get; }

        public _MI_PROTOTYPE_PTES_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PROTOTYPE_PTES_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PROTOTYPE_PTES_NODE.Node),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PROTOTYPE_PTES_NODE.u1),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_PROTOTYPE_PTES_NODE>((mem, ptr) => new _MI_PROTOTYPE_PTES_NODE(mem, ptr), offsets);
        }
    }
}