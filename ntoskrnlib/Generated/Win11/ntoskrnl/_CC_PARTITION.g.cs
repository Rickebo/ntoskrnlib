#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1600)]
    public partial struct _CC_PARTITION
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeByteSize;
        [FieldOffset(8)]
        public IntPtr PartitionObject;
        [FieldOffset(16)]
        public _LIST_ENTRY NumaNodeList;
        [FieldOffset(32)]
        public _LIST_ENTRY VolumeList;
        [FieldOffset(48)]
        public uint VolumeCount;
        [FieldOffset(56)]
        public _KEVENT LastVolumeEvent;
        [FieldOffset(80)]
        public _LIST_ENTRY DeletedVolumeList;
        [FieldOffset(96)]
        public _LIST_ENTRY DeletePVCMWorkerThreadList;
        [FieldOffset(112)]
        public _LIST_ENTRY DelayDeleteVolumeList;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public IntPtr[] NumaNodeBlock;
        [FieldOffset(640)]
        public _LIST_ENTRY CleanSharedCacheMapList;
        [FieldOffset(656)]
        public _LIST_ENTRY CleanSharedCacheMapWithLogHandleList;
        [FieldOffset(672)]
        public _SHARED_CACHE_MAP_LIST_CURSOR DirtySharedCacheMapList;
        [FieldOffset(696)]
        public _SHARED_CACHE_MAP_LIST_CURSOR LazyWriteCursor;
        [FieldOffset(720)]
        public _LIST_ENTRY DirtySharedCacheMapWithLogHandleList;
        [FieldOffset(768)]
        public ulong PrivateLock;
        [FieldOffset(776)]
        public uint ConsecutiveWorklessLazyScanCount;
        [FieldOffset(780)]
        public byte ForcedDisableLazywriteScan;
        [FieldOffset(832)]
        public ulong WorkQueueLock;
        [FieldOffset(840)]
        public uint NumberWorkerThreads;
        [FieldOffset(848)]
        public _LIST_ENTRY PostTickWorkQueue;
        [FieldOffset(864)]
        public uint MaxExtraWriteBehindThreads;
        [FieldOffset(868)]
        public uint MaxCacheMapUninitThreads;
        [FieldOffset(872)]
        public uint PostTickWorkItemCount;
        [FieldOffset(880)]
        public _KEVENT LowMemoryEvent;
        [FieldOffset(904)]
        public _KEVENT PowerEvent;
        [FieldOffset(928)]
        public _KEVENT WaitingForTeardownEvent;
        [FieldOffset(952)]
        public _KEVENT CoalescingFlushEvent;
        [FieldOffset(976)]
        public uint PagesYetToWrite;
        [FieldOffset(984)]
        public _LAZY_WRITER LazyWriter;
        [FieldOffset(1056)]
        public _DIRTY_PAGE_STATISTICS DirtyPageStatistics;
        [FieldOffset(1080)]
        public _DIRTY_PAGE_THRESHOLDS DirtyPageThresholds;
        [FieldOffset(1136)]
        public IntPtr ThroughputStats;
        [FieldOffset(1144)]
        public ulong AverageAvailablePages;
        [FieldOffset(1152)]
        public ulong AverageDirtyPages;
        [FieldOffset(1160)]
        public ulong PagesSkippedDueToHotSpot;
        [FieldOffset(1168)]
        public _LIST_ENTRY DeferredWrites;
        [FieldOffset(1216)]
        public ulong DeferredWriteSpinLock;
        [FieldOffset(1224)]
        public _EX_PUSH_LOCK AsyncReadWorkQueueLock;
        [FieldOffset(1232)]
        public _LIST_ENTRY VacbFreeHighPriorityList;
        [FieldOffset(1248)]
        public uint NumberOfFreeHighPriorityVacbs;
        [FieldOffset(1256)]
        public IntPtr LowPriWorkerThread;
        [FieldOffset(1264)]
        public IntPtr LowPriSharedCacheMap;
        [FieldOffset(1272)]
        public int LowPriOldCpuPriority;
        [FieldOffset(1276)]
        public uint LowPriOldIoPriority;
        [FieldOffset(1280)]
        public _EX_PUSH_LOCK LowPriorityWorkerThreadLock;
        [FieldOffset(1288)]
        public uint MaxNumberOfWriteBehindThreads;
        [FieldOffset(1292)]
        public byte CoalescingState;
        [FieldOffset(1293)]
        public byte ActivePartition;
        [FieldOffset(1294)]
        public byte RundownPhase;
        [FieldOffset(1296)]
        public long RefCount;
        [FieldOffset(1304)]
        public _KEVENT ExitEvent;
        [FieldOffset(1328)]
        public _KEVENT FinalDereferenceEvent;
        [FieldOffset(1352)]
        public IntPtr LazyWriteScanThreadHandle;
        [FieldOffset(1360)]
        public _CC_LWS_PACKET LWSPacket;
        [FieldOffset(1376)]
        public _KTIMER PVCMDelayedDeleteTimer;
        [FieldOffset(1440)]
        public _KDPC PVCMDelayedDeleteTimerDpc;
        [FieldOffset(1504)]
        public byte PVCMDelayedDeleteTimerArmed;
        [FieldOffset(1512)]
        public _WORK_QUEUE_ITEM PVCMDelayedDeleteWorkItem;
    }
}