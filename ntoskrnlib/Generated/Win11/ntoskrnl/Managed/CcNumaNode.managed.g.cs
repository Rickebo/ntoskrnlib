using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CC_NUMA_NODE")]
    public sealed class CcNumaNode : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public short NodeByteSize { get => ReadHere<short>(nameof(NodeByteSize)); set => WriteHere(nameof(NodeByteSize), value); }

        [Offset(4UL)]
        public uint NumaNodeType { get => ReadHere<uint>(nameof(NumaNodeType)); set => WriteHere(nameof(NumaNodeType), value); }

        [Offset(8UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(16UL)]
        public IntPtr PrivateVolumeCacheMap { get => ReadHere<IntPtr>(nameof(PrivateVolumeCacheMap)); set => WriteHere(nameof(PrivateVolumeCacheMap), value); }

        [Offset(24UL)]
        public uint NodeNumber { get => ReadHere<uint>(nameof(NodeNumber)); set => WriteHere(nameof(NodeNumber), value); }

        [Offset(32UL)]
        public ListEntry NodeList { get => ReadStructure<ListEntry>(nameof(NodeList)); set => WriteStructure(nameof(NodeList), value); }

        [Offset(48UL)]
        public uint NumberActiveWorkerThreads { get => ReadHere<uint>(nameof(NumberActiveWorkerThreads)); set => WriteHere(nameof(NumberActiveWorkerThreads), value); }

        [Offset(56UL)]
        public ListEntry IdleWorkerThreadList { get => ReadStructure<ListEntry>(nameof(IdleWorkerThreadList)); set => WriteStructure(nameof(IdleWorkerThreadList), value); }

        [Offset(72UL)]
        public ListEntry FastTeardownWorkQueue { get => ReadStructure<ListEntry>(nameof(FastTeardownWorkQueue)); set => WriteStructure(nameof(FastTeardownWorkQueue), value); }

        [Offset(88UL)]
        public ListEntry ExpressWorkQueue { get => ReadStructure<ListEntry>(nameof(ExpressWorkQueue)); set => WriteStructure(nameof(ExpressWorkQueue), value); }

        [Offset(104UL)]
        public ListEntry RegularWorkQueue { get => ReadStructure<ListEntry>(nameof(RegularWorkQueue)); set => WriteStructure(nameof(RegularWorkQueue), value); }

        [Offset(120UL)]
        public ListEntry CleanCachemapUninitWorkQueue { get => ReadStructure<ListEntry>(nameof(CleanCachemapUninitWorkQueue)); set => WriteStructure(nameof(CleanCachemapUninitWorkQueue), value); }

        [Offset(136UL)]
        public ListEntry IdleExtraWriteBehindThreadList { get => ReadStructure<ListEntry>(nameof(IdleExtraWriteBehindThreadList)); set => WriteStructure(nameof(IdleExtraWriteBehindThreadList), value); }

        [Offset(152UL)]
        public uint ActiveExtraWriteBehindThreads { get => ReadHere<uint>(nameof(ActiveExtraWriteBehindThreads)); set => WriteHere(nameof(ActiveExtraWriteBehindThreads), value); }

        [Offset(160UL)]
        public ListEntry IdleCacheMapUninitThreadList { get => ReadStructure<ListEntry>(nameof(IdleCacheMapUninitThreadList)); set => WriteStructure(nameof(IdleCacheMapUninitThreadList), value); }

        [Offset(176UL)]
        public uint ActiveCacheMapUninitThreads { get => ReadHere<uint>(nameof(ActiveCacheMapUninitThreads)); set => WriteHere(nameof(ActiveCacheMapUninitThreads), value); }

        [Offset(180UL)]
        public uint ThreadsActiveBeforeThrottle { get => ReadHere<uint>(nameof(ThreadsActiveBeforeThrottle)); set => WriteHere(nameof(ThreadsActiveBeforeThrottle), value); }

        [Offset(184UL)]
        public uint ExtraWBThreadsActiveBeforeThrottle { get => ReadHere<uint>(nameof(ExtraWBThreadsActiveBeforeThrottle)); set => WriteHere(nameof(ExtraWBThreadsActiveBeforeThrottle), value); }

        [Offset(188UL)]
        public uint ExecutingWriteBehindWorkItems { get => ReadHere<uint>(nameof(ExecutingWriteBehindWorkItems)); set => WriteHere(nameof(ExecutingWriteBehindWorkItems), value); }

        [Offset(192UL)]
        public uint ExecutingHighPriorityWorkItem { get => ReadHere<uint>(nameof(ExecutingHighPriorityWorkItem)); set => WriteHere(nameof(ExecutingHighPriorityWorkItem), value); }

        [Offset(196UL)]
        public byte QueueThrottle { get => ReadHere<byte>(nameof(QueueThrottle)); set => WriteHere(nameof(QueueThrottle), value); }

        [Offset(200UL)]
        public int ThroughputTrend { get => ReadHere<int>(nameof(ThroughputTrend)); set => WriteHere(nameof(ThroughputTrend), value); }

        [Offset(208UL)]
        public LargeInteger PrevRegularQueueItemRunTime { get => ReadStructure<LargeInteger>(nameof(PrevRegularQueueItemRunTime)); set => WriteStructure(nameof(PrevRegularQueueItemRunTime), value); }

        [Offset(216UL)]
        public LargeInteger PrevExtraWBThreadCheckTime { get => ReadStructure<LargeInteger>(nameof(PrevExtraWBThreadCheckTime)); set => WriteStructure(nameof(PrevExtraWBThreadCheckTime), value); }

        [Offset(224UL)]
        public byte AddExtraWriteBehindThreads { get => ReadHere<byte>(nameof(AddExtraWriteBehindThreads)); set => WriteHere(nameof(AddExtraWriteBehindThreads), value); }

        [Offset(225UL)]
        public byte RemoveExtraThreadPending { get => ReadHere<byte>(nameof(RemoveExtraThreadPending)); set => WriteHere(nameof(RemoveExtraThreadPending), value); }

        [Offset(232UL)]
        public IntPtr IdleAsyncReadWorkerThreadList { get => ReadHere<IntPtr>(nameof(IdleAsyncReadWorkerThreadList)); set => WriteHere(nameof(IdleAsyncReadWorkerThreadList), value); }

        [Offset(240UL)]
        public IntPtr NumberActiveAsyncReadWorkerThreads { get => ReadHere<IntPtr>(nameof(NumberActiveAsyncReadWorkerThreads)); set => WriteHere(nameof(NumberActiveAsyncReadWorkerThreads), value); }

        [Offset(248UL)]
        public IntPtr NumberActiveCompleteAsyncReadWorkItems { get => ReadHere<IntPtr>(nameof(NumberActiveCompleteAsyncReadWorkItems)); set => WriteHere(nameof(NumberActiveCompleteAsyncReadWorkItems), value); }

        [Offset(256UL)]
        public IntPtr AsyncReadWorkQueue { get => ReadHere<IntPtr>(nameof(AsyncReadWorkQueue)); set => WriteHere(nameof(AsyncReadWorkQueue), value); }

        [Offset(264UL)]
        public IntPtr AsyncReadCompletionWorkQueue { get => ReadHere<IntPtr>(nameof(AsyncReadCompletionWorkQueue)); set => WriteHere(nameof(AsyncReadCompletionWorkQueue), value); }

        [Offset(272UL)]
        public IntPtr NewAsyncReadRequestEvent { get => ReadHere<IntPtr>(nameof(NewAsyncReadRequestEvent)); set => WriteHere(nameof(NewAsyncReadRequestEvent), value); }

        [Offset(280UL)]
        public IntPtr ReaderThreadsStats { get => ReadHere<IntPtr>(nameof(ReaderThreadsStats)); set => WriteHere(nameof(ReaderThreadsStats), value); }

        [Offset(288UL)]
        public ListEntry IdleAsyncLazywriteWorkerThreadList { get => ReadStructure<ListEntry>(nameof(IdleAsyncLazywriteWorkerThreadList)); set => WriteStructure(nameof(IdleAsyncLazywriteWorkerThreadList), value); }

        [Offset(304UL)]
        public uint NumberActiveAsyncLazywriteWorkerThreads { get => ReadHere<uint>(nameof(NumberActiveAsyncLazywriteWorkerThreads)); set => WriteHere(nameof(NumberActiveAsyncLazywriteWorkerThreads), value); }

        [Offset(312UL)]
        public ListEntry AsyncLazywriteWorkQueue { get => ReadStructure<ListEntry>(nameof(AsyncLazywriteWorkQueue)); set => WriteStructure(nameof(AsyncLazywriteWorkQueue), value); }

        [Offset(328UL)]
        public Kevent NewAsyncLazywriteRequestEvent { get => ReadStructure<Kevent>(nameof(NewAsyncLazywriteRequestEvent)); set => WriteStructure(nameof(NewAsyncLazywriteRequestEvent), value); }

        [Offset(352UL)]
        public AsyncLazywriteThreadStats LazywriterThreadsStats { get => ReadStructure<AsyncLazywriteThreadStats>(nameof(LazywriterThreadsStats)); set => WriteStructure(nameof(LazywriterThreadsStats), value); }

        [Offset(360UL)]
        public ListEntry IdleCompleteAsyncLazywriteWorkerThreadList { get => ReadStructure<ListEntry>(nameof(IdleCompleteAsyncLazywriteWorkerThreadList)); set => WriteStructure(nameof(IdleCompleteAsyncLazywriteWorkerThreadList), value); }

        [Offset(376UL)]
        public uint NumberActiveCompleteAsyncLazywriteWorkers { get => ReadHere<uint>(nameof(NumberActiveCompleteAsyncLazywriteWorkers)); set => WriteHere(nameof(NumberActiveCompleteAsyncLazywriteWorkers), value); }

        [Offset(384UL)]
        public ListEntry AsyncLazywriteCompletionWorkQueue { get => ReadStructure<ListEntry>(nameof(AsyncLazywriteCompletionWorkQueue)); set => WriteStructure(nameof(AsyncLazywriteCompletionWorkQueue), value); }

        public CcNumaNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CcNumaNode>();
        }
    }
}