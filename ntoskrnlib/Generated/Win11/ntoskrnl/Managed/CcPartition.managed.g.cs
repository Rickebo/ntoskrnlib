using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CC_PARTITION")]
    public sealed class CcPartition : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public short NodeByteSize { get => ReadHere<short>(nameof(NodeByteSize)); set => WriteHere(nameof(NodeByteSize), value); }

        [Offset(8UL)]
        public IntPtr PartitionObject { get => ReadHere<IntPtr>(nameof(PartitionObject)); set => WriteHere(nameof(PartitionObject), value); }

        [Offset(16UL)]
        public ListEntry NumaNodeList { get => ReadStructure<ListEntry>(nameof(NumaNodeList)); set => WriteStructure(nameof(NumaNodeList), value); }

        [Offset(32UL)]
        public ListEntry VolumeList { get => ReadStructure<ListEntry>(nameof(VolumeList)); set => WriteStructure(nameof(VolumeList), value); }

        [Offset(48UL)]
        public uint VolumeCount { get => ReadHere<uint>(nameof(VolumeCount)); set => WriteHere(nameof(VolumeCount), value); }

        [Offset(56UL)]
        public Kevent LastVolumeEvent { get => ReadStructure<Kevent>(nameof(LastVolumeEvent)); set => WriteStructure(nameof(LastVolumeEvent), value); }

        [Offset(80UL)]
        public ListEntry DeletedVolumeList { get => ReadStructure<ListEntry>(nameof(DeletedVolumeList)); set => WriteStructure(nameof(DeletedVolumeList), value); }

        [Offset(96UL)]
        public ListEntry DeletePVCMWorkerThreadList { get => ReadStructure<ListEntry>(nameof(DeletePVCMWorkerThreadList)); set => WriteStructure(nameof(DeletePVCMWorkerThreadList), value); }

        [Offset(112UL)]
        public ListEntry DelayDeleteVolumeList { get => ReadStructure<ListEntry>(nameof(DelayDeleteVolumeList)); set => WriteStructure(nameof(DelayDeleteVolumeList), value); }

        [Offset(128UL)]
        [Length(64)]
        public DynamicArray NumaNodeBlock { get => ReadStructure<DynamicArray>(nameof(NumaNodeBlock)); set => WriteStructure(nameof(NumaNodeBlock), value); }

        [Offset(640UL)]
        public ListEntry CleanSharedCacheMapList { get => ReadStructure<ListEntry>(nameof(CleanSharedCacheMapList)); set => WriteStructure(nameof(CleanSharedCacheMapList), value); }

        [Offset(656UL)]
        public ListEntry CleanSharedCacheMapWithLogHandleList { get => ReadStructure<ListEntry>(nameof(CleanSharedCacheMapWithLogHandleList)); set => WriteStructure(nameof(CleanSharedCacheMapWithLogHandleList), value); }

        [Offset(672UL)]
        public SharedCacheMapListCursor DirtySharedCacheMapList { get => ReadStructure<SharedCacheMapListCursor>(nameof(DirtySharedCacheMapList)); set => WriteStructure(nameof(DirtySharedCacheMapList), value); }

        [Offset(696UL)]
        public SharedCacheMapListCursor LazyWriteCursor { get => ReadStructure<SharedCacheMapListCursor>(nameof(LazyWriteCursor)); set => WriteStructure(nameof(LazyWriteCursor), value); }

        [Offset(720UL)]
        public ListEntry DirtySharedCacheMapWithLogHandleList { get => ReadStructure<ListEntry>(nameof(DirtySharedCacheMapWithLogHandleList)); set => WriteStructure(nameof(DirtySharedCacheMapWithLogHandleList), value); }

        [Offset(768UL)]
        public ulong PrivateLock { get => ReadHere<ulong>(nameof(PrivateLock)); set => WriteHere(nameof(PrivateLock), value); }

        [Offset(776UL)]
        public uint ConsecutiveWorklessLazyScanCount { get => ReadHere<uint>(nameof(ConsecutiveWorklessLazyScanCount)); set => WriteHere(nameof(ConsecutiveWorklessLazyScanCount), value); }

        [Offset(780UL)]
        public byte ForcedDisableLazywriteScan { get => ReadHere<byte>(nameof(ForcedDisableLazywriteScan)); set => WriteHere(nameof(ForcedDisableLazywriteScan), value); }

        [Offset(832UL)]
        public ulong WorkQueueLock { get => ReadHere<ulong>(nameof(WorkQueueLock)); set => WriteHere(nameof(WorkQueueLock), value); }

        [Offset(840UL)]
        public uint NumberWorkerThreads { get => ReadHere<uint>(nameof(NumberWorkerThreads)); set => WriteHere(nameof(NumberWorkerThreads), value); }

        [Offset(848UL)]
        public ListEntry PostTickWorkQueue { get => ReadStructure<ListEntry>(nameof(PostTickWorkQueue)); set => WriteStructure(nameof(PostTickWorkQueue), value); }

        [Offset(864UL)]
        public uint MaxExtraWriteBehindThreads { get => ReadHere<uint>(nameof(MaxExtraWriteBehindThreads)); set => WriteHere(nameof(MaxExtraWriteBehindThreads), value); }

        [Offset(868UL)]
        public uint MaxCacheMapUninitThreads { get => ReadHere<uint>(nameof(MaxCacheMapUninitThreads)); set => WriteHere(nameof(MaxCacheMapUninitThreads), value); }

        [Offset(872UL)]
        public uint PostTickWorkItemCount { get => ReadHere<uint>(nameof(PostTickWorkItemCount)); set => WriteHere(nameof(PostTickWorkItemCount), value); }

        [Offset(880UL)]
        public Kevent LowMemoryEvent { get => ReadStructure<Kevent>(nameof(LowMemoryEvent)); set => WriteStructure(nameof(LowMemoryEvent), value); }

        [Offset(904UL)]
        public Kevent PowerEvent { get => ReadStructure<Kevent>(nameof(PowerEvent)); set => WriteStructure(nameof(PowerEvent), value); }

        [Offset(928UL)]
        public Kevent WaitingForTeardownEvent { get => ReadStructure<Kevent>(nameof(WaitingForTeardownEvent)); set => WriteStructure(nameof(WaitingForTeardownEvent), value); }

        [Offset(952UL)]
        public Kevent CoalescingFlushEvent { get => ReadStructure<Kevent>(nameof(CoalescingFlushEvent)); set => WriteStructure(nameof(CoalescingFlushEvent), value); }

        [Offset(976UL)]
        public uint PagesYetToWrite { get => ReadHere<uint>(nameof(PagesYetToWrite)); set => WriteHere(nameof(PagesYetToWrite), value); }

        [Offset(984UL)]
        public LazyWriter LazyWriter { get => ReadStructure<LazyWriter>(nameof(LazyWriter)); set => WriteStructure(nameof(LazyWriter), value); }

        [Offset(1056UL)]
        public DirtyPageStatistics DirtyPageStatistics { get => ReadStructure<DirtyPageStatistics>(nameof(DirtyPageStatistics)); set => WriteStructure(nameof(DirtyPageStatistics), value); }

        [Offset(1080UL)]
        public DirtyPageThresholds DirtyPageThresholds { get => ReadStructure<DirtyPageThresholds>(nameof(DirtyPageThresholds)); set => WriteStructure(nameof(DirtyPageThresholds), value); }

        [Offset(1136UL)]
        public IntPtr ThroughputStats { get => ReadHere<IntPtr>(nameof(ThroughputStats)); set => WriteHere(nameof(ThroughputStats), value); }

        [Offset(1144UL)]
        public ulong AverageAvailablePages { get => ReadHere<ulong>(nameof(AverageAvailablePages)); set => WriteHere(nameof(AverageAvailablePages), value); }

        [Offset(1152UL)]
        public ulong AverageDirtyPages { get => ReadHere<ulong>(nameof(AverageDirtyPages)); set => WriteHere(nameof(AverageDirtyPages), value); }

        [Offset(1160UL)]
        public ulong PagesSkippedDueToHotSpot { get => ReadHere<ulong>(nameof(PagesSkippedDueToHotSpot)); set => WriteHere(nameof(PagesSkippedDueToHotSpot), value); }

        [Offset(1168UL)]
        public ListEntry DeferredWrites { get => ReadStructure<ListEntry>(nameof(DeferredWrites)); set => WriteStructure(nameof(DeferredWrites), value); }

        [Offset(1216UL)]
        public ulong DeferredWriteSpinLock { get => ReadHere<ulong>(nameof(DeferredWriteSpinLock)); set => WriteHere(nameof(DeferredWriteSpinLock), value); }

        [Offset(1224UL)]
        public ExPushLock AsyncReadWorkQueueLock { get => ReadStructure<ExPushLock>(nameof(AsyncReadWorkQueueLock)); set => WriteStructure(nameof(AsyncReadWorkQueueLock), value); }

        [Offset(1232UL)]
        public ListEntry VacbFreeHighPriorityList { get => ReadStructure<ListEntry>(nameof(VacbFreeHighPriorityList)); set => WriteStructure(nameof(VacbFreeHighPriorityList), value); }

        [Offset(1248UL)]
        public uint NumberOfFreeHighPriorityVacbs { get => ReadHere<uint>(nameof(NumberOfFreeHighPriorityVacbs)); set => WriteHere(nameof(NumberOfFreeHighPriorityVacbs), value); }

        [Offset(1256UL)]
        public IntPtr LowPriWorkerThread { get => ReadHere<IntPtr>(nameof(LowPriWorkerThread)); set => WriteHere(nameof(LowPriWorkerThread), value); }

        [Offset(1264UL)]
        public IntPtr LowPriSharedCacheMap { get => ReadHere<IntPtr>(nameof(LowPriSharedCacheMap)); set => WriteHere(nameof(LowPriSharedCacheMap), value); }

        [Offset(1272UL)]
        public int LowPriOldCpuPriority { get => ReadHere<int>(nameof(LowPriOldCpuPriority)); set => WriteHere(nameof(LowPriOldCpuPriority), value); }

        [Offset(1276UL)]
        public uint LowPriOldIoPriority { get => ReadHere<uint>(nameof(LowPriOldIoPriority)); set => WriteHere(nameof(LowPriOldIoPriority), value); }

        [Offset(1280UL)]
        public ExPushLock LowPriorityWorkerThreadLock { get => ReadStructure<ExPushLock>(nameof(LowPriorityWorkerThreadLock)); set => WriteStructure(nameof(LowPriorityWorkerThreadLock), value); }

        [Offset(1288UL)]
        public uint MaxNumberOfWriteBehindThreads { get => ReadHere<uint>(nameof(MaxNumberOfWriteBehindThreads)); set => WriteHere(nameof(MaxNumberOfWriteBehindThreads), value); }

        [Offset(1292UL)]
        public byte CoalescingState { get => ReadHere<byte>(nameof(CoalescingState)); set => WriteHere(nameof(CoalescingState), value); }

        [Offset(1293UL)]
        public byte ActivePartition { get => ReadHere<byte>(nameof(ActivePartition)); set => WriteHere(nameof(ActivePartition), value); }

        [Offset(1294UL)]
        public byte RundownPhase { get => ReadHere<byte>(nameof(RundownPhase)); set => WriteHere(nameof(RundownPhase), value); }

        [Offset(1296UL)]
        public long RefCount { get => ReadHere<long>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(1304UL)]
        public Kevent ExitEvent { get => ReadStructure<Kevent>(nameof(ExitEvent)); set => WriteStructure(nameof(ExitEvent), value); }

        [Offset(1328UL)]
        public Kevent FinalDereferenceEvent { get => ReadStructure<Kevent>(nameof(FinalDereferenceEvent)); set => WriteStructure(nameof(FinalDereferenceEvent), value); }

        [Offset(1352UL)]
        public IntPtr LazyWriteScanThreadHandle { get => ReadHere<IntPtr>(nameof(LazyWriteScanThreadHandle)); set => WriteHere(nameof(LazyWriteScanThreadHandle), value); }

        [Offset(1360UL)]
        public CcLwsPacket LWSPacket { get => ReadStructure<CcLwsPacket>(nameof(LWSPacket)); set => WriteStructure(nameof(LWSPacket), value); }

        [Offset(1376UL)]
        public Ktimer PVCMDelayedDeleteTimer { get => ReadStructure<Ktimer>(nameof(PVCMDelayedDeleteTimer)); set => WriteStructure(nameof(PVCMDelayedDeleteTimer), value); }

        [Offset(1440UL)]
        public Kdpc PVCMDelayedDeleteTimerDpc { get => ReadStructure<Kdpc>(nameof(PVCMDelayedDeleteTimerDpc)); set => WriteStructure(nameof(PVCMDelayedDeleteTimerDpc), value); }

        [Offset(1504UL)]
        public byte PVCMDelayedDeleteTimerArmed { get => ReadHere<byte>(nameof(PVCMDelayedDeleteTimerArmed)); set => WriteHere(nameof(PVCMDelayedDeleteTimerArmed), value); }

        [Offset(1512UL)]
        public WorkQueueItem PVCMDelayedDeleteWorkItem { get => ReadStructure<WorkQueueItem>(nameof(PVCMDelayedDeleteWorkItem)); set => WriteStructure(nameof(PVCMDelayedDeleteWorkItem), value); }

        public CcPartition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CcPartition>();
        }
    }
}