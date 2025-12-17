using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_COMBINE_STATISTICS")]
    public sealed class MiPageCombineStatistics : DynamicStructure
    {
        [Offset(0UL)]
        public ulong PagesScannedActive { get => ReadHere<ulong>(nameof(PagesScannedActive)); set => WriteHere(nameof(PagesScannedActive), value); }

        [Offset(8UL)]
        public ulong PagesScannedStandby { get => ReadHere<ulong>(nameof(PagesScannedStandby)); set => WriteHere(nameof(PagesScannedStandby), value); }

        [Offset(16UL)]
        public ulong PagesCombined { get => ReadHere<ulong>(nameof(PagesCombined)); set => WriteHere(nameof(PagesCombined), value); }

        [Offset(24UL)]
        public uint CombineScanCount { get => ReadHere<uint>(nameof(CombineScanCount)); set => WriteHere(nameof(CombineScanCount), value); }

        [Offset(28UL)]
        public int CombinedBlocksInUse { get => ReadHere<int>(nameof(CombinedBlocksInUse)); set => WriteHere(nameof(CombinedBlocksInUse), value); }

        [Offset(32UL)]
        public int SumCombinedBlocksReferenceCount { get => ReadHere<int>(nameof(SumCombinedBlocksReferenceCount)); set => WriteHere(nameof(SumCombinedBlocksReferenceCount), value); }

        [Offset(36UL)]
        public uint NonSlabPagesUsedForInPage { get => ReadHere<uint>(nameof(NonSlabPagesUsedForInPage)); set => WriteHere(nameof(NonSlabPagesUsedForInPage), value); }

        public MiPageCombineStatistics(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPageCombineStatistics>();
        }
    }
}