using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_HEAP_POOL_NODE")]
    public sealed class _EX_HEAP_POOL_NODE : DynamicStructure
    {
        public byte[] Heaps { get; }
        public byte[] Lookasides { get; }

        public _EX_HEAP_POOL_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_HEAP_POOL_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_HEAP_POOL_NODE.Heaps),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_HEAP_POOL_NODE.Lookasides),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_EX_HEAP_POOL_NODE>((mem, ptr) => new _EX_HEAP_POOL_NODE(mem, ptr), offsets);
        }
    }
}