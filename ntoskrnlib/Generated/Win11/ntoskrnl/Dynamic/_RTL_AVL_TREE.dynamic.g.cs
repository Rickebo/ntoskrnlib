using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_AVL_TREE")]
    public sealed class _RTL_AVL_TREE : DynamicStructure
    {
        public IntPtr Root { get; }

        public _RTL_AVL_TREE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_AVL_TREE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_AVL_TREE.Root),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_AVL_TREE>((mem, ptr) => new _RTL_AVL_TREE(mem, ptr), offsets);
        }
    }
}