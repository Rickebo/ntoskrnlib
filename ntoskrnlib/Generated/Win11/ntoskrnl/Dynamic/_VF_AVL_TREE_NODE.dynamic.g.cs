using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_AVL_TREE_NODE")]
    public sealed class _VF_AVL_TREE_NODE : DynamicStructure
    {
        public IntPtr p { get; }
        public ulong RangeSize { get; }

        public _VF_AVL_TREE_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_AVL_TREE_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_AVL_TREE_NODE.p),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_AVL_TREE_NODE.RangeSize),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_VF_AVL_TREE_NODE>((mem, ptr) => new _VF_AVL_TREE_NODE(mem, ptr), offsets);
        }
    }
}