using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_MODWRITES")]
    public sealed class MiPartitionModwrites : DynamicStructure
    {
        [Offset(0UL)]
        public MmpageFileExpansion AttemptForCantExtend { get => ReadStructure<MmpageFileExpansion>(nameof(AttemptForCantExtend)); set => WriteStructure(nameof(AttemptForCantExtend), value); }

        [Offset(88UL)]
        public MmpageFileExpansion PageFileContract { get => ReadStructure<MmpageFileExpansion>(nameof(PageFileContract)); set => WriteStructure(nameof(PageFileContract), value); }

        [Offset(176UL)]
        public ExPushLock MappedWriterChargesLock { get => ReadStructure<ExPushLock>(nameof(MappedWriterChargesLock)); set => WriteStructure(nameof(MappedWriterChargesLock), value); }

        [Offset(184UL)]
        public uint NumberOfMappedMdls { get => ReadHere<uint>(nameof(NumberOfMappedMdls)); set => WriteHere(nameof(NumberOfMappedMdls), value); }

        [Offset(188UL)]
        public uint NumberOfForwardProgressMappedMdls { get => ReadHere<uint>(nameof(NumberOfForwardProgressMappedMdls)); set => WriteHere(nameof(NumberOfForwardProgressMappedMdls), value); }

        [Offset(192UL)]
        public int NumberOfMappedMdlsInUse { get => ReadHere<int>(nameof(NumberOfMappedMdlsInUse)); set => WriteHere(nameof(NumberOfMappedMdlsInUse), value); }

        [Offset(196UL)]
        public uint NumberOfMappedMdlsInUsePeak { get => ReadHere<uint>(nameof(NumberOfMappedMdlsInUsePeak)); set => WriteHere(nameof(NumberOfMappedMdlsInUsePeak), value); }

        [Offset(200UL)]
        public MmmodWriterListhead MappedFileHeader { get => ReadStructure<MmmodWriterListhead>(nameof(MappedFileHeader)); set => WriteStructure(nameof(MappedFileHeader), value); }

        [Offset(240UL)]
        public byte NeedMappedMdl { get => ReadHere<byte>(nameof(NeedMappedMdl)); set => WriteHere(nameof(NeedMappedMdl), value); }

        [Offset(241UL)]
        public byte NeedPageFileMdl { get => ReadHere<byte>(nameof(NeedPageFileMdl)); set => WriteHere(nameof(NeedPageFileMdl), value); }

        [Offset(242UL)]
        public byte ModwriterActive { get => ReadHere<byte>(nameof(ModwriterActive)); set => WriteHere(nameof(ModwriterActive), value); }

        [Offset(243UL)]
        public byte TransitionInserted { get => ReadHere<byte>(nameof(TransitionInserted)); set => WriteHere(nameof(TransitionInserted), value); }

        [Offset(244UL)]
        public int LastModifiedWriteError { get => ReadHere<int>(nameof(LastModifiedWriteError)); set => WriteHere(nameof(LastModifiedWriteError), value); }

        [Offset(248UL)]
        public int LastMappedWriteError { get => ReadHere<int>(nameof(LastMappedWriteError)); set => WriteHere(nameof(LastMappedWriteError), value); }

        [Offset(252UL)]
        public uint MappedFileWriteSucceeded { get => ReadHere<uint>(nameof(MappedFileWriteSucceeded)); set => WriteHere(nameof(MappedFileWriteSucceeded), value); }

        [Offset(256UL)]
        public uint MappedWriteBurstCount { get => ReadHere<uint>(nameof(MappedWriteBurstCount)); set => WriteHere(nameof(MappedWriteBurstCount), value); }

        [Offset(260UL)]
        public uint LowPriorityModWritesOutstanding { get => ReadHere<uint>(nameof(LowPriorityModWritesOutstanding)); set => WriteHere(nameof(LowPriorityModWritesOutstanding), value); }

        [Offset(264UL)]
        public Kevent BoostModWriteIoPriorityEvent { get => ReadStructure<Kevent>(nameof(BoostModWriteIoPriorityEvent)); set => WriteStructure(nameof(BoostModWriteIoPriorityEvent), value); }

        [Offset(288UL)]
        public int ModifiedWriterThreadPriority { get => ReadHere<int>(nameof(ModifiedWriterThreadPriority)); set => WriteHere(nameof(ModifiedWriterThreadPriority), value); }

        [Offset(296UL)]
        public ulong ModifiedPagesLowPriorityGoal { get => ReadHere<ulong>(nameof(ModifiedPagesLowPriorityGoal)); set => WriteHere(nameof(ModifiedPagesLowPriorityGoal), value); }

        [Offset(304UL)]
        public Kevent ModifiedPageWriterEvent { get => ReadStructure<Kevent>(nameof(ModifiedPageWriterEvent)); set => WriteStructure(nameof(ModifiedPageWriterEvent), value); }

        [Offset(328UL)]
        public Kevent ModifiedWriterExitedEvent { get => ReadStructure<Kevent>(nameof(ModifiedWriterExitedEvent)); set => WriteStructure(nameof(ModifiedWriterExitedEvent), value); }

        [Offset(352UL)]
        public int WriteAllPagefilePages { get => ReadHere<int>(nameof(WriteAllPagefilePages)); set => WriteHere(nameof(WriteAllPagefilePages), value); }

        [Offset(356UL)]
        public int WriteAllMappedPages { get => ReadHere<int>(nameof(WriteAllMappedPages)); set => WriteHere(nameof(WriteAllMappedPages), value); }

        [Offset(360UL)]
        public Kevent MappedPageWriterEvent { get => ReadStructure<Kevent>(nameof(MappedPageWriterEvent)); set => WriteStructure(nameof(MappedPageWriterEvent), value); }

        [Offset(384UL)]
        public MiModwriteData ModWriteData { get => ReadStructure<MiModwriteData>(nameof(ModWriteData)); set => WriteStructure(nameof(ModWriteData), value); }

        [Offset(448UL)]
        public Kevent RescanPageFilesEvent { get => ReadStructure<Kevent>(nameof(RescanPageFilesEvent)); set => WriteStructure(nameof(RescanPageFilesEvent), value); }

        [Offset(472UL)]
        public MmmodWriterListhead PagingFileHeader { get => ReadStructure<MmmodWriterListhead>(nameof(PagingFileHeader)); set => WriteStructure(nameof(PagingFileHeader), value); }

        [Offset(512UL)]
        public IntPtr ModifiedPageWriterThread { get => ReadHere<IntPtr>(nameof(ModifiedPageWriterThread)); set => WriteHere(nameof(ModifiedPageWriterThread), value); }

        [Offset(520UL)]
        public ExRundownRef ModifiedPageWriterRundown { get => ReadStructure<ExRundownRef>(nameof(ModifiedPageWriterRundown)); set => WriteStructure(nameof(ModifiedPageWriterRundown), value); }

        [Offset(528UL)]
        public WorkQueueItem PagefileScanWorkItem { get => ReadStructure<WorkQueueItem>(nameof(PagefileScanWorkItem)); set => WriteStructure(nameof(PagefileScanWorkItem), value); }

        [Offset(560UL)]
        public uint PagefileScanCount { get => ReadHere<uint>(nameof(PagefileScanCount)); set => WriteHere(nameof(PagefileScanCount), value); }

        [Offset(564UL)]
        public int ClusterRestrictionLock { get => ReadHere<int>(nameof(ClusterRestrictionLock)); set => WriteHere(nameof(ClusterRestrictionLock), value); }

        [Offset(568UL)]
        [Length(2)]
        public DynamicArray ClusterRestrictions { get => ReadStructure<DynamicArray>(nameof(ClusterRestrictions)); set => WriteStructure(nameof(ClusterRestrictions), value); }

        [Offset(576UL)]
        public Kevent NotifyStoreMemoryConditions { get => ReadStructure<Kevent>(nameof(NotifyStoreMemoryConditions)); set => WriteStructure(nameof(NotifyStoreMemoryConditions), value); }

        [Offset(600UL)]
        public byte DelayMappedWrite { get => ReadHere<byte>(nameof(DelayMappedWrite)); set => WriteHere(nameof(DelayMappedWrite), value); }

        [Offset(604UL)]
        public uint PagefileReservationsEnabled { get => ReadHere<uint>(nameof(PagefileReservationsEnabled)); set => WriteHere(nameof(PagefileReservationsEnabled), value); }

        [Offset(608UL)]
        public ExPushLock PageFileCreationLock { get => ReadStructure<ExPushLock>(nameof(PageFileCreationLock)); set => WriteStructure(nameof(PageFileCreationLock), value); }

        [Offset(616UL)]
        public WorkQueueItem TrimPagefileWorkItem { get => ReadStructure<WorkQueueItem>(nameof(TrimPagefileWorkItem)); set => WriteStructure(nameof(TrimPagefileWorkItem), value); }

        [Offset(648UL)]
        public ulong LastTrimPagefileTime { get => ReadHere<ulong>(nameof(LastTrimPagefileTime)); set => WriteHere(nameof(LastTrimPagefileTime), value); }

        [Offset(656UL)]
        public WorkQueueItem WsSwapPagefileContractWorkItem { get => ReadStructure<WorkQueueItem>(nameof(WsSwapPagefileContractWorkItem)); set => WriteStructure(nameof(WsSwapPagefileContractWorkItem), value); }

        [Offset(688UL)]
        public int WsSwapPageFileContractionInProgress { get => ReadHere<int>(nameof(WsSwapPageFileContractionInProgress)); set => WriteHere(nameof(WsSwapPageFileContractionInProgress), value); }

        [Offset(696UL)]
        public ExPushLock WorkingSetSwapLock { get => ReadStructure<ExPushLock>(nameof(WorkingSetSwapLock)); set => WriteStructure(nameof(WorkingSetSwapLock), value); }

        [Offset(704UL)]
        public int WorkingSetInswapLock { get => ReadHere<int>(nameof(WorkingSetInswapLock)); set => WriteHere(nameof(WorkingSetInswapLock), value); }

        public MiPartitionModwrites(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionModwrites>();
        }
    }
}