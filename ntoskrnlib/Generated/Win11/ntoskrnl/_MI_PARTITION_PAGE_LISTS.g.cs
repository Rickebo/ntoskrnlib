#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 13952)]
    public partial struct _MI_PARTITION_PAGE_LISTS
    {
        [FieldOffset(0)]
        public _MMPFNLIST ZeroedPageListHead;
        [FieldOffset(128)]
        public _MMPFNLIST FreePageListHead;
        [FieldOffset(256)]
        public _MMPFNLIST StandbyPageListHead;
        [FieldOffset(384)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _MMPFNLIST[] StandbyPageListByPriority;
        [FieldOffset(1088)]
        public _MMPFNLIST ModifiedPageListNoReservation;
        [FieldOffset(1216)]
        public _MMPFNLIST ModifiedPageListNoReservationCompress;
        [FieldOffset(1344)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _MMPFNLIST[] ModifiedPageListByReservation;
        [FieldOffset(2752)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _MMPFNLIST[] MappedPageListHead;
        [FieldOffset(4160)]
        public _MMPFNLIST BadPageListHead;
        [FieldOffset(4248)]
        public IntPtr HotZeroedPagesCountByColor;
        [FieldOffset(4256)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public IntPtr[] PageLocationList;
        [FieldOffset(4320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] StandbyRepurposedByPriority;
        [FieldOffset(4352)]
        public ulong TransitionSharedPages;
        [FieldOffset(4360)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public ulong[] TransitionSharedPagesPeak;
        [FieldOffset(4432)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _KEVENT[] MappedPageListHeadEvent;
        [FieldOffset(4864)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _MI_STANDBY_LOOKASIDE[] OldestStandbyPageCache;
        [FieldOffset(8960)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _MI_STANDBY_LOOKASIDE[] NewestStandbyPageCache;
        [FieldOffset(13056)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] NewestStandbyPageCacheInserts;
        [FieldOffset(13184)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_DECAY_TIMER_LINK[] DecayClusterTimerHeads;
        [FieldOffset(13216)]
        public uint DecayHand;
        [FieldOffset(13220)]
        public byte StandbyListDiscard;
        [FieldOffset(13221)]
        public byte FreeListDiscard;
        [FieldOffset(13222)]
        public byte PfnBitMapsReady;
        [FieldOffset(13224)]
        public ulong LastDecayHandUpdateTime;
        [FieldOffset(13232)]
        public _MI_LDW_WORK_CONTEXT LastChanceLdwContext;
        [FieldOffset(13312)]
        public int AvailableEventsLock;
        [FieldOffset(13320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public _MI_AVAILABLE_PAGE_WAIT_STATES[] AvailablePageWaitStates;
        [FieldOffset(13440)]
        public ulong TransitionPrivatePages;
        [FieldOffset(13448)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _RTL_BITMAP_EX[] LargePfnBitMap;
        [FieldOffset(13480)]
        public IntPtr FreeZeroListHeads;
        [FieldOffset(13488)]
        public IntPtr FreeZeroPageSlists;
        [FieldOffset(13496)]
        public IntPtr AvailablePagesAtMediumGranularity;
        [FieldOffset(13504)]
        public IntPtr AvailablePagesAtLargeGranularity;
        [FieldOffset(13512)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public _RTL_BITMAP_EX[] LargePageRebuildCandidateBitmaps;
        [FieldOffset(13560)]
        public IntPtr AvailablePagesAtHugeGranularity;
        [FieldOffset(13568)]
        public int ProcessLargePageCacheLock;
        [FieldOffset(13576)]
        public _LIST_ENTRY ProcessLargePageCacheLinks;
        [FieldOffset(13592)]
        public uint ProcessLargePageCachePeriodicCount;
        [FieldOffset(13600)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public _MI_LARGE_PAGE_COALESCE_WORKER_CONTEXT[] LargePageCoalesceWorkerContexts;
        [FieldOffset(13744)]
        public ulong LowMemoryConfiguredThreshold;
        [FieldOffset(13752)]
        public ulong HighMemoryConfiguredThreshold;
        [FieldOffset(13760)]
        public ulong LowMemoryThreshold;
        [FieldOffset(13768)]
        public ulong HighMemoryThreshold;
        [FieldOffset(13776)]
        public IntPtr HugePfnLists;
        [FieldOffset(13784)]
        public ulong AvailableHugeIoRanges;
        [FieldOffset(13792)]
        public ulong DriverPageCount;
        [FieldOffset(13800)]
        public ulong DriverLastPage;
        [FieldOffset(13808)]
        public ulong DriverNonSlabAttempted;
        [FieldOffset(13816)]
        public ulong DriverSlabLastFailTime;
        [FieldOffset(13824)]
        public ulong MdlPagesByListsTotal;
        [FieldOffset(13832)]
        public ulong MdlPagesByListsFromSlab;
        [FieldOffset(13840)]
        public ulong MdlPagesByListsSlabNotEligible;
        [FieldOffset(13848)]
        public ulong MdlPagesPreferContiguousSlabEligible;
        [FieldOffset(13856)]
        public ulong MdlPagesPreferContiguousFromSlab;
        [FieldOffset(13864)]
        public ulong MdlSlabPagesFreeZeroedTotal;
        [FieldOffset(13872)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] MdlSlabPagesFreeZeroedBuckets;
        [FieldOffset(13888)]
        public ulong SystemPageTablePagesNoSlab;
    }
}