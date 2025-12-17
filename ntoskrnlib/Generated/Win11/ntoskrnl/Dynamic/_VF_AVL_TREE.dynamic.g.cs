using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_AVL_TREE")]
    public sealed class _VF_AVL_TREE : DynamicStructure
    {
        public ulong NodeRangeSize { get; }
        public ulong NodeCount { get; }
        public IntPtr Tables { get; }
        public uint TablesNo { get; }
        public _unnamed_tag_ u1 { get; }

        public _VF_AVL_TREE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_AVL_TREE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_AVL_TREE.NodeRangeSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_AVL_TREE.NodeCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VF_AVL_TREE.Tables),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VF_AVL_TREE.TablesNo),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VF_AVL_TREE.u1),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_VF_AVL_TREE>((mem, ptr) => new _VF_AVL_TREE(mem, ptr), offsets);
        }
    }
}