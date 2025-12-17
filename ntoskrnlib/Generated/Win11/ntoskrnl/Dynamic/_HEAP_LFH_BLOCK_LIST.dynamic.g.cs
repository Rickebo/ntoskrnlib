using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_BLOCK_LIST")]
    public sealed class _HEAP_LFH_BLOCK_LIST : DynamicStructure
    {
        public ushort Next { get; }
        public ushort Count { get; }
        public _HEAP_LFH_BLOCK_SLIST SList { get; }
        public uint ListFields { get; }

        public _HEAP_LFH_BLOCK_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_BLOCK_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_BLOCK_LIST.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BLOCK_LIST.Count),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BLOCK_LIST.SList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_BLOCK_LIST.ListFields),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_BLOCK_LIST>((mem, ptr) => new _HEAP_LFH_BLOCK_LIST(mem, ptr), offsets);
        }
    }
}