using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_SEGMENTS")]
    public sealed class MiPartitionSegments : DynamicStructure
    {
        [Offset(0UL)]
        public int SegmentListLock { get => ReadHere<int>(nameof(SegmentListLock)); set => WriteHere(nameof(SegmentListLock), value); }

        [Offset(4UL)]
        public uint DeleteOnCloseCount { get => ReadHere<uint>(nameof(DeleteOnCloseCount)); set => WriteHere(nameof(DeleteOnCloseCount), value); }

        [Offset(8UL)]
        public long FsControlAreaCount { get => ReadHere<long>(nameof(FsControlAreaCount)); set => WriteHere(nameof(FsControlAreaCount), value); }

        [Offset(16UL)]
        public long PfControlAreaCount { get => ReadHere<long>(nameof(PfControlAreaCount)); set => WriteHere(nameof(PfControlAreaCount), value); }

        [Offset(24UL)]
        public long CloneHeaderCount { get => ReadHere<long>(nameof(CloneHeaderCount)); set => WriteHere(nameof(CloneHeaderCount), value); }

        [Offset(32UL)]
        public Kevent DeleteSubsectionCleanup { get => ReadStructure<Kevent>(nameof(DeleteSubsectionCleanup)); set => WriteStructure(nameof(DeleteSubsectionCleanup), value); }

        [Offset(56UL)]
        public Kevent UnusedSegmentCleanup { get => ReadStructure<Kevent>(nameof(UnusedSegmentCleanup)); set => WriteStructure(nameof(UnusedSegmentCleanup), value); }

        [Offset(80UL)]
        public ulong SubsectionDeletePtes { get => ReadHere<ulong>(nameof(SubsectionDeletePtes)); set => WriteHere(nameof(SubsectionDeletePtes), value); }

        [Offset(88UL)]
        public MmpageFileExpansion AttemptForCantExtend { get => ReadStructure<MmpageFileExpansion>(nameof(AttemptForCantExtend)); set => WriteStructure(nameof(AttemptForCantExtend), value); }

        [Offset(176UL)]
        public MmdereferenceSegmentHeader DereferenceSegmentHeader { get => ReadStructure<MmdereferenceSegmentHeader>(nameof(DereferenceSegmentHeader)); set => WriteStructure(nameof(DereferenceSegmentHeader), value); }

        [Offset(248UL)]
        public ListEntry DeleteOnCloseList { get => ReadStructure<ListEntry>(nameof(DeleteOnCloseList)); set => WriteStructure(nameof(DeleteOnCloseList), value); }

        [Offset(264UL)]
        public ListEntry DeleteOnCloseSubsectionList { get => ReadStructure<ListEntry>(nameof(DeleteOnCloseSubsectionList)); set => WriteStructure(nameof(DeleteOnCloseSubsectionList), value); }

        [Offset(280UL)]
        public Ktimer DeleteOnCloseTimer { get => ReadStructure<Ktimer>(nameof(DeleteOnCloseTimer)); set => WriteStructure(nameof(DeleteOnCloseTimer), value); }

        [Offset(344UL)]
        public byte DeleteOnCloseTimerActive { get => ReadHere<byte>(nameof(DeleteOnCloseTimerActive)); set => WriteHere(nameof(DeleteOnCloseTimerActive), value); }

        [Offset(345UL)]
        public byte SegmentDereferenceThreadExists { get => ReadHere<byte>(nameof(SegmentDereferenceThreadExists)); set => WriteHere(nameof(SegmentDereferenceThreadExists), value); }

        [Offset(352UL)]
        public IntPtr SegmentDereferenceMailboxHeader { get => ReadHere<IntPtr>(nameof(SegmentDereferenceMailboxHeader)); set => WriteHere(nameof(SegmentDereferenceMailboxHeader), value); }

        [Offset(360UL)]
        public ulong UnusedSegmentPagedPool { get => ReadHere<ulong>(nameof(UnusedSegmentPagedPool)); set => WriteHere(nameof(UnusedSegmentPagedPool), value); }

        [Offset(368UL)]
        public ListEntry UnusedSegmentList { get => ReadStructure<ListEntry>(nameof(UnusedSegmentList)); set => WriteStructure(nameof(UnusedSegmentList), value); }

        [Offset(384UL)]
        public ListEntry DeleteSubsectionList { get => ReadStructure<ListEntry>(nameof(DeleteSubsectionList)); set => WriteStructure(nameof(DeleteSubsectionList), value); }

        [Offset(400UL)]
        public Kevent ControlAreaDeleteEvent { get => ReadStructure<Kevent>(nameof(ControlAreaDeleteEvent)); set => WriteStructure(nameof(ControlAreaDeleteEvent), value); }

        [Offset(424UL)]
        public SingleListEntry ControlAreaDeleteList { get => ReadStructure<SingleListEntry>(nameof(ControlAreaDeleteList)); set => WriteStructure(nameof(ControlAreaDeleteList), value); }

        [Offset(432UL)]
        [Length(4)]
        public DynamicArray FreedSystemCacheViews { get => ReadStructure<DynamicArray>(nameof(FreedSystemCacheViews)); set => WriteStructure(nameof(FreedSystemCacheViews), value); }

        [Offset(560UL)]
        public MiDeferredPfnsToFree FreedSystemCacheViewsReady { get => ReadStructure<MiDeferredPfnsToFree>(nameof(FreedSystemCacheViewsReady)); set => WriteStructure(nameof(FreedSystemCacheViewsReady), value); }

        [Offset(592UL)]
        public MiDeferredPfnsToFree FreedSystemCachePdesReady { get => ReadStructure<MiDeferredPfnsToFree>(nameof(FreedSystemCachePdesReady)); set => WriteStructure(nameof(FreedSystemCachePdesReady), value); }

        [Offset(624UL)]
        public Kevent CloneDereferenceEvent { get => ReadStructure<Kevent>(nameof(CloneDereferenceEvent)); set => WriteStructure(nameof(CloneDereferenceEvent), value); }

        [Offset(656UL)]
        public SlistHeader CloneProtosSListHead { get => ReadStructure<SlistHeader>(nameof(CloneProtosSListHead)); set => WriteStructure(nameof(CloneProtosSListHead), value); }

        [Offset(672UL)]
        public ExPushLock SystemCacheInitLock { get => ReadStructure<ExPushLock>(nameof(SystemCacheInitLock)); set => WriteStructure(nameof(SystemCacheInitLock), value); }

        [Offset(680UL)]
        public uint SystemCacheViewPageTables { get => ReadHere<uint>(nameof(SystemCacheViewPageTables)); set => WriteHere(nameof(SystemCacheViewPageTables), value); }

        [Offset(688UL)]
        public Kevent FreeSystemCacheVa { get => ReadStructure<Kevent>(nameof(FreeSystemCacheVa)); set => WriteStructure(nameof(FreeSystemCacheVa), value); }

        [Offset(712UL)]
        public uint PagefileExtensionWaiters { get => ReadHere<uint>(nameof(PagefileExtensionWaiters)); set => WriteHere(nameof(PagefileExtensionWaiters), value); }

        [Offset(716UL)]
        public uint PagefileExtensionRequests { get => ReadHere<uint>(nameof(PagefileExtensionRequests)); set => WriteHere(nameof(PagefileExtensionRequests), value); }

        [Offset(720UL)]
        public Kevent PagefileExtensionWaitEvent { get => ReadStructure<Kevent>(nameof(PagefileExtensionWaitEvent)); set => WriteStructure(nameof(PagefileExtensionWaitEvent), value); }

        [Offset(744UL)]
        [Length(9)]
        public DynamicArray SharedCharges { get => ReadStructure<DynamicArray>(nameof(SharedCharges)); set => WriteStructure(nameof(SharedCharges), value); }

        [Offset(1032UL)]
        public IntPtr SharedChargesDrainEvent { get => ReadHere<IntPtr>(nameof(SharedChargesDrainEvent)); set => WriteHere(nameof(SharedChargesDrainEvent), value); }

        [Offset(1040UL)]
        public IntPtr ControlAreasDrainEvent { get => ReadHere<IntPtr>(nameof(ControlAreasDrainEvent)); set => WriteHere(nameof(ControlAreasDrainEvent), value); }

        [Offset(1048UL)]
        public IntPtr CloneHeaderDrainEvent { get => ReadHere<IntPtr>(nameof(CloneHeaderDrainEvent)); set => WriteHere(nameof(CloneHeaderDrainEvent), value); }

        [Offset(1056UL)]
        public IntPtr ProbeRundownReference { get => ReadHere<IntPtr>(nameof(ProbeRundownReference)); set => WriteHere(nameof(ProbeRundownReference), value); }

        [Offset(1064UL)]
        public ulong RemoveUnusedSegmentsCommitNeeded { get => ReadHere<ulong>(nameof(RemoveUnusedSegmentsCommitNeeded)); set => WriteHere(nameof(RemoveUnusedSegmentsCommitNeeded), value); }

        [Offset(1072UL)]
        public uint SegmentDereferenceCalibrationActive { get => ReadHere<uint>(nameof(SegmentDereferenceCalibrationActive)); set => WriteHere(nameof(SegmentDereferenceCalibrationActive), value); }

        [Offset(1080UL)]
        public WorkQueueItem SegmentDereferenceCalibration { get => ReadStructure<WorkQueueItem>(nameof(SegmentDereferenceCalibration)); set => WriteStructure(nameof(SegmentDereferenceCalibration), value); }

        [Offset(1112UL)]
        public uint NumberSegmentDereferenceThreads { get => ReadHere<uint>(nameof(NumberSegmentDereferenceThreads)); set => WriteHere(nameof(NumberSegmentDereferenceThreads), value); }

        [Offset(1116UL)]
        public uint OptimalNumberSegmentDereferenceThreadsComputed { get => ReadHere<uint>(nameof(OptimalNumberSegmentDereferenceThreadsComputed)); set => WriteHere(nameof(OptimalNumberSegmentDereferenceThreadsComputed), value); }

        public MiPartitionSegments(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionSegments>();
        }
    }
}