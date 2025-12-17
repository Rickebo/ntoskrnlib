using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SECTION_STATE")]
    public sealed class MiSectionState : DynamicStructure
    {
        [Offset(0UL)]
        public int SectionObjectPointersLock { get => ReadHere<int>(nameof(SectionObjectPointersLock)); set => WriteHere(nameof(SectionObjectPointersLock), value); }

        [Offset(8UL)]
        public RtlAvlTree SectionBasedRoot { get => ReadStructure<RtlAvlTree>(nameof(SectionBasedRoot)); set => WriteStructure(nameof(SectionBasedRoot), value); }

        [Offset(16UL)]
        public ExPushLock SectionBasedLock { get => ReadStructure<ExPushLock>(nameof(SectionBasedLock)); set => WriteStructure(nameof(SectionBasedLock), value); }

        [Offset(24UL)]
        public ulong UnusedSegmentPagedPool { get => ReadHere<ulong>(nameof(UnusedSegmentPagedPool)); set => WriteHere(nameof(UnusedSegmentPagedPool), value); }

        [Offset(32UL)]
        public int CalibrationIndex { get => ReadHere<int>(nameof(CalibrationIndex)); set => WriteHere(nameof(CalibrationIndex), value); }

        [Offset(40UL)]
        [Length(64)]
        public DynamicArray CalibrationData { get => ReadStructure<DynamicArray>(nameof(CalibrationData)); set => WriteStructure(nameof(CalibrationData), value); }

        [Offset(2088UL)]
        public uint DataSectionProtectionMask { get => ReadHere<uint>(nameof(DataSectionProtectionMask)); set => WriteHere(nameof(DataSectionProtectionMask), value); }

        [Offset(2096UL)]
        public IntPtr HighSectionBase { get => ReadHere<IntPtr>(nameof(HighSectionBase)); set => WriteHere(nameof(HighSectionBase), value); }

        [Offset(2104UL)]
        public Msubsection PhysicalSubsection { get => ReadStructure<Msubsection>(nameof(PhysicalSubsection)); set => WriteStructure(nameof(PhysicalSubsection), value); }

        [Offset(2256UL)]
        public ControlArea PhysicalControlArea { get => ReadStructure<ControlArea>(nameof(PhysicalControlArea)); set => WriteStructure(nameof(PhysicalControlArea), value); }

        [Offset(2384UL)]
        public Mmpfnlist PurgingExtentPages { get => ReadStructure<Mmpfnlist>(nameof(PurgingExtentPages)); set => WriteStructure(nameof(PurgingExtentPages), value); }

        [Offset(2472UL)]
        public MiPageChainHead DanglingExtentPages { get => ReadStructure<MiPageChainHead>(nameof(DanglingExtentPages)); set => WriteStructure(nameof(DanglingExtentPages), value); }

        [Offset(2496UL)]
        public WorkQueueItem DanglingExtentsWorkItem { get => ReadStructure<WorkQueueItem>(nameof(DanglingExtentsWorkItem)); set => WriteStructure(nameof(DanglingExtentsWorkItem), value); }

        [Offset(2528UL)]
        public MiExtentDeletionWaitBlock DanglingExtentsDeletionWaitList { get => ReadStructure<MiExtentDeletionWaitBlock>(nameof(DanglingExtentsDeletionWaitList)); set => WriteStructure(nameof(DanglingExtentsDeletionWaitList), value); }

        [Offset(2560UL)]
        public byte FileOnlyMemoryPfnsCreated { get => ReadHere<byte>(nameof(FileOnlyMemoryPfnsCreated)); set => WriteHere(nameof(FileOnlyMemoryPfnsCreated), value); }

        [Offset(2561UL)]
        public byte DanglingExtentsWorkerActive { get => ReadHere<byte>(nameof(DanglingExtentsWorkerActive)); set => WriteHere(nameof(DanglingExtentsWorkerActive), value); }

        [Offset(2562UL)]
        public byte PurgingExtentsNeedWatchdog { get => ReadHere<byte>(nameof(PurgingExtentsNeedWatchdog)); set => WriteHere(nameof(PurgingExtentsNeedWatchdog), value); }

        [Offset(2568UL)]
        public RtlAvlTree PrototypePtesTree { get => ReadStructure<RtlAvlTree>(nameof(PrototypePtesTree)); set => WriteStructure(nameof(PrototypePtesTree), value); }

        [Offset(2576UL)]
        public int PrototypePtesTreeSpinLock { get => ReadHere<int>(nameof(PrototypePtesTreeSpinLock)); set => WriteHere(nameof(PrototypePtesTreeSpinLock), value); }

        [Offset(2584UL)]
        public ExPushLock PrivateFixupMappingLock { get => ReadStructure<ExPushLock>(nameof(PrivateFixupMappingLock)); set => WriteStructure(nameof(PrivateFixupMappingLock), value); }

        [Offset(2592UL)]
        public IntPtr PrivateFixupPte { get => ReadHere<IntPtr>(nameof(PrivateFixupPte)); set => WriteHere(nameof(PrivateFixupPte), value); }

        [Offset(2600UL)]
        public ExPushLock RelocateBitmapsLock { get => ReadStructure<ExPushLock>(nameof(RelocateBitmapsLock)); set => WriteStructure(nameof(RelocateBitmapsLock), value); }

        [Offset(2608UL)]
        public RtlBitmapEx ImageBitMapNative { get => ReadStructure<RtlBitmapEx>(nameof(ImageBitMapNative)); set => WriteStructure(nameof(ImageBitMapNative), value); }

        [Offset(2624UL)]
        public ulong ImageBiasNative { get => ReadHere<ulong>(nameof(ImageBiasNative)); set => WriteHere(nameof(ImageBiasNative), value); }

        [Offset(2632UL)]
        public MiDllOverflowArea OverflowArea { get => ReadStructure<MiDllOverflowArea>(nameof(OverflowArea)); set => WriteStructure(nameof(OverflowArea), value); }

        [Offset(2664UL)]
        [Length(1)]
        public DynamicArray Wow { get => ReadStructure<DynamicArray>(nameof(Wow)); set => WriteStructure(nameof(Wow), value); }

        [Offset(2728UL)]
        public ulong ImageBiasWow { get => ReadHere<ulong>(nameof(ImageBiasWow)); set => WriteHere(nameof(ImageBiasWow), value); }

        [Offset(2736UL)]
        public RtlBitmapEx ImageBitMapWowScratch { get => ReadStructure<RtlBitmapEx>(nameof(ImageBitMapWowScratch)); set => WriteStructure(nameof(ImageBitMapWowScratch), value); }

        [Offset(2752UL)]
        public RtlBitmapEx ImageBitMap64Low { get => ReadStructure<RtlBitmapEx>(nameof(ImageBitMap64Low)); set => WriteStructure(nameof(ImageBitMap64Low), value); }

        [Offset(2768UL)]
        public ulong ImageBias64Low { get => ReadHere<ulong>(nameof(ImageBias64Low)); set => WriteHere(nameof(ImageBias64Low), value); }

        [Offset(2776UL)]
        public IntPtr ApiSetSection { get => ReadHere<IntPtr>(nameof(ApiSetSection)); set => WriteHere(nameof(ApiSetSection), value); }

        [Offset(2784UL)]
        public IntPtr ApiSetSchema { get => ReadHere<IntPtr>(nameof(ApiSetSchema)); set => WriteHere(nameof(ApiSetSchema), value); }

        [Offset(2792UL)]
        public ulong ApiSetSchemaSize { get => ReadHere<ulong>(nameof(ApiSetSchemaSize)); set => WriteHere(nameof(ApiSetSchemaSize), value); }

        [Offset(2800UL)]
        public uint LostDataFiles { get => ReadHere<uint>(nameof(LostDataFiles)); set => WriteHere(nameof(LostDataFiles), value); }

        [Offset(2804UL)]
        public uint LostDataPages { get => ReadHere<uint>(nameof(LostDataPages)); set => WriteHere(nameof(LostDataPages), value); }

        [Offset(2808UL)]
        public uint ImageFailureReason { get => ReadHere<uint>(nameof(ImageFailureReason)); set => WriteHere(nameof(ImageFailureReason), value); }

        [Offset(2816UL)]
        public IntPtr CfgBitMapSection { get => ReadHere<IntPtr>(nameof(CfgBitMapSection)); set => WriteHere(nameof(CfgBitMapSection), value); }

        [Offset(2824UL)]
        public IntPtr CfgBitMapControlArea { get => ReadHere<IntPtr>(nameof(CfgBitMapControlArea)); set => WriteHere(nameof(CfgBitMapControlArea), value); }

        [Offset(2832UL)]
        public RtlBitmapEx KernelCfgBitMap { get => ReadStructure<RtlBitmapEx>(nameof(KernelCfgBitMap)); set => WriteStructure(nameof(KernelCfgBitMap), value); }

        [Offset(2848UL)]
        public ExPushLock KernelCfgBitMapLock { get => ReadStructure<ExPushLock>(nameof(KernelCfgBitMapLock)); set => WriteStructure(nameof(KernelCfgBitMapLock), value); }

        [Offset(2856UL)]
        public uint ImageCfgFailure { get => ReadHere<uint>(nameof(ImageCfgFailure)); set => WriteHere(nameof(ImageCfgFailure), value); }

        [Offset(2864UL)]
        public IntPtr KernelScpStartAddress { get => ReadHere<IntPtr>(nameof(KernelScpStartAddress)); set => WriteHere(nameof(KernelScpStartAddress), value); }

        [Offset(2872UL)]
        public uint KernelScpReservePages { get => ReadHere<uint>(nameof(KernelScpReservePages)); set => WriteHere(nameof(KernelScpReservePages), value); }

        [Offset(2876UL)]
        public uint KernelScpPages { get => ReadHere<uint>(nameof(KernelScpPages)); set => WriteHere(nameof(KernelScpPages), value); }

        [Offset(2880UL)]
        public IntPtr KernelScpMdl { get => ReadHere<IntPtr>(nameof(KernelScpMdl)); set => WriteHere(nameof(KernelScpMdl), value); }

        [Offset(2888UL)]
        public int RetpolineBootStatus { get => ReadHere<int>(nameof(RetpolineBootStatus)); set => WriteHere(nameof(RetpolineBootStatus), value); }

        [Offset(2896UL)]
        public IntPtr RetpolineRevertPte { get => ReadHere<IntPtr>(nameof(RetpolineRevertPte)); set => WriteHere(nameof(RetpolineRevertPte), value); }

        [Offset(2904UL)]
        public RtlBitmapEx KernelRetpolineBitMap { get => ReadStructure<RtlBitmapEx>(nameof(KernelRetpolineBitMap)); set => WriteStructure(nameof(KernelRetpolineBitMap), value); }

        [Offset(2920UL)]
        public ListEntry NonRetpolineImageLoadList { get => ReadStructure<ListEntry>(nameof(NonRetpolineImageLoadList)); set => WriteStructure(nameof(NonRetpolineImageLoadList), value); }

        [Offset(2936UL)]
        public uint ImageBreakpointEnabled { get => ReadHere<uint>(nameof(ImageBreakpointEnabled)); set => WriteHere(nameof(ImageBreakpointEnabled), value); }

        [Offset(2940UL)]
        public uint ImageBreakpointChecksum { get => ReadHere<uint>(nameof(ImageBreakpointChecksum)); set => WriteHere(nameof(ImageBreakpointChecksum), value); }

        [Offset(2944UL)]
        public uint ImageBreakpointSize { get => ReadHere<uint>(nameof(ImageBreakpointSize)); set => WriteHere(nameof(ImageBreakpointSize), value); }

        [Offset(2948UL)]
        public int ImageValidationFailed { get => ReadHere<int>(nameof(ImageValidationFailed)); set => WriteHere(nameof(ImageValidationFailed), value); }

        [Offset(2952UL)]
        [Length(2)]
        public DynamicArray ExtentTree { get => ReadStructure<DynamicArray>(nameof(ExtentTree)); set => WriteStructure(nameof(ExtentTree), value); }

        [Offset(2968UL)]
        public ExPushLock ExtentTreeLock { get => ReadStructure<ExPushLock>(nameof(ExtentTreeLock)); set => WriteStructure(nameof(ExtentTreeLock), value); }

        [Offset(2976UL)]
        [Length(3)]
        public DynamicArray ImageViewExtensionOffsets { get => ReadStructure<DynamicArray>(nameof(ImageViewExtensionOffsets)); set => WriteStructure(nameof(ImageViewExtensionOffsets), value); }

        [Offset(2988UL)]
        public uint TotalImageViewExtensionSize { get => ReadHere<uint>(nameof(TotalImageViewExtensionSize)); set => WriteHere(nameof(TotalImageViewExtensionSize), value); }

        [Offset(2992UL)]
        public uint TotalImageViewReservationSize { get => ReadHere<uint>(nameof(TotalImageViewReservationSize)); set => WriteHere(nameof(TotalImageViewReservationSize), value); }

        [Offset(3000UL)]
        [Length(4)]
        public DynamicArray ScpCfgPages { get => ReadStructure<DynamicArray>(nameof(ScpCfgPages)); set => WriteStructure(nameof(ScpCfgPages), value); }

        [Offset(3032UL)]
        [Length(4)]
        public DynamicArray EmulatedScpCfgPages { get => ReadStructure<DynamicArray>(nameof(EmulatedScpCfgPages)); set => WriteStructure(nameof(EmulatedScpCfgPages), value); }

        public MiSectionState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSectionState>();
        }
    }
}