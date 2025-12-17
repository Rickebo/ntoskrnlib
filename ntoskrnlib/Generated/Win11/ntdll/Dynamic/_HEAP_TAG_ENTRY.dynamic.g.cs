using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_TAG_ENTRY")]
    public sealed class _HEAP_TAG_ENTRY : DynamicStructure
    {
        public uint Allocs { get; }
        public uint Frees { get; }
        public ulong Size { get; }
        public ushort TagIndex { get; }
        public ushort CreatorBackTraceIndex { get; }
        public short[] TagName { get; }

        public _HEAP_TAG_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_TAG_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_TAG_ENTRY.Allocs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_TAG_ENTRY.Frees),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_TAG_ENTRY.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_TAG_ENTRY.TagIndex),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_TAG_ENTRY.CreatorBackTraceIndex),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_HEAP_TAG_ENTRY.TagName),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_HEAP_TAG_ENTRY>((mem, ptr) => new _HEAP_TAG_ENTRY(mem, ptr), offsets);
        }
    }
}