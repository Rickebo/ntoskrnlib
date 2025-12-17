using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PRIVATE_VOLUME_CACHEMAP")]
    public sealed class PrivateVolumeCachemap : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public short NodeByteSize { get => ReadHere<short>(nameof(NodeByteSize)); set => WriteHere(nameof(NodeByteSize), value); }

        [Offset(4UL)]
        public uint UseCount { get => ReadHere<uint>(nameof(UseCount)); set => WriteHere(nameof(UseCount), value); }

        [Offset(8UL)]
        public long RefCount { get => ReadHere<long>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(16UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(24UL)]
        public uint VolumeId { get => ReadHere<uint>(nameof(VolumeId)); set => WriteHere(nameof(VolumeId), value); }

        [Offset(32UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(40UL)]
        public IntPtr VolumeCacheMap { get => ReadHere<IntPtr>(nameof(VolumeCacheMap)); set => WriteHere(nameof(VolumeCacheMap), value); }

        [Offset(48UL)]
        public ListEntry NumaNodeList { get => ReadStructure<ListEntry>(nameof(NumaNodeList)); set => WriteStructure(nameof(NumaNodeList), value); }

        [Offset(64UL)]
        [Length(64)]
        public DynamicArray NumaNodeBlock { get => ReadStructure<DynamicArray>(nameof(NumaNodeBlock)); set => WriteStructure(nameof(NumaNodeBlock), value); }

        [Offset(576UL)]
        public ListEntry PartitionVolumeLinks { get => ReadStructure<ListEntry>(nameof(PartitionVolumeLinks)); set => WriteStructure(nameof(PartitionVolumeLinks), value); }

        [Offset(592UL)]
        public ListEntry VolumeCacheMapLinks { get => ReadStructure<ListEntry>(nameof(VolumeCacheMapLinks)); set => WriteStructure(nameof(VolumeCacheMapLinks), value); }

        [Offset(608UL)]
        public ListEntry CleanSharedCacheMapList { get => ReadStructure<ListEntry>(nameof(CleanSharedCacheMapList)); set => WriteStructure(nameof(CleanSharedCacheMapList), value); }

        [Offset(624UL)]
        public ListEntry CleanSharedCacheMapWithLogHandleList { get => ReadStructure<ListEntry>(nameof(CleanSharedCacheMapWithLogHandleList)); set => WriteStructure(nameof(CleanSharedCacheMapWithLogHandleList), value); }

        [Offset(640UL)]
        public SharedCacheMapListCursor DirtySharedCacheMapList { get => ReadStructure<SharedCacheMapListCursor>(nameof(DirtySharedCacheMapList)); set => WriteStructure(nameof(DirtySharedCacheMapList), value); }

        [Offset(664UL)]
        public SharedCacheMapListCursor LazyWriteCursor { get => ReadStructure<SharedCacheMapListCursor>(nameof(LazyWriteCursor)); set => WriteStructure(nameof(LazyWriteCursor), value); }

        [Offset(688UL)]
        public ListEntry DirtySharedCacheMapWithLogHandleList { get => ReadStructure<ListEntry>(nameof(DirtySharedCacheMapWithLogHandleList)); set => WriteStructure(nameof(DirtySharedCacheMapWithLogHandleList), value); }

        [Offset(704UL)]
        public uint ConsecutiveWorklessLazyScanCount { get => ReadHere<uint>(nameof(ConsecutiveWorklessLazyScanCount)); set => WriteHere(nameof(ConsecutiveWorklessLazyScanCount), value); }

        [Offset(708UL)]
        public byte ForcedDisableLazywriteScan { get => ReadHere<byte>(nameof(ForcedDisableLazywriteScan)); set => WriteHere(nameof(ForcedDisableLazywriteScan), value); }

        [Offset(768UL)]
        public ulong WorkQueueLock { get => ReadHere<ulong>(nameof(WorkQueueLock)); set => WriteHere(nameof(WorkQueueLock), value); }

        [Offset(776UL)]
        public uint NumberWorkerThreads { get => ReadHere<uint>(nameof(NumberWorkerThreads)); set => WriteHere(nameof(NumberWorkerThreads), value); }

        [Offset(784UL)]
        public ListEntry PostTickWorkQueue { get => ReadStructure<ListEntry>(nameof(PostTickWorkQueue)); set => WriteStructure(nameof(PostTickWorkQueue), value); }

        [Offset(800UL)]
        public uint MaxExtraWriteBehindThreads { get => ReadHere<uint>(nameof(MaxExtraWriteBehindThreads)); set => WriteHere(nameof(MaxExtraWriteBehindThreads), value); }

        [Offset(804UL)]
        public uint MaxCacheMapUninitThreads { get => ReadHere<uint>(nameof(MaxCacheMapUninitThreads)); set => WriteHere(nameof(MaxCacheMapUninitThreads), value); }

        [Offset(808UL)]
        public uint PostTickWorkItemCount { get => ReadHere<uint>(nameof(PostTickWorkItemCount)); set => WriteHere(nameof(PostTickWorkItemCount), value); }

        [Offset(816UL)]
        public Kevent LowMemoryEvent { get => ReadStructure<Kevent>(nameof(LowMemoryEvent)); set => WriteStructure(nameof(LowMemoryEvent), value); }

        [Offset(840UL)]
        public Kevent PowerEvent { get => ReadStructure<Kevent>(nameof(PowerEvent)); set => WriteStructure(nameof(PowerEvent), value); }

        [Offset(864UL)]
        public Kevent WaitingForTeardownEvent { get => ReadStructure<Kevent>(nameof(WaitingForTeardownEvent)); set => WriteStructure(nameof(WaitingForTeardownEvent), value); }

        [Offset(888UL)]
        public Kevent CoalescingFlushEvent { get => ReadStructure<Kevent>(nameof(CoalescingFlushEvent)); set => WriteStructure(nameof(CoalescingFlushEvent), value); }

        [Offset(912UL)]
        public uint PagesYetToWrite { get => ReadHere<uint>(nameof(PagesYetToWrite)); set => WriteHere(nameof(PagesYetToWrite), value); }

        [Offset(920UL)]
        public LazyWriter LazyWriter { get => ReadStructure<LazyWriter>(nameof(LazyWriter)); set => WriteStructure(nameof(LazyWriter), value); }

        [Offset(992UL)]
        public DirtyPageStatistics DirtyPageStatistics { get => ReadStructure<DirtyPageStatistics>(nameof(DirtyPageStatistics)); set => WriteStructure(nameof(DirtyPageStatistics), value); }

        [Offset(1016UL)]
        public DirtyPageThresholds DirtyPageThresholds { get => ReadStructure<DirtyPageThresholds>(nameof(DirtyPageThresholds)); set => WriteStructure(nameof(DirtyPageThresholds), value); }

        [Offset(1072UL)]
        public IntPtr ThroughputStats { get => ReadHere<IntPtr>(nameof(ThroughputStats)); set => WriteHere(nameof(ThroughputStats), value); }

        [Offset(1080UL)]
        public ulong AverageAvailablePages { get => ReadHere<ulong>(nameof(AverageAvailablePages)); set => WriteHere(nameof(AverageAvailablePages), value); }

        [Offset(1088UL)]
        public ulong AverageDirtyPages { get => ReadHere<ulong>(nameof(AverageDirtyPages)); set => WriteHere(nameof(AverageDirtyPages), value); }

        [Offset(1096UL)]
        public ulong PagesSkippedDueToHotSpot { get => ReadHere<ulong>(nameof(PagesSkippedDueToHotSpot)); set => WriteHere(nameof(PagesSkippedDueToHotSpot), value); }

        [Offset(1104UL)]
        public ListEntry DeferredWrites { get => ReadStructure<ListEntry>(nameof(DeferredWrites)); set => WriteStructure(nameof(DeferredWrites), value); }

        [Offset(1152UL)]
        public ulong DeferredWriteSpinLock { get => ReadHere<ulong>(nameof(DeferredWriteSpinLock)); set => WriteHere(nameof(DeferredWriteSpinLock), value); }

        [Offset(1160UL)]
        public ExPushLock AsyncReadWorkQueueLock { get => ReadStructure<ExPushLock>(nameof(AsyncReadWorkQueueLock)); set => WriteStructure(nameof(AsyncReadWorkQueueLock), value); }

        [Offset(1168UL)]
        public uint MaxNumberOfWriteBehindThreads { get => ReadHere<uint>(nameof(MaxNumberOfWriteBehindThreads)); set => WriteHere(nameof(MaxNumberOfWriteBehindThreads), value); }

        [Offset(1172UL)]
        public byte CoalescingState { get => ReadHere<byte>(nameof(CoalescingState)); set => WriteHere(nameof(CoalescingState), value); }

        [Offset(1173UL)]
        public byte InitComplete { get => ReadHere<byte>(nameof(InitComplete)); set => WriteHere(nameof(InitComplete), value); }

        [Offset(1176UL)]
        public Kevent ExitEvent { get => ReadStructure<Kevent>(nameof(ExitEvent)); set => WriteStructure(nameof(ExitEvent), value); }

        [Offset(1200UL)]
        public Kevent FinalDereferenceEvent { get => ReadStructure<Kevent>(nameof(FinalDereferenceEvent)); set => WriteStructure(nameof(FinalDereferenceEvent), value); }

        [Offset(1224UL)]
        public IntPtr LazyWriteScanThreadHandle { get => ReadHere<IntPtr>(nameof(LazyWriteScanThreadHandle)); set => WriteHere(nameof(LazyWriteScanThreadHandle), value); }

        [Offset(1232UL)]
        public CcLwsPacket LWSPacket { get => ReadStructure<CcLwsPacket>(nameof(LWSPacket)); set => WriteStructure(nameof(LWSPacket), value); }

        [Offset(1248UL)]
        public ListEntry ExternalCacheList { get => ReadStructure<ListEntry>(nameof(ExternalCacheList)); set => WriteStructure(nameof(ExternalCacheList), value); }

        [Offset(1264UL)]
        public ListEntry EnhancedExternalCacheList { get => ReadStructure<ListEntry>(nameof(EnhancedExternalCacheList)); set => WriteStructure(nameof(EnhancedExternalCacheList), value); }

        [Offset(1280UL)]
        public uint ThroughputIdx { get => ReadHere<uint>(nameof(ThroughputIdx)); set => WriteHere(nameof(ThroughputIdx), value); }

        [Offset(1288UL)]
        public ulong AvgPagesPerSecond { get => ReadHere<ulong>(nameof(AvgPagesPerSecond)); set => WriteHere(nameof(AvgPagesPerSecond), value); }

        [Offset(1296UL)]
        [Length(32)]
        public DynamicArray ThroughputHistory { get => ReadStructure<DynamicArray>(nameof(ThroughputHistory)); set => WriteStructure(nameof(ThroughputHistory), value); }

        [Offset(1552UL)]
        public uint DirtyThresholdInSeconds { get => ReadHere<uint>(nameof(DirtyThresholdInSeconds)); set => WriteHere(nameof(DirtyThresholdInSeconds), value); }

        [Offset(1556UL)]
        public uint DirtyPageTargetInSeconds { get => ReadHere<uint>(nameof(DirtyPageTargetInSeconds)); set => WriteHere(nameof(DirtyPageTargetInSeconds), value); }

        [Offset(1560UL)]
        public ListEntry QuickLWSThreadList { get => ReadStructure<ListEntry>(nameof(QuickLWSThreadList)); set => WriteStructure(nameof(QuickLWSThreadList), value); }

        [Offset(1576UL)]
        public Kevent QuickLazyScanEvent { get => ReadStructure<Kevent>(nameof(QuickLazyScanEvent)); set => WriteStructure(nameof(QuickLazyScanEvent), value); }

        [Offset(1600UL)]
        public LargeInteger PrevLazyWriteScanTime { get => ReadStructure<LargeInteger>(nameof(PrevLazyWriteScanTime)); set => WriteStructure(nameof(PrevLazyWriteScanTime), value); }

        [Offset(1608UL)]
        public uint AsyncLazywriteQueueDepth { get => ReadHere<uint>(nameof(AsyncLazywriteQueueDepth)); set => WriteHere(nameof(AsyncLazywriteQueueDepth), value); }

        [Offset(1612UL)]
        public uint MaxAsyncLazywriteCompletionWorkers { get => ReadHere<uint>(nameof(MaxAsyncLazywriteCompletionWorkers)); set => WriteHere(nameof(MaxAsyncLazywriteCompletionWorkers), value); }

        [Offset(1616UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(1624UL)]
        public LargeInteger DelayedDelTimestamp { get => ReadStructure<LargeInteger>(nameof(DelayedDelTimestamp)); set => WriteStructure(nameof(DelayedDelTimestamp), value); }

        public PrivateVolumeCachemap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PrivateVolumeCachemap>();
        }
    }
}