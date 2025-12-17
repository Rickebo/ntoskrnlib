using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS")]
    public sealed class _HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS : DynamicStructure
    {
        public ulong SmallPagesInUseWithinLarge { get; }
        public ulong OpportunisticLargePageCount { get; }

        public _HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS.SmallPagesInUseWithinLarge),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS.OpportunisticLargePageCount),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS>((mem, ptr) => new _HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS(mem, ptr), offsets);
        }
    }
}