#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1664)]
    public partial struct _PRIVATE_VOLUME_CACHEMAP
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeByteSize;
        [FieldOffset(4)]
        public uint UseCount;
        [FieldOffset(8)]
        public long RefCount;
        [FieldOffset(16)]
        public IntPtr DeviceObject;
        [FieldOffset(24)]
        public uint VolumeId;
        [FieldOffset(32)]
        public IntPtr Partition;
        [FieldOffset(40)]
        public IntPtr VolumeCacheMap;
        [FieldOffset(48)]
        public _LIST_ENTRY NumaNodeList;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public IntPtr[] NumaNodeBlock;
        [FieldOffset(576)]
        public _LIST_ENTRY PartitionVolumeLinks;
        [FieldOffset(592)]
        public _LIST_ENTRY VolumeCacheMapLinks;
        [FieldOffset(608)]
        public _LIST_ENTRY CleanSharedCacheMapList;
        [FieldOffset(624)]
        public _LIST_ENTRY CleanSharedCacheMapWithLogHandleList;
        [FieldOffset(640)]
        public _SHARED_CACHE_MAP_LIST_CURSOR DirtySharedCacheMapList;
        [FieldOffset(664)]
        public _SHARED_CACHE_MAP_LIST_CURSOR LazyWriteCursor;
        [FieldOffset(688)]
        public _LIST_ENTRY DirtySharedCacheMapWithLogHandleList;
        [FieldOffset(704)]
        public uint ConsecutiveWorklessLazyScanCount;
        [FieldOffset(708)]
        public byte ForcedDisableLazywriteScan;
        [FieldOffset(768)]
        public ulong WorkQueueLock;
        [FieldOffset(776)]
        public uint NumberWorkerThreads;
        [FieldOffset(784)]
        public _LIST_ENTRY PostTickWorkQueue;
        [FieldOffset(800)]
        public uint MaxExtraWriteBehindThreads;
        [FieldOffset(804)]
        public uint MaxCacheMapUninitThreads;
        [FieldOffset(808)]
        public uint PostTickWorkItemCount;
        [FieldOffset(816)]
        public _KEVENT LowMemoryEvent;
        [FieldOffset(840)]
        public _KEVENT PowerEvent;
        [FieldOffset(864)]
        public _KEVENT WaitingForTeardownEvent;
        [FieldOffset(888)]
        public _KEVENT CoalescingFlushEvent;
        [FieldOffset(912)]
        public uint PagesYetToWrite;
        [FieldOffset(920)]
        public _LAZY_WRITER LazyWriter;
        [FieldOffset(992)]
        public _DIRTY_PAGE_STATISTICS DirtyPageStatistics;
        [FieldOffset(1016)]
        public _DIRTY_PAGE_THRESHOLDS DirtyPageThresholds;
        [FieldOffset(1072)]
        public IntPtr ThroughputStats;
        [FieldOffset(1080)]
        public ulong AverageAvailablePages;
        [FieldOffset(1088)]
        public ulong AverageDirtyPages;
        [FieldOffset(1096)]
        public ulong PagesSkippedDueToHotSpot;
        [FieldOffset(1104)]
        public _LIST_ENTRY DeferredWrites;
        [FieldOffset(1152)]
        public ulong DeferredWriteSpinLock;
        [FieldOffset(1160)]
        public _EX_PUSH_LOCK AsyncReadWorkQueueLock;
        [FieldOffset(1168)]
        public uint MaxNumberOfWriteBehindThreads;
        [FieldOffset(1172)]
        public byte CoalescingState;
        [FieldOffset(1173)]
        public byte InitComplete;
        [FieldOffset(1176)]
        public _KEVENT ExitEvent;
        [FieldOffset(1200)]
        public _KEVENT FinalDereferenceEvent;
        [FieldOffset(1224)]
        public IntPtr LazyWriteScanThreadHandle;
        [FieldOffset(1232)]
        public _CC_LWS_PACKET LWSPacket;
        [FieldOffset(1248)]
        public _LIST_ENTRY ExternalCacheList;
        [FieldOffset(1264)]
        public _LIST_ENTRY EnhancedExternalCacheList;
        [FieldOffset(1280)]
        public uint ThroughputIdx;
        [FieldOffset(1288)]
        public ulong AvgPagesPerSecond;
        [FieldOffset(1296)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ulong[] ThroughputHistory;
        [FieldOffset(1552)]
        public uint DirtyThresholdInSeconds;
        [FieldOffset(1556)]
        public uint DirtyPageTargetInSeconds;
        [FieldOffset(1560)]
        public _LIST_ENTRY QuickLWSThreadList;
        [FieldOffset(1576)]
        public _KEVENT QuickLazyScanEvent;
        [FieldOffset(1600)]
        public _LARGE_INTEGER PrevLazyWriteScanTime;
        [FieldOffset(1608)]
        public uint AsyncLazywriteQueueDepth;
        [FieldOffset(1612)]
        public uint MaxAsyncLazywriteCompletionWorkers;
        [FieldOffset(1616)]
        public uint Flags;
        [FieldOffset(1624)]
        public _LARGE_INTEGER DelayedDelTimestamp;
    }
}