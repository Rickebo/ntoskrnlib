using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PRIVATE_VOLUME_CACHEMAP")]
    public sealed class _PRIVATE_VOLUME_CACHEMAP : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public short NodeByteSize { get; }
        public uint UseCount { get; }
        public long RefCount { get; }
        public IntPtr DeviceObject { get; }
        public uint VolumeId { get; }
        public IntPtr Partition { get; }
        public IntPtr VolumeCacheMap { get; }
        public _LIST_ENTRY NumaNodeList { get; }
        public byte[] NumaNodeBlock { get; }
        public _LIST_ENTRY PartitionVolumeLinks { get; }
        public _LIST_ENTRY VolumeCacheMapLinks { get; }
        public _LIST_ENTRY CleanSharedCacheMapList { get; }
        public _LIST_ENTRY CleanSharedCacheMapWithLogHandleList { get; }
        public _SHARED_CACHE_MAP_LIST_CURSOR DirtySharedCacheMapList { get; }
        public _SHARED_CACHE_MAP_LIST_CURSOR LazyWriteCursor { get; }
        public _LIST_ENTRY DirtySharedCacheMapWithLogHandleList { get; }
        public uint ConsecutiveWorklessLazyScanCount { get; }
        public byte ForcedDisableLazywriteScan { get; }
        public ulong WorkQueueLock { get; }
        public uint NumberWorkerThreads { get; }
        public _LIST_ENTRY PostTickWorkQueue { get; }
        public uint MaxExtraWriteBehindThreads { get; }
        public uint MaxCacheMapUninitThreads { get; }
        public uint PostTickWorkItemCount { get; }
        public _KEVENT LowMemoryEvent { get; }
        public _KEVENT PowerEvent { get; }
        public _KEVENT WaitingForTeardownEvent { get; }
        public _KEVENT CoalescingFlushEvent { get; }
        public uint PagesYetToWrite { get; }
        public _LAZY_WRITER LazyWriter { get; }
        public _DIRTY_PAGE_STATISTICS DirtyPageStatistics { get; }
        public _DIRTY_PAGE_THRESHOLDS DirtyPageThresholds { get; }
        public IntPtr ThroughputStats { get; }
        public ulong AverageAvailablePages { get; }
        public ulong AverageDirtyPages { get; }
        public ulong PagesSkippedDueToHotSpot { get; }
        public _LIST_ENTRY DeferredWrites { get; }
        public ulong DeferredWriteSpinLock { get; }
        public _EX_PUSH_LOCK AsyncReadWorkQueueLock { get; }
        public uint MaxNumberOfWriteBehindThreads { get; }
        public byte CoalescingState { get; }
        public byte InitComplete { get; }
        public _KEVENT ExitEvent { get; }
        public _KEVENT FinalDereferenceEvent { get; }
        public IntPtr LazyWriteScanThreadHandle { get; }
        public _CC_LWS_PACKET LWSPacket { get; }
        public _LIST_ENTRY ExternalCacheList { get; }
        public _LIST_ENTRY EnhancedExternalCacheList { get; }
        public uint ThroughputIdx { get; }
        public ulong AvgPagesPerSecond { get; }
        public ulong[] ThroughputHistory { get; }
        public uint DirtyThresholdInSeconds { get; }
        public uint DirtyPageTargetInSeconds { get; }
        public _LIST_ENTRY QuickLWSThreadList { get; }
        public _KEVENT QuickLazyScanEvent { get; }
        public _LARGE_INTEGER PrevLazyWriteScanTime { get; }
        public uint AsyncLazywriteQueueDepth { get; }
        public uint MaxAsyncLazywriteCompletionWorkers { get; }
        public uint Flags { get; }
        public _LARGE_INTEGER DelayedDelTimestamp { get; }

        public _PRIVATE_VOLUME_CACHEMAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PRIVATE_VOLUME_CACHEMAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.NodeByteSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.UseCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.RefCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DeviceObject),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.VolumeId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.Partition),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.VolumeCacheMap),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.NumaNodeList),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.NumaNodeBlock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.PartitionVolumeLinks),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.VolumeCacheMapLinks),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.CleanSharedCacheMapList),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.CleanSharedCacheMapWithLogHandleList),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DirtySharedCacheMapList),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.LazyWriteCursor),
                    new ulong[]
                    {
                        664UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DirtySharedCacheMapWithLogHandleList),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.ConsecutiveWorklessLazyScanCount),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.ForcedDisableLazywriteScan),
                    new ulong[]
                    {
                        708UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.WorkQueueLock),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.NumberWorkerThreads),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.PostTickWorkQueue),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.MaxExtraWriteBehindThreads),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.MaxCacheMapUninitThreads),
                    new ulong[]
                    {
                        804UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.PostTickWorkItemCount),
                    new ulong[]
                    {
                        808UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.LowMemoryEvent),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.PowerEvent),
                    new ulong[]
                    {
                        840UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.WaitingForTeardownEvent),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.CoalescingFlushEvent),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.PagesYetToWrite),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.LazyWriter),
                    new ulong[]
                    {
                        920UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DirtyPageStatistics),
                    new ulong[]
                    {
                        992UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DirtyPageThresholds),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.ThroughputStats),
                    new ulong[]
                    {
                        1072UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.AverageAvailablePages),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.AverageDirtyPages),
                    new ulong[]
                    {
                        1088UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.PagesSkippedDueToHotSpot),
                    new ulong[]
                    {
                        1096UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DeferredWrites),
                    new ulong[]
                    {
                        1104UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DeferredWriteSpinLock),
                    new ulong[]
                    {
                        1152UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.AsyncReadWorkQueueLock),
                    new ulong[]
                    {
                        1160UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.MaxNumberOfWriteBehindThreads),
                    new ulong[]
                    {
                        1168UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.CoalescingState),
                    new ulong[]
                    {
                        1172UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.InitComplete),
                    new ulong[]
                    {
                        1173UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.ExitEvent),
                    new ulong[]
                    {
                        1176UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.FinalDereferenceEvent),
                    new ulong[]
                    {
                        1200UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.LazyWriteScanThreadHandle),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.LWSPacket),
                    new ulong[]
                    {
                        1232UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.ExternalCacheList),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.EnhancedExternalCacheList),
                    new ulong[]
                    {
                        1264UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.ThroughputIdx),
                    new ulong[]
                    {
                        1280UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.AvgPagesPerSecond),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.ThroughputHistory),
                    new ulong[]
                    {
                        1296UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DirtyThresholdInSeconds),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DirtyPageTargetInSeconds),
                    new ulong[]
                    {
                        1556UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.QuickLWSThreadList),
                    new ulong[]
                    {
                        1560UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.QuickLazyScanEvent),
                    new ulong[]
                    {
                        1576UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.PrevLazyWriteScanTime),
                    new ulong[]
                    {
                        1600UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.AsyncLazywriteQueueDepth),
                    new ulong[]
                    {
                        1608UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.MaxAsyncLazywriteCompletionWorkers),
                    new ulong[]
                    {
                        1612UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.Flags),
                    new ulong[]
                    {
                        1616UL
                    }
                },
                {
                    nameof(_PRIVATE_VOLUME_CACHEMAP.DelayedDelTimestamp),
                    new ulong[]
                    {
                        1624UL
                    }
                }
            };
            Register<_PRIVATE_VOLUME_CACHEMAP>((mem, ptr) => new _PRIVATE_VOLUME_CACHEMAP(mem, ptr), offsets);
        }
    }
}