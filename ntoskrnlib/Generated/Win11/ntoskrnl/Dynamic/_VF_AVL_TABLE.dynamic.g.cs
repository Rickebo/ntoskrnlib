using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_AVL_TABLE")]
    public sealed class _VF_AVL_TABLE : DynamicStructure
    {
        public _RTL_AVL_TABLE RtlTable { get; }
        public IntPtr ReservedNode { get; }
        public IntPtr NodeToFree { get; }
        public int Lock { get; }
        public IntPtr ExclusiveOwnerThread { get; }

        public _VF_AVL_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_AVL_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_AVL_TABLE.RtlTable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_AVL_TABLE.ReservedNode),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_VF_AVL_TABLE.NodeToFree),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_VF_AVL_TABLE.Lock),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_VF_AVL_TABLE.ExclusiveOwnerThread),
                    new ulong[]
                    {
                        136UL
                    }
                }
            };
            Register<_VF_AVL_TABLE>((mem, ptr) => new _VF_AVL_TABLE(mem, ptr), offsets);
        }
    }
}