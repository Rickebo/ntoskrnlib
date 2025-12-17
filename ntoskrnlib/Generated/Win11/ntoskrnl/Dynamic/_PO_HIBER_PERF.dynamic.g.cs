using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_HIBER_PERF")]
    public sealed class _PO_HIBER_PERF : DynamicStructure
    {
        public ulong HiberIoTicks { get; }
        public ulong HiberIoCpuTicks { get; }
        public ulong HiberInitTicks { get; }
        public ulong HiberHiberFileTicks { get; }
        public ulong BootCompressTicks { get; }
        public ulong KernelCompressTicks { get; }
        public ulong HiberSharedBufferTicks { get; }
        public ulong HiberChecksumTicks { get; }
        public ulong HiberChecksumIoTicks { get; }
        public _LARGE_INTEGER TotalHibernateTime { get; }
        public _LARGE_INTEGER HibernateCompleteTimestamp { get; }
        public uint POSTTime { get; }
        public uint ResumeBootMgrTime { get; }
        public uint BootmgrUserInputTime { get; }
        public ulong ResumeAppTicks { get; }
        public ulong ResumeAppStartTimestamp { get; }
        public ulong ResumeLibraryInitTicks { get; }
        public ulong ResumeInitTicks { get; }
        public ulong ResumeRestoreImageStartTimestamp { get; }
        public ulong ResumeHiberFileTicks { get; }
        public ulong ResumeIoTicks { get; }
        public ulong ResumeDecompressTicks { get; }
        public ulong ResumeAllocateTicks { get; }
        public ulong ResumeUserInOutTicks { get; }
        public ulong ResumeMapTicks { get; }
        public ulong ResumeUnmapTicks { get; }
        public ulong ResumeChecksumTicks { get; }
        public ulong ResumeChecksumIoTicks { get; }
        public ulong ResumeKernelSwitchTimestamp { get; }
        public ulong CyclesPerMs { get; }
        public ulong WriteLogDataTimestamp { get; }
        public ulong KernelReturnFromHandler { get; }
        public ulong TimeStampCounterAtSwitchTime { get; }
        public ulong HighestPhysicalPage { get; }
        public uint ProcessorCount { get; }
        public uint Reserved { get; }
        public ulong SleeperThreadEnd { get; }
        public ulong PostCmosUpdateTimestamp { get; }
        public ulong KernelReturnSystemPowerStateTimestamp { get; }
        public ulong IoBoundedness { get; }
        public ulong KernelDecompressTicks { get; }
        public ulong KernelIoTicks { get; }
        public ulong KernelCopyTicks { get; }
        public ulong ReadCheckCount { get; }
        public ulong KernelInitTicks { get; }
        public ulong KernelResumeHiberFileTicks { get; }
        public ulong KernelIoCpuTicks { get; }
        public ulong KernelSharedBufferTicks { get; }
        public ulong KernelAnimationTicks { get; }
        public ulong KernelChecksumTicks { get; }
        public ulong KernelChecksumIoTicks { get; }
        public _LARGE_INTEGER AnimationStart { get; }
        public _LARGE_INTEGER AnimationStop { get; }
        public uint DeviceResumeTime { get; }
        public ulong SecurePagesProcessed { get; }
        public ulong BootPagesProcessed { get; }
        public ulong KernelPagesProcessed { get; }
        public ulong BootBytesWritten { get; }
        public ulong KernelBytesWritten { get; }
        public ulong BootPagesWritten { get; }
        public ulong KernelPagesWritten { get; }
        public ulong BytesWritten { get; }
        public uint PagesWritten { get; }
        public uint FileRuns { get; }
        public uint NoMultiStageResumeReason { get; }
        public uint MaxHuffRatio { get; }
        public ulong AdjustedTotalResumeTime { get; }
        public ulong ResumeCompleteTimestamp { get; }
        public ulong WinresumeExitTimestamp { get; }
        public ulong TcbLoaderStartTimestamp { get; }
        public ulong TcbLoaderEndTimestamp { get; }
        public ulong RemappedPageLookupCycles { get; }
        public ulong TcbLaunchPrepareCycles { get; }
        public ulong TcbLaunchPrepareDataCycles { get; }
        public ulong TcbRestoreStateCycles { get; }
        public ulong DecryptVsmPagesPhase0Cycles { get; }
        public ulong DecryptVsmPagesPhase1Cycles { get; }
        public ulong DecryptVsmPagesPhase2Cycles { get; }
        public ulong TcbLoaderAuthenticateCycles { get; }
        public ulong TcbLoaderDecryptCycles { get; }
        public ulong TcbLoaderValidateCycles { get; }
        public ulong[] BootPhaseBlockCountByMethod { get; }
        public ulong[] KernelPhaseBlockCountByMethod { get; }
        public ulong BootPhaseWriteIoTicks { get; }
        public ulong KernelPhaseWriteIoTicks { get; }
        public ulong SecurePhaseWriteIoTicks { get; }
        public ulong BootPhaseSuspendWallTicks { get; }
        public ulong KernelPhaseSuspendWallTicks { get; }
        public ulong KernelPhaseResumeWallTicks { get; }

        public _PO_HIBER_PERF(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_HIBER_PERF()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_HIBER_PERF.HiberIoTicks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.HiberIoCpuTicks),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.HiberInitTicks),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.HiberHiberFileTicks),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BootCompressTicks),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelCompressTicks),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.HiberSharedBufferTicks),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.HiberChecksumTicks),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.HiberChecksumIoTicks),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TotalHibernateTime),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.HibernateCompleteTimestamp),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.POSTTime),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeBootMgrTime),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BootmgrUserInputTime),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeAppTicks),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeAppStartTimestamp),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeLibraryInitTicks),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeInitTicks),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeRestoreImageStartTimestamp),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeHiberFileTicks),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeIoTicks),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeDecompressTicks),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeAllocateTicks),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeUserInOutTicks),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeMapTicks),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeUnmapTicks),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeChecksumTicks),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeChecksumIoTicks),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeKernelSwitchTimestamp),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.CyclesPerMs),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.WriteLogDataTimestamp),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelReturnFromHandler),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TimeStampCounterAtSwitchTime),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.HighestPhysicalPage),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ProcessorCount),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.Reserved),
                    new ulong[]
                    {
                        268UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.SleeperThreadEnd),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.PostCmosUpdateTimestamp),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelReturnSystemPowerStateTimestamp),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.IoBoundedness),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelDecompressTicks),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelIoTicks),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelCopyTicks),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ReadCheckCount),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelInitTicks),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelResumeHiberFileTicks),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelIoCpuTicks),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelSharedBufferTicks),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelAnimationTicks),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelChecksumTicks),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelChecksumIoTicks),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.AnimationStart),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.AnimationStop),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.DeviceResumeTime),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.SecurePagesProcessed),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BootPagesProcessed),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelPagesProcessed),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BootBytesWritten),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelBytesWritten),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BootPagesWritten),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelPagesWritten),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BytesWritten),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.PagesWritten),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.FileRuns),
                    new ulong[]
                    {
                        484UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.NoMultiStageResumeReason),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.MaxHuffRatio),
                    new ulong[]
                    {
                        492UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.AdjustedTotalResumeTime),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.ResumeCompleteTimestamp),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.WinresumeExitTimestamp),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TcbLoaderStartTimestamp),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TcbLoaderEndTimestamp),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.RemappedPageLookupCycles),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TcbLaunchPrepareCycles),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TcbLaunchPrepareDataCycles),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TcbRestoreStateCycles),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.DecryptVsmPagesPhase0Cycles),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.DecryptVsmPagesPhase1Cycles),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.DecryptVsmPagesPhase2Cycles),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TcbLoaderAuthenticateCycles),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TcbLoaderDecryptCycles),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.TcbLoaderValidateCycles),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BootPhaseBlockCountByMethod),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelPhaseBlockCountByMethod),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BootPhaseWriteIoTicks),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelPhaseWriteIoTicks),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.SecurePhaseWriteIoTicks),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.BootPhaseSuspendWallTicks),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelPhaseSuspendWallTicks),
                    new ulong[]
                    {
                        728UL
                    }
                },
                {
                    nameof(_PO_HIBER_PERF.KernelPhaseResumeWallTicks),
                    new ulong[]
                    {
                        736UL
                    }
                }
            };
            Register<_PO_HIBER_PERF>((mem, ptr) => new _PO_HIBER_PERF(mem, ptr), offsets);
        }
    }
}