using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_PAGE_LISTS")]
    public sealed class _MI_PARTITION_PAGE_LISTS : DynamicStructure
    {
        public _MMPFNLIST ZeroedPageListHead { get; }
        public _MMPFNLIST FreePageListHead { get; }
        public _MMPFNLIST StandbyPageListHead { get; }
        public byte[] StandbyPageListByPriority { get; }
        public _MMPFNLIST ModifiedPageListNoReservation { get; }
        public _MMPFNLIST ModifiedPageListNoReservationCompress { get; }
        public byte[] ModifiedPageListByReservation { get; }
        public byte[] MappedPageListHead { get; }
        public _MMPFNLIST BadPageListHead { get; }
        public IntPtr HotZeroedPagesCountByColor { get; }
        public byte[] PageLocationList { get; }
        public uint[] StandbyRepurposedByPriority { get; }
        public ulong TransitionSharedPages { get; }
        public ulong[] TransitionSharedPagesPeak { get; }
        public byte[] MappedPageListHeadEvent { get; }
        public byte[] OldestStandbyPageCache { get; }
        public byte[] NewestStandbyPageCache { get; }
        public byte[] NewestStandbyPageCacheInserts { get; }
        public byte[] DecayClusterTimerHeads { get; }
        public uint DecayHand { get; }
        public byte StandbyListDiscard { get; }
        public byte FreeListDiscard { get; }
        public byte PfnBitMapsReady { get; }
        public ulong LastDecayHandUpdateTime { get; }
        public _MI_LDW_WORK_CONTEXT LastChanceLdwContext { get; }
        public int AvailableEventsLock { get; }
        public byte[] AvailablePageWaitStates { get; }
        public ulong TransitionPrivatePages { get; }
        public byte[] LargePfnBitMap { get; }
        public IntPtr FreeZeroListHeads { get; }
        public IntPtr FreeZeroPageSlists { get; }
        public IntPtr AvailablePagesAtMediumGranularity { get; }
        public IntPtr AvailablePagesAtLargeGranularity { get; }
        public byte[] LargePageRebuildCandidateBitmaps { get; }
        public IntPtr AvailablePagesAtHugeGranularity { get; }
        public int ProcessLargePageCacheLock { get; }
        public _LIST_ENTRY ProcessLargePageCacheLinks { get; }
        public uint ProcessLargePageCachePeriodicCount { get; }
        public byte[] LargePageCoalesceWorkerContexts { get; }
        public ulong LowMemoryConfiguredThreshold { get; }
        public ulong HighMemoryConfiguredThreshold { get; }
        public ulong LowMemoryThreshold { get; }
        public ulong HighMemoryThreshold { get; }
        public IntPtr HugePfnLists { get; }
        public ulong AvailableHugeIoRanges { get; }
        public ulong DriverPageCount { get; }
        public ulong DriverLastPage { get; }
        public ulong DriverNonSlabAttempted { get; }
        public ulong DriverSlabLastFailTime { get; }
        public ulong MdlPagesByListsTotal { get; }
        public ulong MdlPagesByListsFromSlab { get; }
        public ulong MdlPagesByListsSlabNotEligible { get; }
        public ulong MdlPagesPreferContiguousSlabEligible { get; }
        public ulong MdlPagesPreferContiguousFromSlab { get; }
        public ulong MdlSlabPagesFreeZeroedTotal { get; }
        public uint[] MdlSlabPagesFreeZeroedBuckets { get; }
        public ulong SystemPageTablePagesNoSlab { get; }

        public _MI_PARTITION_PAGE_LISTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_PAGE_LISTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.ZeroedPageListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.FreePageListHead),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.StandbyPageListHead),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.StandbyPageListByPriority),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.ModifiedPageListNoReservation),
                    new ulong[]
                    {
                        1088UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.ModifiedPageListNoReservationCompress),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.ModifiedPageListByReservation),
                    new ulong[]
                    {
                        1344UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MappedPageListHead),
                    new ulong[]
                    {
                        2752UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.BadPageListHead),
                    new ulong[]
                    {
                        4160UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.HotZeroedPagesCountByColor),
                    new ulong[]
                    {
                        4248UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.PageLocationList),
                    new ulong[]
                    {
                        4256UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.StandbyRepurposedByPriority),
                    new ulong[]
                    {
                        4320UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.TransitionSharedPages),
                    new ulong[]
                    {
                        4352UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.TransitionSharedPagesPeak),
                    new ulong[]
                    {
                        4360UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MappedPageListHeadEvent),
                    new ulong[]
                    {
                        4432UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.OldestStandbyPageCache),
                    new ulong[]
                    {
                        4864UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.NewestStandbyPageCache),
                    new ulong[]
                    {
                        8960UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.NewestStandbyPageCacheInserts),
                    new ulong[]
                    {
                        13056UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.DecayClusterTimerHeads),
                    new ulong[]
                    {
                        13184UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.DecayHand),
                    new ulong[]
                    {
                        13216UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.StandbyListDiscard),
                    new ulong[]
                    {
                        13220UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.FreeListDiscard),
                    new ulong[]
                    {
                        13221UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.PfnBitMapsReady),
                    new ulong[]
                    {
                        13222UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.LastDecayHandUpdateTime),
                    new ulong[]
                    {
                        13224UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.LastChanceLdwContext),
                    new ulong[]
                    {
                        13232UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.AvailableEventsLock),
                    new ulong[]
                    {
                        13312UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.AvailablePageWaitStates),
                    new ulong[]
                    {
                        13320UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.TransitionPrivatePages),
                    new ulong[]
                    {
                        13440UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.LargePfnBitMap),
                    new ulong[]
                    {
                        13448UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.FreeZeroListHeads),
                    new ulong[]
                    {
                        13480UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.FreeZeroPageSlists),
                    new ulong[]
                    {
                        13488UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.AvailablePagesAtMediumGranularity),
                    new ulong[]
                    {
                        13496UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.AvailablePagesAtLargeGranularity),
                    new ulong[]
                    {
                        13504UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.LargePageRebuildCandidateBitmaps),
                    new ulong[]
                    {
                        13512UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.AvailablePagesAtHugeGranularity),
                    new ulong[]
                    {
                        13560UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.ProcessLargePageCacheLock),
                    new ulong[]
                    {
                        13568UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.ProcessLargePageCacheLinks),
                    new ulong[]
                    {
                        13576UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.ProcessLargePageCachePeriodicCount),
                    new ulong[]
                    {
                        13592UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.LargePageCoalesceWorkerContexts),
                    new ulong[]
                    {
                        13600UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.LowMemoryConfiguredThreshold),
                    new ulong[]
                    {
                        13744UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.HighMemoryConfiguredThreshold),
                    new ulong[]
                    {
                        13752UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.LowMemoryThreshold),
                    new ulong[]
                    {
                        13760UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.HighMemoryThreshold),
                    new ulong[]
                    {
                        13768UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.HugePfnLists),
                    new ulong[]
                    {
                        13776UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.AvailableHugeIoRanges),
                    new ulong[]
                    {
                        13784UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.DriverPageCount),
                    new ulong[]
                    {
                        13792UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.DriverLastPage),
                    new ulong[]
                    {
                        13800UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.DriverNonSlabAttempted),
                    new ulong[]
                    {
                        13808UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.DriverSlabLastFailTime),
                    new ulong[]
                    {
                        13816UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MdlPagesByListsTotal),
                    new ulong[]
                    {
                        13824UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MdlPagesByListsFromSlab),
                    new ulong[]
                    {
                        13832UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MdlPagesByListsSlabNotEligible),
                    new ulong[]
                    {
                        13840UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MdlPagesPreferContiguousSlabEligible),
                    new ulong[]
                    {
                        13848UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MdlPagesPreferContiguousFromSlab),
                    new ulong[]
                    {
                        13856UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MdlSlabPagesFreeZeroedTotal),
                    new ulong[]
                    {
                        13864UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.MdlSlabPagesFreeZeroedBuckets),
                    new ulong[]
                    {
                        13872UL
                    }
                },
                {
                    nameof(_MI_PARTITION_PAGE_LISTS.SystemPageTablePagesNoSlab),
                    new ulong[]
                    {
                        13888UL
                    }
                }
            };
            Register<_MI_PARTITION_PAGE_LISTS>((mem, ptr) => new _MI_PARTITION_PAGE_LISTS(mem, ptr), offsets);
        }
    }
}