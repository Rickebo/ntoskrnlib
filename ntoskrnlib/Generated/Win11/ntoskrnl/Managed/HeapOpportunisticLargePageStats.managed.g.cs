using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_OPPORTUNISTIC_LARGE_PAGE_STATS")]
    public sealed class HeapOpportunisticLargePageStats : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SmallPagesInUseWithinLarge { get => ReadHere<ulong>(nameof(SmallPagesInUseWithinLarge)); set => WriteHere(nameof(SmallPagesInUseWithinLarge), value); }

        [Offset(8UL)]
        public ulong OpportunisticLargePageCount { get => ReadHere<ulong>(nameof(OpportunisticLargePageCount)); set => WriteHere(nameof(OpportunisticLargePageCount), value); }

        public HeapOpportunisticLargePageStats(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapOpportunisticLargePageStats>();
        }
    }
}