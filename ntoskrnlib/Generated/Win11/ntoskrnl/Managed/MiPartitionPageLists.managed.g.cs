using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_PAGE_LISTS")]
    public sealed class MiPartitionPageLists : DynamicStructure
    {
        [Offset(0UL)]
        public Mmpfnlist ZeroedPageListHead { get => ReadStructure<Mmpfnlist>(nameof(ZeroedPageListHead)); set => WriteStructure(nameof(ZeroedPageListHead), value); }

        [Offset(128UL)]
        public Mmpfnlist FreePageListHead { get => ReadStructure<Mmpfnlist>(nameof(FreePageListHead)); set => WriteStructure(nameof(FreePageListHead), value); }

        [Offset(256UL)]
        public Mmpfnlist StandbyPageListHead { get => ReadStructure<Mmpfnlist>(nameof(StandbyPageListHead)); set => WriteStructure(nameof(StandbyPageListHead), value); }

        [Offset(384UL)]
        [Length(8)]
        public DynamicArray StandbyPageListByPriority { get => ReadStructure<DynamicArray>(nameof(StandbyPageListByPriority)); set => WriteStructure(nameof(StandbyPageListByPriority), value); }

        [Offset(1088UL)]
        public Mmpfnlist ModifiedPageListNoReservation { get => ReadStructure<Mmpfnlist>(nameof(ModifiedPageListNoReservation)); set => WriteStructure(nameof(ModifiedPageListNoReservation), value); }

        [Offset(1216UL)]
        public Mmpfnlist ModifiedPageListNoReservationCompress { get => ReadStructure<Mmpfnlist>(nameof(ModifiedPageListNoReservationCompress)); set => WriteStructure(nameof(ModifiedPageListNoReservationCompress), value); }

        [Offset(1344UL)]
        [Length(16)]
        public DynamicArray ModifiedPageListByReservation { get => ReadStructure<DynamicArray>(nameof(ModifiedPageListByReservation)); set => WriteStructure(nameof(ModifiedPageListByReservation), value); }

        [Offset(2752UL)]
        [Length(16)]
        public DynamicArray MappedPageListHead { get => ReadStructure<DynamicArray>(nameof(MappedPageListHead)); set => WriteStructure(nameof(MappedPageListHead), value); }

        [Offset(4160UL)]
        public Mmpfnlist BadPageListHead { get => ReadStructure<Mmpfnlist>(nameof(BadPageListHead)); set => WriteStructure(nameof(BadPageListHead), value); }

        [Offset(4248UL)]
        public IntPtr HotZeroedPagesCountByColor { get => ReadHere<IntPtr>(nameof(HotZeroedPagesCountByColor)); set => WriteHere(nameof(HotZeroedPagesCountByColor), value); }

        [Offset(4256UL)]
        [Length(8)]
        public DynamicArray PageLocationList { get => ReadStructure<DynamicArray>(nameof(PageLocationList)); set => WriteStructure(nameof(PageLocationList), value); }

        [Offset(4320UL)]
        [Length(8)]
        public DynamicArray StandbyRepurposedByPriority { get => ReadStructure<DynamicArray>(nameof(StandbyRepurposedByPriority)); set => WriteStructure(nameof(StandbyRepurposedByPriority), value); }

        [Offset(4352UL)]
        public ulong TransitionSharedPages { get => ReadHere<ulong>(nameof(TransitionSharedPages)); set => WriteHere(nameof(TransitionSharedPages), value); }

        [Offset(4360UL)]
        [Length(9)]
        public DynamicArray TransitionSharedPagesPeak { get => ReadStructure<DynamicArray>(nameof(TransitionSharedPagesPeak)); set => WriteStructure(nameof(TransitionSharedPagesPeak), value); }

        [Offset(4432UL)]
        [Length(16)]
        public DynamicArray MappedPageListHeadEvent { get => ReadStructure<DynamicArray>(nameof(MappedPageListHeadEvent)); set => WriteStructure(nameof(MappedPageListHeadEvent), value); }

        [Offset(4864UL)]
        [Length(8)]
        public DynamicArray OldestStandbyPageCache { get => ReadStructure<DynamicArray>(nameof(OldestStandbyPageCache)); set => WriteStructure(nameof(OldestStandbyPageCache), value); }

        [Offset(8960UL)]
        [Length(8)]
        public DynamicArray NewestStandbyPageCache { get => ReadStructure<DynamicArray>(nameof(NewestStandbyPageCache)); set => WriteStructure(nameof(NewestStandbyPageCache), value); }

        [Offset(13056UL)]
        [Length(2)]
        public DynamicArray NewestStandbyPageCacheInserts { get => ReadStructure<DynamicArray>(nameof(NewestStandbyPageCacheInserts)); set => WriteStructure(nameof(NewestStandbyPageCacheInserts), value); }

        [Offset(13184UL)]
        [Length(4)]
        public DynamicArray DecayClusterTimerHeads { get => ReadStructure<DynamicArray>(nameof(DecayClusterTimerHeads)); set => WriteStructure(nameof(DecayClusterTimerHeads), value); }

        [Offset(13216UL)]
        public uint DecayHand { get => ReadHere<uint>(nameof(DecayHand)); set => WriteHere(nameof(DecayHand), value); }

        [Offset(13220UL)]
        public byte StandbyListDiscard { get => ReadHere<byte>(nameof(StandbyListDiscard)); set => WriteHere(nameof(StandbyListDiscard), value); }

        [Offset(13221UL)]
        public byte FreeListDiscard { get => ReadHere<byte>(nameof(FreeListDiscard)); set => WriteHere(nameof(FreeListDiscard), value); }

        [Offset(13222UL)]
        public byte PfnBitMapsReady { get => ReadHere<byte>(nameof(PfnBitMapsReady)); set => WriteHere(nameof(PfnBitMapsReady), value); }

        [Offset(13224UL)]
        public ulong LastDecayHandUpdateTime { get => ReadHere<ulong>(nameof(LastDecayHandUpdateTime)); set => WriteHere(nameof(LastDecayHandUpdateTime), value); }

        [Offset(13232UL)]
        public MiLdwWorkContext LastChanceLdwContext { get => ReadStructure<MiLdwWorkContext>(nameof(LastChanceLdwContext)); set => WriteStructure(nameof(LastChanceLdwContext), value); }

        [Offset(13312UL)]
        public int AvailableEventsLock { get => ReadHere<int>(nameof(AvailableEventsLock)); set => WriteHere(nameof(AvailableEventsLock), value); }

        [Offset(13320UL)]
        [Length(3)]
        public DynamicArray AvailablePageWaitStates { get => ReadStructure<DynamicArray>(nameof(AvailablePageWaitStates)); set => WriteStructure(nameof(AvailablePageWaitStates), value); }

        [Offset(13440UL)]
        public ulong TransitionPrivatePages { get => ReadHere<ulong>(nameof(TransitionPrivatePages)); set => WriteHere(nameof(TransitionPrivatePages), value); }

        [Offset(13448UL)]
        [Length(2)]
        public DynamicArray LargePfnBitMap { get => ReadStructure<DynamicArray>(nameof(LargePfnBitMap)); set => WriteStructure(nameof(LargePfnBitMap), value); }

        [Offset(13480UL)]
        public IntPtr FreeZeroListHeads { get => ReadHere<IntPtr>(nameof(FreeZeroListHeads)); set => WriteHere(nameof(FreeZeroListHeads), value); }

        [Offset(13488UL)]
        public IntPtr FreeZeroPageSlists { get => ReadHere<IntPtr>(nameof(FreeZeroPageSlists)); set => WriteHere(nameof(FreeZeroPageSlists), value); }

        [Offset(13496UL)]
        public IntPtr AvailablePagesAtMediumGranularity { get => ReadHere<IntPtr>(nameof(AvailablePagesAtMediumGranularity)); set => WriteHere(nameof(AvailablePagesAtMediumGranularity), value); }

        [Offset(13504UL)]
        public IntPtr AvailablePagesAtLargeGranularity { get => ReadHere<IntPtr>(nameof(AvailablePagesAtLargeGranularity)); set => WriteHere(nameof(AvailablePagesAtLargeGranularity), value); }

        [Offset(13512UL)]
        [Length(3)]
        public DynamicArray LargePageRebuildCandidateBitmaps { get => ReadStructure<DynamicArray>(nameof(LargePageRebuildCandidateBitmaps)); set => WriteStructure(nameof(LargePageRebuildCandidateBitmaps), value); }

        [Offset(13560UL)]
        public IntPtr AvailablePagesAtHugeGranularity { get => ReadHere<IntPtr>(nameof(AvailablePagesAtHugeGranularity)); set => WriteHere(nameof(AvailablePagesAtHugeGranularity), value); }

        [Offset(13568UL)]
        public int ProcessLargePageCacheLock { get => ReadHere<int>(nameof(ProcessLargePageCacheLock)); set => WriteHere(nameof(ProcessLargePageCacheLock), value); }

        [Offset(13576UL)]
        public ListEntry ProcessLargePageCacheLinks { get => ReadStructure<ListEntry>(nameof(ProcessLargePageCacheLinks)); set => WriteStructure(nameof(ProcessLargePageCacheLinks), value); }

        [Offset(13592UL)]
        public uint ProcessLargePageCachePeriodicCount { get => ReadHere<uint>(nameof(ProcessLargePageCachePeriodicCount)); set => WriteHere(nameof(ProcessLargePageCachePeriodicCount), value); }

        [Offset(13600UL)]
        [Length(3)]
        public DynamicArray LargePageCoalesceWorkerContexts { get => ReadStructure<DynamicArray>(nameof(LargePageCoalesceWorkerContexts)); set => WriteStructure(nameof(LargePageCoalesceWorkerContexts), value); }

        [Offset(13744UL)]
        public ulong LowMemoryConfiguredThreshold { get => ReadHere<ulong>(nameof(LowMemoryConfiguredThreshold)); set => WriteHere(nameof(LowMemoryConfiguredThreshold), value); }

        [Offset(13752UL)]
        public ulong HighMemoryConfiguredThreshold { get => ReadHere<ulong>(nameof(HighMemoryConfiguredThreshold)); set => WriteHere(nameof(HighMemoryConfiguredThreshold), value); }

        [Offset(13760UL)]
        public ulong LowMemoryThreshold { get => ReadHere<ulong>(nameof(LowMemoryThreshold)); set => WriteHere(nameof(LowMemoryThreshold), value); }

        [Offset(13768UL)]
        public ulong HighMemoryThreshold { get => ReadHere<ulong>(nameof(HighMemoryThreshold)); set => WriteHere(nameof(HighMemoryThreshold), value); }

        [Offset(13776UL)]
        public IntPtr HugePfnLists { get => ReadHere<IntPtr>(nameof(HugePfnLists)); set => WriteHere(nameof(HugePfnLists), value); }

        [Offset(13784UL)]
        public ulong AvailableHugeIoRanges { get => ReadHere<ulong>(nameof(AvailableHugeIoRanges)); set => WriteHere(nameof(AvailableHugeIoRanges), value); }

        [Offset(13792UL)]
        public ulong DriverPageCount { get => ReadHere<ulong>(nameof(DriverPageCount)); set => WriteHere(nameof(DriverPageCount), value); }

        [Offset(13800UL)]
        public ulong DriverLastPage { get => ReadHere<ulong>(nameof(DriverLastPage)); set => WriteHere(nameof(DriverLastPage), value); }

        [Offset(13808UL)]
        public ulong DriverNonSlabAttempted { get => ReadHere<ulong>(nameof(DriverNonSlabAttempted)); set => WriteHere(nameof(DriverNonSlabAttempted), value); }

        [Offset(13816UL)]
        public ulong DriverSlabLastFailTime { get => ReadHere<ulong>(nameof(DriverSlabLastFailTime)); set => WriteHere(nameof(DriverSlabLastFailTime), value); }

        [Offset(13824UL)]
        public ulong MdlPagesByListsTotal { get => ReadHere<ulong>(nameof(MdlPagesByListsTotal)); set => WriteHere(nameof(MdlPagesByListsTotal), value); }

        [Offset(13832UL)]
        public ulong MdlPagesByListsFromSlab { get => ReadHere<ulong>(nameof(MdlPagesByListsFromSlab)); set => WriteHere(nameof(MdlPagesByListsFromSlab), value); }

        [Offset(13840UL)]
        public ulong MdlPagesByListsSlabNotEligible { get => ReadHere<ulong>(nameof(MdlPagesByListsSlabNotEligible)); set => WriteHere(nameof(MdlPagesByListsSlabNotEligible), value); }

        [Offset(13848UL)]
        public ulong MdlPagesPreferContiguousSlabEligible { get => ReadHere<ulong>(nameof(MdlPagesPreferContiguousSlabEligible)); set => WriteHere(nameof(MdlPagesPreferContiguousSlabEligible), value); }

        [Offset(13856UL)]
        public ulong MdlPagesPreferContiguousFromSlab { get => ReadHere<ulong>(nameof(MdlPagesPreferContiguousFromSlab)); set => WriteHere(nameof(MdlPagesPreferContiguousFromSlab), value); }

        [Offset(13864UL)]
        public ulong MdlSlabPagesFreeZeroedTotal { get => ReadHere<ulong>(nameof(MdlSlabPagesFreeZeroedTotal)); set => WriteHere(nameof(MdlSlabPagesFreeZeroedTotal), value); }

        [Offset(13872UL)]
        [Length(4)]
        public DynamicArray MdlSlabPagesFreeZeroedBuckets { get => ReadStructure<DynamicArray>(nameof(MdlSlabPagesFreeZeroedBuckets)); set => WriteStructure(nameof(MdlSlabPagesFreeZeroedBuckets), value); }

        [Offset(13888UL)]
        public ulong SystemPageTablePagesNoSlab { get => ReadHere<ulong>(nameof(SystemPageTablePagesNoSlab)); set => WriteHere(nameof(SystemPageTablePagesNoSlab), value); }

        public MiPartitionPageLists(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionPageLists>();
        }
    }
}