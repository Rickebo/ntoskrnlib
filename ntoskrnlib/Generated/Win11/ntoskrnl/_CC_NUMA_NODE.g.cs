#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 400)]
    public partial struct _CC_NUMA_NODE
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeByteSize;
        [FieldOffset(4)]
        public uint NumaNodeType;
        [FieldOffset(8)]
        public IntPtr Partition;
        [FieldOffset(16)]
        public IntPtr PrivateVolumeCacheMap;
        [FieldOffset(24)]
        public uint NodeNumber;
        [FieldOffset(32)]
        public _LIST_ENTRY NodeList;
        [FieldOffset(48)]
        public uint NumberActiveWorkerThreads;
        [FieldOffset(56)]
        public _LIST_ENTRY IdleWorkerThreadList;
        [FieldOffset(72)]
        public _LIST_ENTRY FastTeardownWorkQueue;
        [FieldOffset(88)]
        public _LIST_ENTRY ExpressWorkQueue;
        [FieldOffset(104)]
        public _LIST_ENTRY RegularWorkQueue;
        [FieldOffset(120)]
        public _LIST_ENTRY CleanCachemapUninitWorkQueue;
        [FieldOffset(136)]
        public _LIST_ENTRY IdleExtraWriteBehindThreadList;
        [FieldOffset(152)]
        public uint ActiveExtraWriteBehindThreads;
        [FieldOffset(160)]
        public _LIST_ENTRY IdleCacheMapUninitThreadList;
        [FieldOffset(176)]
        public uint ActiveCacheMapUninitThreads;
        [FieldOffset(180)]
        public uint ThreadsActiveBeforeThrottle;
        [FieldOffset(184)]
        public uint ExtraWBThreadsActiveBeforeThrottle;
        [FieldOffset(188)]
        public uint ExecutingWriteBehindWorkItems;
        [FieldOffset(192)]
        public uint ExecutingHighPriorityWorkItem;
        [FieldOffset(196)]
        public byte QueueThrottle;
        [FieldOffset(200)]
        public int ThroughputTrend;
        [FieldOffset(208)]
        public _LARGE_INTEGER PrevRegularQueueItemRunTime;
        [FieldOffset(216)]
        public _LARGE_INTEGER PrevExtraWBThreadCheckTime;
        [FieldOffset(224)]
        public byte AddExtraWriteBehindThreads;
        [FieldOffset(225)]
        public byte RemoveExtraThreadPending;
        [FieldOffset(232)]
        public IntPtr IdleAsyncReadWorkerThreadList;
        [FieldOffset(240)]
        public IntPtr NumberActiveAsyncReadWorkerThreads;
        [FieldOffset(248)]
        public IntPtr NumberActiveCompleteAsyncReadWorkItems;
        [FieldOffset(256)]
        public IntPtr AsyncReadWorkQueue;
        [FieldOffset(264)]
        public IntPtr AsyncReadCompletionWorkQueue;
        [FieldOffset(272)]
        public IntPtr NewAsyncReadRequestEvent;
        [FieldOffset(280)]
        public IntPtr ReaderThreadsStats;
        [FieldOffset(288)]
        public _LIST_ENTRY IdleAsyncLazywriteWorkerThreadList;
        [FieldOffset(304)]
        public uint NumberActiveAsyncLazywriteWorkerThreads;
        [FieldOffset(312)]
        public _LIST_ENTRY AsyncLazywriteWorkQueue;
        [FieldOffset(328)]
        public _KEVENT NewAsyncLazywriteRequestEvent;
        [FieldOffset(352)]
        public _ASYNC_LAZYWRITE_THREAD_STATS LazywriterThreadsStats;
        [FieldOffset(360)]
        public _LIST_ENTRY IdleCompleteAsyncLazywriteWorkerThreadList;
        [FieldOffset(376)]
        public uint NumberActiveCompleteAsyncLazywriteWorkers;
        [FieldOffset(384)]
        public _LIST_ENTRY AsyncLazywriteCompletionWorkQueue;
    }
}