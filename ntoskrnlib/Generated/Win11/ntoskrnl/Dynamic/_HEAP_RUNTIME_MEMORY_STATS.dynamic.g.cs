using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_RUNTIME_MEMORY_STATS")]
    public sealed class _HEAP_RUNTIME_MEMORY_STATS : DynamicStructure
    {
        public ulong TotalReservedPages { get; }
        public ulong TotalCommittedPages { get; }
        public ulong FreeCommittedPages { get; }
        public ulong LfhFreeCommittedPages { get; }
        public ulong VsFreeCommittedPages { get; }
        public byte[] LargePageStats { get; }
        public _RTL_HP_SEG_ALLOC_POLICY LargePageUtilizationPolicy { get; }

        public _HEAP_RUNTIME_MEMORY_STATS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_RUNTIME_MEMORY_STATS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_RUNTIME_MEMORY_STATS.TotalReservedPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_RUNTIME_MEMORY_STATS.TotalCommittedPages),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_RUNTIME_MEMORY_STATS.FreeCommittedPages),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_RUNTIME_MEMORY_STATS.LfhFreeCommittedPages),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_RUNTIME_MEMORY_STATS.VsFreeCommittedPages),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_RUNTIME_MEMORY_STATS.LargePageStats),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_RUNTIME_MEMORY_STATS.LargePageUtilizationPolicy),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_HEAP_RUNTIME_MEMORY_STATS>((mem, ptr) => new _HEAP_RUNTIME_MEMORY_STATS(mem, ptr), offsets);
        }
    }
}