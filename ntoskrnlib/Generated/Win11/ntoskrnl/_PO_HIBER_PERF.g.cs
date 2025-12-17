#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 744)]
    public partial struct _PO_HIBER_PERF
    {
        [FieldOffset(0)]
        public ulong HiberIoTicks;
        [FieldOffset(8)]
        public ulong HiberIoCpuTicks;
        [FieldOffset(16)]
        public ulong HiberInitTicks;
        [FieldOffset(24)]
        public ulong HiberHiberFileTicks;
        [FieldOffset(32)]
        public ulong BootCompressTicks;
        [FieldOffset(40)]
        public ulong KernelCompressTicks;
        [FieldOffset(48)]
        public ulong HiberSharedBufferTicks;
        [FieldOffset(56)]
        public ulong HiberChecksumTicks;
        [FieldOffset(64)]
        public ulong HiberChecksumIoTicks;
        [FieldOffset(72)]
        public _LARGE_INTEGER TotalHibernateTime;
        [FieldOffset(80)]
        public _LARGE_INTEGER HibernateCompleteTimestamp;
        [FieldOffset(88)]
        public uint POSTTime;
        [FieldOffset(92)]
        public uint ResumeBootMgrTime;
        [FieldOffset(96)]
        public uint BootmgrUserInputTime;
        [FieldOffset(104)]
        public ulong ResumeAppTicks;
        [FieldOffset(112)]
        public ulong ResumeAppStartTimestamp;
        [FieldOffset(120)]
        public ulong ResumeLibraryInitTicks;
        [FieldOffset(128)]
        public ulong ResumeInitTicks;
        [FieldOffset(136)]
        public ulong ResumeRestoreImageStartTimestamp;
        [FieldOffset(144)]
        public ulong ResumeHiberFileTicks;
        [FieldOffset(152)]
        public ulong ResumeIoTicks;
        [FieldOffset(160)]
        public ulong ResumeDecompressTicks;
        [FieldOffset(168)]
        public ulong ResumeAllocateTicks;
        [FieldOffset(176)]
        public ulong ResumeUserInOutTicks;
        [FieldOffset(184)]
        public ulong ResumeMapTicks;
        [FieldOffset(192)]
        public ulong ResumeUnmapTicks;
        [FieldOffset(200)]
        public ulong ResumeChecksumTicks;
        [FieldOffset(208)]
        public ulong ResumeChecksumIoTicks;
        [FieldOffset(216)]
        public ulong ResumeKernelSwitchTimestamp;
        [FieldOffset(224)]
        public ulong CyclesPerMs;
        [FieldOffset(232)]
        public ulong WriteLogDataTimestamp;
        [FieldOffset(240)]
        public ulong KernelReturnFromHandler;
        [FieldOffset(248)]
        public ulong TimeStampCounterAtSwitchTime;
        [FieldOffset(256)]
        public ulong HighestPhysicalPage;
        [FieldOffset(264)]
        public uint ProcessorCount;
        [FieldOffset(268)]
        public uint Reserved;
        [FieldOffset(272)]
        public ulong SleeperThreadEnd;
        [FieldOffset(280)]
        public ulong PostCmosUpdateTimestamp;
        [FieldOffset(288)]
        public ulong KernelReturnSystemPowerStateTimestamp;
        [FieldOffset(296)]
        public ulong IoBoundedness;
        [FieldOffset(304)]
        public ulong KernelDecompressTicks;
        [FieldOffset(312)]
        public ulong KernelIoTicks;
        [FieldOffset(320)]
        public ulong KernelCopyTicks;
        [FieldOffset(328)]
        public ulong ReadCheckCount;
        [FieldOffset(336)]
        public ulong KernelInitTicks;
        [FieldOffset(344)]
        public ulong KernelResumeHiberFileTicks;
        [FieldOffset(352)]
        public ulong KernelIoCpuTicks;
        [FieldOffset(360)]
        public ulong KernelSharedBufferTicks;
        [FieldOffset(368)]
        public ulong KernelAnimationTicks;
        [FieldOffset(376)]
        public ulong KernelChecksumTicks;
        [FieldOffset(384)]
        public ulong KernelChecksumIoTicks;
        [FieldOffset(392)]
        public _LARGE_INTEGER AnimationStart;
        [FieldOffset(400)]
        public _LARGE_INTEGER AnimationStop;
        [FieldOffset(408)]
        public uint DeviceResumeTime;
        [FieldOffset(416)]
        public ulong SecurePagesProcessed;
        [FieldOffset(424)]
        public ulong BootPagesProcessed;
        [FieldOffset(432)]
        public ulong KernelPagesProcessed;
        [FieldOffset(440)]
        public ulong BootBytesWritten;
        [FieldOffset(448)]
        public ulong KernelBytesWritten;
        [FieldOffset(456)]
        public ulong BootPagesWritten;
        [FieldOffset(464)]
        public ulong KernelPagesWritten;
        [FieldOffset(472)]
        public ulong BytesWritten;
        [FieldOffset(480)]
        public uint PagesWritten;
        [FieldOffset(484)]
        public uint FileRuns;
        [FieldOffset(488)]
        public uint NoMultiStageResumeReason;
        [FieldOffset(492)]
        public uint MaxHuffRatio;
        [FieldOffset(496)]
        public ulong AdjustedTotalResumeTime;
        [FieldOffset(504)]
        public ulong ResumeCompleteTimestamp;
        [FieldOffset(512)]
        public ulong WinresumeExitTimestamp;
        [FieldOffset(520)]
        public ulong TcbLoaderStartTimestamp;
        [FieldOffset(528)]
        public ulong TcbLoaderEndTimestamp;
        [FieldOffset(536)]
        public ulong RemappedPageLookupCycles;
        [FieldOffset(544)]
        public ulong TcbLaunchPrepareCycles;
        [FieldOffset(552)]
        public ulong TcbLaunchPrepareDataCycles;
        [FieldOffset(560)]
        public ulong TcbRestoreStateCycles;
        [FieldOffset(568)]
        public ulong DecryptVsmPagesPhase0Cycles;
        [FieldOffset(576)]
        public ulong DecryptVsmPagesPhase1Cycles;
        [FieldOffset(584)]
        public ulong DecryptVsmPagesPhase2Cycles;
        [FieldOffset(592)]
        public ulong TcbLoaderAuthenticateCycles;
        [FieldOffset(600)]
        public ulong TcbLoaderDecryptCycles;
        [FieldOffset(608)]
        public ulong TcbLoaderValidateCycles;
        [FieldOffset(616)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] BootPhaseBlockCountByMethod;
        [FieldOffset(656)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] KernelPhaseBlockCountByMethod;
        [FieldOffset(696)]
        public ulong BootPhaseWriteIoTicks;
        [FieldOffset(704)]
        public ulong KernelPhaseWriteIoTicks;
        [FieldOffset(712)]
        public ulong SecurePhaseWriteIoTicks;
        [FieldOffset(720)]
        public ulong BootPhaseSuspendWallTicks;
        [FieldOffset(728)]
        public ulong KernelPhaseSuspendWallTicks;
        [FieldOffset(736)]
        public ulong KernelPhaseResumeWallTicks;
    }
}