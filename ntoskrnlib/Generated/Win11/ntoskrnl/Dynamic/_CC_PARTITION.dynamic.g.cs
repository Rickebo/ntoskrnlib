using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CC_PARTITION")]
    public sealed class _CC_PARTITION : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public short NodeByteSize { get; }
        public IntPtr PartitionObject { get; }
        public _LIST_ENTRY NumaNodeList { get; }
        public _LIST_ENTRY VolumeList { get; }
        public uint VolumeCount { get; }
        public _KEVENT LastVolumeEvent { get; }
        public _LIST_ENTRY DeletedVolumeList { get; }
        public _LIST_ENTRY DeletePVCMWorkerThreadList { get; }
        public _LIST_ENTRY DelayDeleteVolumeList { get; }
        public byte[] NumaNodeBlock { get; }
        public _LIST_ENTRY CleanSharedCacheMapList { get; }
        public _LIST_ENTRY CleanSharedCacheMapWithLogHandleList { get; }
        public _SHARED_CACHE_MAP_LIST_CURSOR DirtySharedCacheMapList { get; }
        public _SHARED_CACHE_MAP_LIST_CURSOR LazyWriteCursor { get; }
        public _LIST_ENTRY DirtySharedCacheMapWithLogHandleList { get; }
        public ulong PrivateLock { get; }
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
        public _LIST_ENTRY VacbFreeHighPriorityList { get; }
        public uint NumberOfFreeHighPriorityVacbs { get; }
        public IntPtr LowPriWorkerThread { get; }
        public IntPtr LowPriSharedCacheMap { get; }
        public int LowPriOldCpuPriority { get; }
        public uint LowPriOldIoPriority { get; }
        public _EX_PUSH_LOCK LowPriorityWorkerThreadLock { get; }
        public uint MaxNumberOfWriteBehindThreads { get; }
        public byte CoalescingState { get; }
        public byte ActivePartition { get; }
        public byte RundownPhase { get; }
        public long RefCount { get; }
        public _KEVENT ExitEvent { get; }
        public _KEVENT FinalDereferenceEvent { get; }
        public IntPtr LazyWriteScanThreadHandle { get; }
        public _CC_LWS_PACKET LWSPacket { get; }
        public _KTIMER PVCMDelayedDeleteTimer { get; }
        public _KDPC PVCMDelayedDeleteTimerDpc { get; }
        public byte PVCMDelayedDeleteTimerArmed { get; }
        public _WORK_QUEUE_ITEM PVCMDelayedDeleteWorkItem { get; }

        public _CC_PARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CC_PARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CC_PARTITION.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CC_PARTITION.NodeByteSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PartitionObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CC_PARTITION.NumaNodeList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CC_PARTITION.VolumeList),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CC_PARTITION.VolumeCount),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LastVolumeEvent),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DeletedVolumeList),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DeletePVCMWorkerThreadList),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DelayDeleteVolumeList),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CC_PARTITION.NumaNodeBlock),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_CC_PARTITION.CleanSharedCacheMapList),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_CC_PARTITION.CleanSharedCacheMapWithLogHandleList),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DirtySharedCacheMapList),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LazyWriteCursor),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DirtySharedCacheMapWithLogHandleList),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PrivateLock),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_CC_PARTITION.ConsecutiveWorklessLazyScanCount),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_CC_PARTITION.ForcedDisableLazywriteScan),
                    new ulong[]
                    {
                        780UL
                    }
                },
                {
                    nameof(_CC_PARTITION.WorkQueueLock),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(_CC_PARTITION.NumberWorkerThreads),
                    new ulong[]
                    {
                        840UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PostTickWorkQueue),
                    new ulong[]
                    {
                        848UL
                    }
                },
                {
                    nameof(_CC_PARTITION.MaxExtraWriteBehindThreads),
                    new ulong[]
                    {
                        864UL
                    }
                },
                {
                    nameof(_CC_PARTITION.MaxCacheMapUninitThreads),
                    new ulong[]
                    {
                        868UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PostTickWorkItemCount),
                    new ulong[]
                    {
                        872UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LowMemoryEvent),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PowerEvent),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(_CC_PARTITION.WaitingForTeardownEvent),
                    new ulong[]
                    {
                        928UL
                    }
                },
                {
                    nameof(_CC_PARTITION.CoalescingFlushEvent),
                    new ulong[]
                    {
                        952UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PagesYetToWrite),
                    new ulong[]
                    {
                        976UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LazyWriter),
                    new ulong[]
                    {
                        984UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DirtyPageStatistics),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DirtyPageThresholds),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(_CC_PARTITION.ThroughputStats),
                    new ulong[]
                    {
                        1136UL
                    }
                },
                {
                    nameof(_CC_PARTITION.AverageAvailablePages),
                    new ulong[]
                    {
                        1144UL
                    }
                },
                {
                    nameof(_CC_PARTITION.AverageDirtyPages),
                    new ulong[]
                    {
                        1152UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PagesSkippedDueToHotSpot),
                    new ulong[]
                    {
                        1160UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DeferredWrites),
                    new ulong[]
                    {
                        1168UL
                    }
                },
                {
                    nameof(_CC_PARTITION.DeferredWriteSpinLock),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(_CC_PARTITION.AsyncReadWorkQueueLock),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(_CC_PARTITION.VacbFreeHighPriorityList),
                    new ulong[]
                    {
                        1232UL
                    }
                },
                {
                    nameof(_CC_PARTITION.NumberOfFreeHighPriorityVacbs),
                    new ulong[]
                    {
                        1248UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LowPriWorkerThread),
                    new ulong[]
                    {
                        1256UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LowPriSharedCacheMap),
                    new ulong[]
                    {
                        1264UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LowPriOldCpuPriority),
                    new ulong[]
                    {
                        1272UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LowPriOldIoPriority),
                    new ulong[]
                    {
                        1276UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LowPriorityWorkerThreadLock),
                    new ulong[]
                    {
                        1280UL
                    }
                },
                {
                    nameof(_CC_PARTITION.MaxNumberOfWriteBehindThreads),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(_CC_PARTITION.CoalescingState),
                    new ulong[]
                    {
                        1292UL
                    }
                },
                {
                    nameof(_CC_PARTITION.ActivePartition),
                    new ulong[]
                    {
                        1293UL
                    }
                },
                {
                    nameof(_CC_PARTITION.RundownPhase),
                    new ulong[]
                    {
                        1294UL
                    }
                },
                {
                    nameof(_CC_PARTITION.RefCount),
                    new ulong[]
                    {
                        1296UL
                    }
                },
                {
                    nameof(_CC_PARTITION.ExitEvent),
                    new ulong[]
                    {
                        1304UL
                    }
                },
                {
                    nameof(_CC_PARTITION.FinalDereferenceEvent),
                    new ulong[]
                    {
                        1328UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LazyWriteScanThreadHandle),
                    new ulong[]
                    {
                        1352UL
                    }
                },
                {
                    nameof(_CC_PARTITION.LWSPacket),
                    new ulong[]
                    {
                        1360UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PVCMDelayedDeleteTimer),
                    new ulong[]
                    {
                        1376UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PVCMDelayedDeleteTimerDpc),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PVCMDelayedDeleteTimerArmed),
                    new ulong[]
                    {
                        1504UL
                    }
                },
                {
                    nameof(_CC_PARTITION.PVCMDelayedDeleteWorkItem),
                    new ulong[]
                    {
                        1512UL
                    }
                }
            };
            Register<_CC_PARTITION>((mem, ptr) => new _CC_PARTITION(mem, ptr), offsets);
        }
    }
}