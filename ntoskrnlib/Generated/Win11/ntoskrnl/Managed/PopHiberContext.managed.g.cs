using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_HIBER_CONTEXT")]
    public sealed class PopHiberContext : DynamicStructure
    {
        [Offset(0UL)]
        public byte HiberFlags { get => ReadHere<byte>(nameof(HiberFlags)); set => WriteHere(nameof(HiberFlags), value); }

        [Offset(1UL)]
        public byte WroteHiberFile { get => ReadHere<byte>(nameof(WroteHiberFile)); set => WriteHere(nameof(WroteHiberFile), value); }

        [Offset(2UL)]
        public byte KernelPhaseVerificationActive { get => ReadHere<byte>(nameof(KernelPhaseVerificationActive)); set => WriteHere(nameof(KernelPhaseVerificationActive), value); }

        [Offset(3UL)]
        public byte InitializationFinished { get => ReadHere<byte>(nameof(InitializationFinished)); set => WriteHere(nameof(InitializationFinished), value); }

        [Offset(4UL)]
        public int NextTableLockHeld { get => ReadHere<int>(nameof(NextTableLockHeld)); set => WriteHere(nameof(NextTableLockHeld), value); }

        [Offset(8UL)]
        public int BootPhaseFinishedBarrier { get => ReadHere<int>(nameof(BootPhaseFinishedBarrier)); set => WriteHere(nameof(BootPhaseFinishedBarrier), value); }

        [Offset(12UL)]
        public int KernelResumeFinishedBarrier { get => ReadHere<int>(nameof(KernelResumeFinishedBarrier)); set => WriteHere(nameof(KernelResumeFinishedBarrier), value); }

        [Offset(16UL)]
        public int HvCaptureReadyBarrier { get => ReadHere<int>(nameof(HvCaptureReadyBarrier)); set => WriteHere(nameof(HvCaptureReadyBarrier), value); }

        [Offset(20UL)]
        public int HvCaptureCompletedBarrier { get => ReadHere<int>(nameof(HvCaptureCompletedBarrier)); set => WriteHere(nameof(HvCaptureCompletedBarrier), value); }

        [Offset(24UL)]
        public byte MapFrozen { get => ReadHere<byte>(nameof(MapFrozen)); set => WriteHere(nameof(MapFrozen), value); }

        [Offset(32UL)]
        public RtlBitmap BootRestoredPagesMap { get => ReadStructure<RtlBitmap>(nameof(BootRestoredPagesMap)); set => WriteStructure(nameof(BootRestoredPagesMap), value); }

        [Offset(48UL)]
        public RtlBitmap DiscardMap { get => ReadStructure<RtlBitmap>(nameof(DiscardMap)); set => WriteStructure(nameof(DiscardMap), value); }

        [Offset(48UL)]
        public RtlBitmap KernelPhaseMap { get => ReadStructure<RtlBitmap>(nameof(KernelPhaseMap)); set => WriteStructure(nameof(KernelPhaseMap), value); }

        [Offset(64UL)]
        public RtlBitmap BootPhaseMap { get => ReadStructure<RtlBitmap>(nameof(BootPhaseMap)); set => WriteStructure(nameof(BootPhaseMap), value); }

        [Offset(80UL)]
        public ListEntry ClonedRanges { get => ReadStructure<ListEntry>(nameof(ClonedRanges)); set => WriteStructure(nameof(ClonedRanges), value); }

        [Offset(96UL)]
        public uint ClonedRangeCount { get => ReadHere<uint>(nameof(ClonedRangeCount)); set => WriteHere(nameof(ClonedRangeCount), value); }

        [Offset(104UL)]
        public ulong ClonedPageCount { get => ReadHere<ulong>(nameof(ClonedPageCount)); set => WriteHere(nameof(ClonedPageCount), value); }

        [Offset(112UL)]
        public IntPtr CurrentMap { get => ReadHere<IntPtr>(nameof(CurrentMap)); set => WriteHere(nameof(CurrentMap), value); }

        [Offset(120UL)]
        public IntPtr NextCloneRange { get => ReadHere<IntPtr>(nameof(NextCloneRange)); set => WriteHere(nameof(NextCloneRange), value); }

        [Offset(128UL)]
        public ulong NextPreserve { get => ReadHere<ulong>(nameof(NextPreserve)); set => WriteHere(nameof(NextPreserve), value); }

        [Offset(136UL)]
        public IntPtr LoaderMdl { get => ReadHere<IntPtr>(nameof(LoaderMdl)); set => WriteHere(nameof(LoaderMdl), value); }

        [Offset(144UL)]
        public IntPtr AllocatedMdl { get => ReadHere<IntPtr>(nameof(AllocatedMdl)); set => WriteHere(nameof(AllocatedMdl), value); }

        [Offset(152UL)]
        public ulong PagesOut { get => ReadHere<ulong>(nameof(PagesOut)); set => WriteHere(nameof(PagesOut), value); }

        [Offset(160UL)]
        public IntPtr IoPages { get => ReadHere<IntPtr>(nameof(IoPages)); set => WriteHere(nameof(IoPages), value); }

        [Offset(168UL)]
        public uint IoPagesCount { get => ReadHere<uint>(nameof(IoPagesCount)); set => WriteHere(nameof(IoPagesCount), value); }

        [Offset(176UL)]
        public IntPtr CurrentMcb { get => ReadHere<IntPtr>(nameof(CurrentMcb)); set => WriteHere(nameof(CurrentMcb), value); }

        [Offset(184UL)]
        public IntPtr DumpStack { get => ReadHere<IntPtr>(nameof(DumpStack)); set => WriteHere(nameof(DumpStack), value); }

        [Offset(192UL)]
        public IntPtr WakeState { get => ReadHere<IntPtr>(nameof(WakeState)); set => WriteHere(nameof(WakeState), value); }

        [Offset(200UL)]
        public uint IoProgress { get => ReadHere<uint>(nameof(IoProgress)); set => WriteHere(nameof(IoProgress), value); }

        [Offset(204UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(208UL)]
        public uint GraphicsProc { get => ReadHere<uint>(nameof(GraphicsProc)); set => WriteHere(nameof(GraphicsProc), value); }

        [Offset(216UL)]
        public IntPtr MemoryImage { get => ReadHere<IntPtr>(nameof(MemoryImage)); set => WriteHere(nameof(MemoryImage), value); }

        [Offset(224UL)]
        public IntPtr PerformanceStats { get => ReadHere<IntPtr>(nameof(PerformanceStats)); set => WriteHere(nameof(PerformanceStats), value); }

        [Offset(232UL)]
        public IntPtr BootLoaderLogMdl { get => ReadHere<IntPtr>(nameof(BootLoaderLogMdl)); set => WriteHere(nameof(BootLoaderLogMdl), value); }

        [Offset(240UL)]
        public IntPtr FirmwareRuntimeInformationMdl { get => ReadHere<IntPtr>(nameof(FirmwareRuntimeInformationMdl)); set => WriteHere(nameof(FirmwareRuntimeInformationMdl), value); }

        [Offset(248UL)]
        public IntPtr FirmwareRuntimeInformationVa { get => ReadHere<IntPtr>(nameof(FirmwareRuntimeInformationVa)); set => WriteHere(nameof(FirmwareRuntimeInformationVa), value); }

        [Offset(256UL)]
        public ulong IumFirmwareRuntimeInformationPageCount { get => ReadHere<ulong>(nameof(IumFirmwareRuntimeInformationPageCount)); set => WriteHere(nameof(IumFirmwareRuntimeInformationPageCount), value); }

        [Offset(264UL)]
        public ulong IumFirmwareRuntimeInformationPfnBase { get => ReadHere<ulong>(nameof(IumFirmwareRuntimeInformationPfnBase)); set => WriteHere(nameof(IumFirmwareRuntimeInformationPfnBase), value); }

        [Offset(272UL)]
        public IntPtr ResumeContext { get => ReadHere<IntPtr>(nameof(ResumeContext)); set => WriteHere(nameof(ResumeContext), value); }

        [Offset(280UL)]
        public uint ResumeContextPages { get => ReadHere<uint>(nameof(ResumeContextPages)); set => WriteHere(nameof(ResumeContextPages), value); }

        [Offset(284UL)]
        public uint SecurePages { get => ReadHere<uint>(nameof(SecurePages)); set => WriteHere(nameof(SecurePages), value); }

        [Offset(288UL)]
        public uint ProcessorCount { get => ReadHere<uint>(nameof(ProcessorCount)); set => WriteHere(nameof(ProcessorCount), value); }

        [Offset(296UL)]
        public IntPtr ProcessorContext { get => ReadHere<IntPtr>(nameof(ProcessorContext)); set => WriteHere(nameof(ProcessorContext), value); }

        [Offset(304UL)]
        public IntPtr ProdConsBuffer { get => ReadHere<IntPtr>(nameof(ProdConsBuffer)); set => WriteHere(nameof(ProdConsBuffer), value); }

        [Offset(312UL)]
        public uint ProdConsSize { get => ReadHere<uint>(nameof(ProdConsSize)); set => WriteHere(nameof(ProdConsSize), value); }

        [Offset(316UL)]
        public uint MaxDataPages { get => ReadHere<uint>(nameof(MaxDataPages)); set => WriteHere(nameof(MaxDataPages), value); }

        [Offset(320UL)]
        public IntPtr ExtraBuffer { get => ReadHere<IntPtr>(nameof(ExtraBuffer)); set => WriteHere(nameof(ExtraBuffer), value); }

        [Offset(328UL)]
        public ulong ExtraBufferSize { get => ReadHere<ulong>(nameof(ExtraBufferSize)); set => WriteHere(nameof(ExtraBufferSize), value); }

        [Offset(336UL)]
        public IntPtr ExtraMapVa { get => ReadHere<IntPtr>(nameof(ExtraMapVa)); set => WriteHere(nameof(ExtraMapVa), value); }

        [Offset(344UL)]
        public ulong BitlockerKeyPFN { get => ReadHere<ulong>(nameof(BitlockerKeyPFN)); set => WriteHere(nameof(BitlockerKeyPFN), value); }

        [Offset(352UL)]
        public PopIoInfo IoInfo { get => ReadStructure<PopIoInfo>(nameof(IoInfo)); set => WriteStructure(nameof(IoInfo), value); }

        [Offset(464UL)]
        public IntPtr IoChecksums { get => ReadHere<IntPtr>(nameof(IoChecksums)); set => WriteHere(nameof(IoChecksums), value); }

        [Offset(472UL)]
        public ulong IoChecksumsSize { get => ReadHere<ulong>(nameof(IoChecksumsSize)); set => WriteHere(nameof(IoChecksumsSize), value); }

        [Offset(480UL)]
        public uint HardwareConfigurationSignature { get => ReadHere<uint>(nameof(HardwareConfigurationSignature)); set => WriteHere(nameof(HardwareConfigurationSignature), value); }

        [Offset(484UL)]
        public byte IumEnabled { get => ReadHere<byte>(nameof(IumEnabled)); set => WriteHere(nameof(IumEnabled), value); }

        [Offset(485UL)]
        public byte SecureBoot { get => ReadHere<byte>(nameof(SecureBoot)); set => WriteHere(nameof(SecureBoot), value); }

        [Offset(486UL)]
        public byte DisableCompressionCallbacks { get => ReadHere<byte>(nameof(DisableCompressionCallbacks)); set => WriteHere(nameof(DisableCompressionCallbacks), value); }

        [Offset(487UL)]
        public byte LZ4BootPhaseEnabled { get => ReadHere<byte>(nameof(LZ4BootPhaseEnabled)); set => WriteHere(nameof(LZ4BootPhaseEnabled), value); }

        [Offset(488UL)]
        public byte LZ4KernelPhaseEnabled { get => ReadHere<byte>(nameof(LZ4KernelPhaseEnabled)); set => WriteHere(nameof(LZ4KernelPhaseEnabled), value); }

        [Offset(489UL)]
        public byte EnableVpciHibernationCallbacks { get => ReadHere<byte>(nameof(EnableVpciHibernationCallbacks)); set => WriteHere(nameof(EnableVpciHibernationCallbacks), value); }

        public PopHiberContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopHiberContext>();
        }
    }
}