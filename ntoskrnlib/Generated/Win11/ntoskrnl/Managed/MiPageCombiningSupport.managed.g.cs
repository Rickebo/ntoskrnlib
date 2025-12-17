using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_COMBINING_SUPPORT")]
    public sealed class MiPageCombiningSupport : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(8UL)]
        public ListEntry ArbitraryPfnMapList { get => ReadStructure<ListEntry>(nameof(ArbitraryPfnMapList)); set => WriteStructure(nameof(ArbitraryPfnMapList), value); }

        [Offset(24UL)]
        public MiCombineWorkitem FreeCombinePoolItem { get => ReadStructure<MiCombineWorkitem>(nameof(FreeCombinePoolItem)); set => WriteStructure(nameof(FreeCombinePoolItem), value); }

        [Offset(64UL)]
        public uint CombiningThreadCount { get => ReadHere<uint>(nameof(CombiningThreadCount)); set => WriteHere(nameof(CombiningThreadCount), value); }

        [Offset(72UL)]
        public ListEntry CombinePageFreeList { get => ReadStructure<ListEntry>(nameof(CombinePageFreeList)); set => WriteStructure(nameof(CombinePageFreeList), value); }

        [Offset(88UL)]
        public int CombineFreeListLock { get => ReadHere<int>(nameof(CombineFreeListLock)); set => WriteHere(nameof(CombineFreeListLock), value); }

        [Offset(96UL)]
        [Length(16)]
        public DynamicArray CombinePageListHeads { get => ReadStructure<DynamicArray>(nameof(CombinePageListHeads)); set => WriteStructure(nameof(CombinePageListHeads), value); }

        [Offset(352UL)]
        public ulong CommonPageCombineDomain { get => ReadHere<ulong>(nameof(CommonPageCombineDomain)); set => WriteHere(nameof(CommonPageCombineDomain), value); }

        [Offset(360UL)]
        public MiPageCombineStatistics PageCombineStats { get => ReadStructure<MiPageCombineStatistics>(nameof(PageCombineStats)); set => WriteStructure(nameof(PageCombineStats), value); }

        public MiPageCombiningSupport(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPageCombiningSupport>();
        }
    }
}