using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CC_NUMA_NODE")]
    public sealed class _CC_NUMA_NODE : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public short NodeByteSize { get; }
        public uint NumaNodeType { get; }
        public IntPtr Partition { get; }
        public IntPtr PrivateVolumeCacheMap { get; }
        public uint NodeNumber { get; }
        public _LIST_ENTRY NodeList { get; }
        public uint NumberActiveWorkerThreads { get; }
        public _LIST_ENTRY IdleWorkerThreadList { get; }
        public _LIST_ENTRY FastTeardownWorkQueue { get; }
        public _LIST_ENTRY ExpressWorkQueue { get; }
        public _LIST_ENTRY RegularWorkQueue { get; }
        public _LIST_ENTRY CleanCachemapUninitWorkQueue { get; }
        public _LIST_ENTRY IdleExtraWriteBehindThreadList { get; }
        public uint ActiveExtraWriteBehindThreads { get; }
        public _LIST_ENTRY IdleCacheMapUninitThreadList { get; }
        public uint ActiveCacheMapUninitThreads { get; }
        public uint ThreadsActiveBeforeThrottle { get; }
        public uint ExtraWBThreadsActiveBeforeThrottle { get; }
        public uint ExecutingWriteBehindWorkItems { get; }
        public uint ExecutingHighPriorityWorkItem { get; }
        public byte QueueThrottle { get; }
        public int ThroughputTrend { get; }
        public _LARGE_INTEGER PrevRegularQueueItemRunTime { get; }
        public _LARGE_INTEGER PrevExtraWBThreadCheckTime { get; }
        public byte AddExtraWriteBehindThreads { get; }
        public byte RemoveExtraThreadPending { get; }
        public IntPtr IdleAsyncReadWorkerThreadList { get; }
        public IntPtr NumberActiveAsyncReadWorkerThreads { get; }
        public IntPtr NumberActiveCompleteAsyncReadWorkItems { get; }
        public IntPtr AsyncReadWorkQueue { get; }
        public IntPtr AsyncReadCompletionWorkQueue { get; }
        public IntPtr NewAsyncReadRequestEvent { get; }
        public IntPtr ReaderThreadsStats { get; }
        public _LIST_ENTRY IdleAsyncLazywriteWorkerThreadList { get; }
        public uint NumberActiveAsyncLazywriteWorkerThreads { get; }
        public _LIST_ENTRY AsyncLazywriteWorkQueue { get; }
        public _KEVENT NewAsyncLazywriteRequestEvent { get; }
        public _ASYNC_LAZYWRITE_THREAD_STATS LazywriterThreadsStats { get; }
        public _LIST_ENTRY IdleCompleteAsyncLazywriteWorkerThreadList { get; }
        public uint NumberActiveCompleteAsyncLazywriteWorkers { get; }
        public _LIST_ENTRY AsyncLazywriteCompletionWorkQueue { get; }

        public _CC_NUMA_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CC_NUMA_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CC_NUMA_NODE.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NodeByteSize),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NumaNodeType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.Partition),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.PrivateVolumeCacheMap),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NodeNumber),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NodeList),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NumberActiveWorkerThreads),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.IdleWorkerThreadList),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.FastTeardownWorkQueue),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ExpressWorkQueue),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.RegularWorkQueue),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.CleanCachemapUninitWorkQueue),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.IdleExtraWriteBehindThreadList),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ActiveExtraWriteBehindThreads),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.IdleCacheMapUninitThreadList),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ActiveCacheMapUninitThreads),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ThreadsActiveBeforeThrottle),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ExtraWBThreadsActiveBeforeThrottle),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ExecutingWriteBehindWorkItems),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ExecutingHighPriorityWorkItem),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.QueueThrottle),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ThroughputTrend),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.PrevRegularQueueItemRunTime),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.PrevExtraWBThreadCheckTime),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.AddExtraWriteBehindThreads),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.RemoveExtraThreadPending),
                    new ulong[]
                    {
                        225UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.IdleAsyncReadWorkerThreadList),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NumberActiveAsyncReadWorkerThreads),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NumberActiveCompleteAsyncReadWorkItems),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.AsyncReadWorkQueue),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.AsyncReadCompletionWorkQueue),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NewAsyncReadRequestEvent),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.ReaderThreadsStats),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.IdleAsyncLazywriteWorkerThreadList),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NumberActiveAsyncLazywriteWorkerThreads),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.AsyncLazywriteWorkQueue),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NewAsyncLazywriteRequestEvent),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.LazywriterThreadsStats),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.IdleCompleteAsyncLazywriteWorkerThreadList),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.NumberActiveCompleteAsyncLazywriteWorkers),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_CC_NUMA_NODE.AsyncLazywriteCompletionWorkQueue),
                    new ulong[]
                    {
                        384UL
                    }
                }
            };
            Register<_CC_NUMA_NODE>((mem, ptr) => new _CC_NUMA_NODE(mem, ptr), offsets);
        }
    }
}