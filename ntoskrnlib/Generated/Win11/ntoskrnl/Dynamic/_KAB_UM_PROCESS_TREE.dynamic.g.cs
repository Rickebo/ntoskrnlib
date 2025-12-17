using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KAB_UM_PROCESS_TREE")]
    public sealed class _KAB_UM_PROCESS_TREE : DynamicStructure
    {
        public _RTL_RB_TREE Tree { get; }
        public ulong TreeLock { get; }

        public _KAB_UM_PROCESS_TREE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KAB_UM_PROCESS_TREE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KAB_UM_PROCESS_TREE.Tree),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KAB_UM_PROCESS_TREE.TreeLock),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KAB_UM_PROCESS_TREE>((mem, ptr) => new _KAB_UM_PROCESS_TREE(mem, ptr), offsets);
        }
    }
}