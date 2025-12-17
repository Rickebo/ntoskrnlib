using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_PSEUDO_TAG_ENTRY")]
    public sealed class _HEAP_PSEUDO_TAG_ENTRY : DynamicStructure
    {
        public uint Allocs { get; }
        public uint Frees { get; }
        public ulong Size { get; }

        public _HEAP_PSEUDO_TAG_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_PSEUDO_TAG_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_PSEUDO_TAG_ENTRY.Allocs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_PSEUDO_TAG_ENTRY.Frees),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_PSEUDO_TAG_ENTRY.Size),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_PSEUDO_TAG_ENTRY>((mem, ptr) => new _HEAP_PSEUDO_TAG_ENTRY(mem, ptr), offsets);
        }
    }
}