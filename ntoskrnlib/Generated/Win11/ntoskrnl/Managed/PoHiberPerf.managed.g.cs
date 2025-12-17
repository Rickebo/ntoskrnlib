using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_HIBER_PERF")]
    public sealed class PoHiberPerf : DynamicStructure
    {
        [Offset(0UL)]
        public ulong HiberIoTicks { get => ReadHere<ulong>(nameof(HiberIoTicks)); set => WriteHere(nameof(HiberIoTicks), value); }

        [Offset(8UL)]
        public ulong HiberIoCpuTicks { get => ReadHere<ulong>(nameof(HiberIoCpuTicks)); set => WriteHere(nameof(HiberIoCpuTicks), value); }

        [Offset(16UL)]
        public ulong HiberInitTicks { get => ReadHere<ulong>(nameof(HiberInitTicks)); set => WriteHere(nameof(HiberInitTicks), value); }

        [Offset(24UL)]
        public ulong HiberHiberFileTicks { get => ReadHere<ulong>(nameof(HiberHiberFileTicks)); set => WriteHere(nameof(HiberHiberFileTicks), value); }

        [Offset(32UL)]
        public ulong BootCompressTicks { get => ReadHere<ulong>(nameof(BootCompressTicks)); set => WriteHere(nameof(BootCompressTicks), value); }

        [Offset(40UL)]
        public ulong KernelCompressTicks { get => ReadHere<ulong>(nameof(KernelCompressTicks)); set => WriteHere(nameof(KernelCompressTicks), value); }

        [Offset(48UL)]
        public ulong HiberSharedBufferTicks { get => ReadHere<ulong>(nameof(HiberSharedBufferTicks)); set => WriteHere(nameof(HiberSharedBufferTicks), value); }

        [Offset(56UL)]
        public ulong HiberChecksumTicks { get => ReadHere<ulong>(nameof(HiberChecksumTicks)); set => WriteHere(nameof(HiberChecksumTicks), value); }

        [Offset(64UL)]
        public ulong HiberChecksumIoTicks { get => ReadHere<ulong>(nameof(HiberChecksumIoTicks)); set => WriteHere(nameof(HiberChecksumIoTicks), value); }

        [Offset(72UL)]
        public LargeInteger TotalHibernateTime { get => ReadStructure<LargeInteger>(nameof(TotalHibernateTime)); set => WriteStructure(nameof(TotalHibernateTime), value); }

        [Offset(80UL)]
        public LargeInteger HibernateCompleteTimestamp { get => ReadStructure<LargeInteger>(nameof(HibernateCompleteTimestamp)); set => WriteStructure(nameof(HibernateCompleteTimestamp), value); }

        [Offset(88UL)]
        public uint POSTTime { get => ReadHere<uint>(nameof(POSTTime)); set => WriteHere(nameof(POSTTime), value); }

        [Offset(92UL)]
        public uint ResumeBootMgrTime { get => ReadHere<uint>(nameof(ResumeBootMgrTime)); set => WriteHere(nameof(ResumeBootMgrTime), value); }

        [Offset(96UL)]
        public uint BootmgrUserInputTime { get => ReadHere<uint>(nameof(BootmgrUserInputTime)); set => WriteHere(nameof(BootmgrUserInputTime), value); }

        [Offset(104UL)]
        public ulong ResumeAppTicks { get => ReadHere<ulong>(nameof(ResumeAppTicks)); set => WriteHere(nameof(ResumeAppTicks), value); }

        [Offset(112UL)]
        public ulong ResumeAppStartTimestamp { get => ReadHere<ulong>(nameof(ResumeAppStartTimestamp)); set => WriteHere(nameof(ResumeAppStartTimestamp), value); }

        [Offset(120UL)]
        public ulong ResumeLibraryInitTicks { get => ReadHere<ulong>(nameof(ResumeLibraryInitTicks)); set => WriteHere(nameof(ResumeLibraryInitTicks), value); }

        [Offset(128UL)]
        public ulong ResumeInitTicks { get => ReadHere<ulong>(nameof(ResumeInitTicks)); set => WriteHere(nameof(ResumeInitTicks), value); }

        [Offset(136UL)]
        public ulong ResumeRestoreImageStartTimestamp { get => ReadHere<ulong>(nameof(ResumeRestoreImageStartTimestamp)); set => WriteHere(nameof(ResumeRestoreImageStartTimestamp), value); }

        [Offset(144UL)]
        public ulong ResumeHiberFileTicks { get => ReadHere<ulong>(nameof(ResumeHiberFileTicks)); set => WriteHere(nameof(ResumeHiberFileTicks), value); }

        [Offset(152UL)]
        public ulong ResumeIoTicks { get => ReadHere<ulong>(nameof(ResumeIoTicks)); set => WriteHere(nameof(ResumeIoTicks), value); }

        [Offset(160UL)]
        public ulong ResumeDecompressTicks { get => ReadHere<ulong>(nameof(ResumeDecompressTicks)); set => WriteHere(nameof(ResumeDecompressTicks), value); }

        [Offset(168UL)]
        public ulong ResumeAllocateTicks { get => ReadHere<ulong>(nameof(ResumeAllocateTicks)); set => WriteHere(nameof(ResumeAllocateTicks), value); }

        [Offset(176UL)]
        public ulong ResumeUserInOutTicks { get => ReadHere<ulong>(nameof(ResumeUserInOutTicks)); set => WriteHere(nameof(ResumeUserInOutTicks), value); }

        [Offset(184UL)]
        public ulong ResumeMapTicks { get => ReadHere<ulong>(nameof(ResumeMapTicks)); set => WriteHere(nameof(ResumeMapTicks), value); }

        [Offset(192UL)]
        public ulong ResumeUnmapTicks { get => ReadHere<ulong>(nameof(ResumeUnmapTicks)); set => WriteHere(nameof(ResumeUnmapTicks), value); }

        [Offset(200UL)]
        public ulong ResumeChecksumTicks { get => ReadHere<ulong>(nameof(ResumeChecksumTicks)); set => WriteHere(nameof(ResumeChecksumTicks), value); }

        [Offset(208UL)]
        public ulong ResumeChecksumIoTicks { get => ReadHere<ulong>(nameof(ResumeChecksumIoTicks)); set => WriteHere(nameof(ResumeChecksumIoTicks), value); }

        [Offset(216UL)]
        public ulong ResumeKernelSwitchTimestamp { get => ReadHere<ulong>(nameof(ResumeKernelSwitchTimestamp)); set => WriteHere(nameof(ResumeKernelSwitchTimestamp), value); }

        [Offset(224UL)]
        public ulong CyclesPerMs { get => ReadHere<ulong>(nameof(CyclesPerMs)); set => WriteHere(nameof(CyclesPerMs), value); }

        [Offset(232UL)]
        public ulong WriteLogDataTimestamp { get => ReadHere<ulong>(nameof(WriteLogDataTimestamp)); set => WriteHere(nameof(WriteLogDataTimestamp), value); }

        [Offset(240UL)]
        public ulong KernelReturnFromHandler { get => ReadHere<ulong>(nameof(KernelReturnFromHandler)); set => WriteHere(nameof(KernelReturnFromHandler), value); }

        [Offset(248UL)]
        public ulong TimeStampCounterAtSwitchTime { get => ReadHere<ulong>(nameof(TimeStampCounterAtSwitchTime)); set => WriteHere(nameof(TimeStampCounterAtSwitchTime), value); }

        [Offset(256UL)]
        public ulong HighestPhysicalPage { get => ReadHere<ulong>(nameof(HighestPhysicalPage)); set => WriteHere(nameof(HighestPhysicalPage), value); }

        [Offset(264UL)]
        public uint ProcessorCount { get => ReadHere<uint>(nameof(ProcessorCount)); set => WriteHere(nameof(ProcessorCount), value); }

        [Offset(268UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(272UL)]
        public ulong SleeperThreadEnd { get => ReadHere<ulong>(nameof(SleeperThreadEnd)); set => WriteHere(nameof(SleeperThreadEnd), value); }

        [Offset(280UL)]
        public ulong PostCmosUpdateTimestamp { get => ReadHere<ulong>(nameof(PostCmosUpdateTimestamp)); set => WriteHere(nameof(PostCmosUpdateTimestamp), value); }

        [Offset(288UL)]
        public ulong KernelReturnSystemPowerStateTimestamp { get => ReadHere<ulong>(nameof(KernelReturnSystemPowerStateTimestamp)); set => WriteHere(nameof(KernelReturnSystemPowerStateTimestamp), value); }

        [Offset(296UL)]
        public ulong IoBoundedness { get => ReadHere<ulong>(nameof(IoBoundedness)); set => WriteHere(nameof(IoBoundedness), value); }

        [Offset(304UL)]
        public ulong KernelDecompressTicks { get => ReadHere<ulong>(nameof(KernelDecompressTicks)); set => WriteHere(nameof(KernelDecompressTicks), value); }

        [Offset(312UL)]
        public ulong KernelIoTicks { get => ReadHere<ulong>(nameof(KernelIoTicks)); set => WriteHere(nameof(KernelIoTicks), value); }

        [Offset(320UL)]
        public ulong KernelCopyTicks { get => ReadHere<ulong>(nameof(KernelCopyTicks)); set => WriteHere(nameof(KernelCopyTicks), value); }

        [Offset(328UL)]
        public ulong ReadCheckCount { get => ReadHere<ulong>(nameof(ReadCheckCount)); set => WriteHere(nameof(ReadCheckCount), value); }

        [Offset(336UL)]
        public ulong KernelInitTicks { get => ReadHere<ulong>(nameof(KernelInitTicks)); set => WriteHere(nameof(KernelInitTicks), value); }

        [Offset(344UL)]
        public ulong KernelResumeHiberFileTicks { get => ReadHere<ulong>(nameof(KernelResumeHiberFileTicks)); set => WriteHere(nameof(KernelResumeHiberFileTicks), value); }

        [Offset(352UL)]
        public ulong KernelIoCpuTicks { get => ReadHere<ulong>(nameof(KernelIoCpuTicks)); set => WriteHere(nameof(KernelIoCpuTicks), value); }

        [Offset(360UL)]
        public ulong KernelSharedBufferTicks { get => ReadHere<ulong>(nameof(KernelSharedBufferTicks)); set => WriteHere(nameof(KernelSharedBufferTicks), value); }

        [Offset(368UL)]
        public ulong KernelAnimationTicks { get => ReadHere<ulong>(nameof(KernelAnimationTicks)); set => WriteHere(nameof(KernelAnimationTicks), value); }

        [Offset(376UL)]
        public ulong KernelChecksumTicks { get => ReadHere<ulong>(nameof(KernelChecksumTicks)); set => WriteHere(nameof(KernelChecksumTicks), value); }

        [Offset(384UL)]
        public ulong KernelChecksumIoTicks { get => ReadHere<ulong>(nameof(KernelChecksumIoTicks)); set => WriteHere(nameof(KernelChecksumIoTicks), value); }

        [Offset(392UL)]
        public LargeInteger AnimationStart { get => ReadStructure<LargeInteger>(nameof(AnimationStart)); set => WriteStructure(nameof(AnimationStart), value); }

        [Offset(400UL)]
        public LargeInteger AnimationStop { get => ReadStructure<LargeInteger>(nameof(AnimationStop)); set => WriteStructure(nameof(AnimationStop), value); }

        [Offset(408UL)]
        public uint DeviceResumeTime { get => ReadHere<uint>(nameof(DeviceResumeTime)); set => WriteHere(nameof(DeviceResumeTime), value); }

        [Offset(416UL)]
        public ulong SecurePagesProcessed { get => ReadHere<ulong>(nameof(SecurePagesProcessed)); set => WriteHere(nameof(SecurePagesProcessed), value); }

        [Offset(424UL)]
        public ulong BootPagesProcessed { get => ReadHere<ulong>(nameof(BootPagesProcessed)); set => WriteHere(nameof(BootPagesProcessed), value); }

        [Offset(432UL)]
        public ulong KernelPagesProcessed { get => ReadHere<ulong>(nameof(KernelPagesProcessed)); set => WriteHere(nameof(KernelPagesProcessed), value); }

        [Offset(440UL)]
        public ulong BootBytesWritten { get => ReadHere<ulong>(nameof(BootBytesWritten)); set => WriteHere(nameof(BootBytesWritten), value); }

        [Offset(448UL)]
        public ulong KernelBytesWritten { get => ReadHere<ulong>(nameof(KernelBytesWritten)); set => WriteHere(nameof(KernelBytesWritten), value); }

        [Offset(456UL)]
        public ulong BootPagesWritten { get => ReadHere<ulong>(nameof(BootPagesWritten)); set => WriteHere(nameof(BootPagesWritten), value); }

        [Offset(464UL)]
        public ulong KernelPagesWritten { get => ReadHere<ulong>(nameof(KernelPagesWritten)); set => WriteHere(nameof(KernelPagesWritten), value); }

        [Offset(472UL)]
        public ulong BytesWritten { get => ReadHere<ulong>(nameof(BytesWritten)); set => WriteHere(nameof(BytesWritten), value); }

        [Offset(480UL)]
        public uint PagesWritten { get => ReadHere<uint>(nameof(PagesWritten)); set => WriteHere(nameof(PagesWritten), value); }

        [Offset(484UL)]
        public uint FileRuns { get => ReadHere<uint>(nameof(FileRuns)); set => WriteHere(nameof(FileRuns), value); }

        [Offset(488UL)]
        public uint NoMultiStageResumeReason { get => ReadHere<uint>(nameof(NoMultiStageResumeReason)); set => WriteHere(nameof(NoMultiStageResumeReason), value); }

        [Offset(492UL)]
        public uint MaxHuffRatio { get => ReadHere<uint>(nameof(MaxHuffRatio)); set => WriteHere(nameof(MaxHuffRatio), value); }

        [Offset(496UL)]
        public ulong AdjustedTotalResumeTime { get => ReadHere<ulong>(nameof(AdjustedTotalResumeTime)); set => WriteHere(nameof(AdjustedTotalResumeTime), value); }

        [Offset(504UL)]
        public ulong ResumeCompleteTimestamp { get => ReadHere<ulong>(nameof(ResumeCompleteTimestamp)); set => WriteHere(nameof(ResumeCompleteTimestamp), value); }

        [Offset(512UL)]
        public ulong WinresumeExitTimestamp { get => ReadHere<ulong>(nameof(WinresumeExitTimestamp)); set => WriteHere(nameof(WinresumeExitTimestamp), value); }

        [Offset(520UL)]
        public ulong TcbLoaderStartTimestamp { get => ReadHere<ulong>(nameof(TcbLoaderStartTimestamp)); set => WriteHere(nameof(TcbLoaderStartTimestamp), value); }

        [Offset(528UL)]
        public ulong TcbLoaderEndTimestamp { get => ReadHere<ulong>(nameof(TcbLoaderEndTimestamp)); set => WriteHere(nameof(TcbLoaderEndTimestamp), value); }

        [Offset(536UL)]
        public ulong RemappedPageLookupCycles { get => ReadHere<ulong>(nameof(RemappedPageLookupCycles)); set => WriteHere(nameof(RemappedPageLookupCycles), value); }

        [Offset(544UL)]
        public ulong TcbLaunchPrepareCycles { get => ReadHere<ulong>(nameof(TcbLaunchPrepareCycles)); set => WriteHere(nameof(TcbLaunchPrepareCycles), value); }

        [Offset(552UL)]
        public ulong TcbLaunchPrepareDataCycles { get => ReadHere<ulong>(nameof(TcbLaunchPrepareDataCycles)); set => WriteHere(nameof(TcbLaunchPrepareDataCycles), value); }

        [Offset(560UL)]
        public ulong TcbRestoreStateCycles { get => ReadHere<ulong>(nameof(TcbRestoreStateCycles)); set => WriteHere(nameof(TcbRestoreStateCycles), value); }

        [Offset(568UL)]
        public ulong DecryptVsmPagesPhase0Cycles { get => ReadHere<ulong>(nameof(DecryptVsmPagesPhase0Cycles)); set => WriteHere(nameof(DecryptVsmPagesPhase0Cycles), value); }

        [Offset(576UL)]
        public ulong DecryptVsmPagesPhase1Cycles { get => ReadHere<ulong>(nameof(DecryptVsmPagesPhase1Cycles)); set => WriteHere(nameof(DecryptVsmPagesPhase1Cycles), value); }

        [Offset(584UL)]
        public ulong DecryptVsmPagesPhase2Cycles { get => ReadHere<ulong>(nameof(DecryptVsmPagesPhase2Cycles)); set => WriteHere(nameof(DecryptVsmPagesPhase2Cycles), value); }

        [Offset(592UL)]
        public ulong TcbLoaderAuthenticateCycles { get => ReadHere<ulong>(nameof(TcbLoaderAuthenticateCycles)); set => WriteHere(nameof(TcbLoaderAuthenticateCycles), value); }

        [Offset(600UL)]
        public ulong TcbLoaderDecryptCycles { get => ReadHere<ulong>(nameof(TcbLoaderDecryptCycles)); set => WriteHere(nameof(TcbLoaderDecryptCycles), value); }

        [Offset(608UL)]
        public ulong TcbLoaderValidateCycles { get => ReadHere<ulong>(nameof(TcbLoaderValidateCycles)); set => WriteHere(nameof(TcbLoaderValidateCycles), value); }

        [Offset(616UL)]
        [Length(5)]
        public DynamicArray BootPhaseBlockCountByMethod { get => ReadStructure<DynamicArray>(nameof(BootPhaseBlockCountByMethod)); set => WriteStructure(nameof(BootPhaseBlockCountByMethod), value); }

        [Offset(656UL)]
        [Length(5)]
        public DynamicArray KernelPhaseBlockCountByMethod { get => ReadStructure<DynamicArray>(nameof(KernelPhaseBlockCountByMethod)); set => WriteStructure(nameof(KernelPhaseBlockCountByMethod), value); }

        [Offset(696UL)]
        public ulong BootPhaseWriteIoTicks { get => ReadHere<ulong>(nameof(BootPhaseWriteIoTicks)); set => WriteHere(nameof(BootPhaseWriteIoTicks), value); }

        [Offset(704UL)]
        public ulong KernelPhaseWriteIoTicks { get => ReadHere<ulong>(nameof(KernelPhaseWriteIoTicks)); set => WriteHere(nameof(KernelPhaseWriteIoTicks), value); }

        [Offset(712UL)]
        public ulong SecurePhaseWriteIoTicks { get => ReadHere<ulong>(nameof(SecurePhaseWriteIoTicks)); set => WriteHere(nameof(SecurePhaseWriteIoTicks), value); }

        [Offset(720UL)]
        public ulong BootPhaseSuspendWallTicks { get => ReadHere<ulong>(nameof(BootPhaseSuspendWallTicks)); set => WriteHere(nameof(BootPhaseSuspendWallTicks), value); }

        [Offset(728UL)]
        public ulong KernelPhaseSuspendWallTicks { get => ReadHere<ulong>(nameof(KernelPhaseSuspendWallTicks)); set => WriteHere(nameof(KernelPhaseSuspendWallTicks), value); }

        [Offset(736UL)]
        public ulong KernelPhaseResumeWallTicks { get => ReadHere<ulong>(nameof(KernelPhaseResumeWallTicks)); set => WriteHere(nameof(KernelPhaseResumeWallTicks), value); }

        public PoHiberPerf(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoHiberPerf>();
        }
    }
}