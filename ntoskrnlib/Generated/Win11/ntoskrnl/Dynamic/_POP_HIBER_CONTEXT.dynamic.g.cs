using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_HIBER_CONTEXT")]
    public sealed class _POP_HIBER_CONTEXT : DynamicStructure
    {
        public byte HiberFlags { get; }
        public byte WroteHiberFile { get; }
        public byte KernelPhaseVerificationActive { get; }
        public byte InitializationFinished { get; }
        public int NextTableLockHeld { get; }
        public int BootPhaseFinishedBarrier { get; }
        public int KernelResumeFinishedBarrier { get; }
        public int HvCaptureReadyBarrier { get; }
        public int HvCaptureCompletedBarrier { get; }
        public byte MapFrozen { get; }
        public _RTL_BITMAP BootRestoredPagesMap { get; }
        public _RTL_BITMAP DiscardMap { get; }
        public _RTL_BITMAP KernelPhaseMap { get; }
        public _RTL_BITMAP BootPhaseMap { get; }
        public _LIST_ENTRY ClonedRanges { get; }
        public uint ClonedRangeCount { get; }
        public ulong ClonedPageCount { get; }
        public IntPtr CurrentMap { get; }
        public IntPtr NextCloneRange { get; }
        public ulong NextPreserve { get; }
        public IntPtr LoaderMdl { get; }
        public IntPtr AllocatedMdl { get; }
        public ulong PagesOut { get; }
        public IntPtr IoPages { get; }
        public uint IoPagesCount { get; }
        public IntPtr CurrentMcb { get; }
        public IntPtr DumpStack { get; }
        public IntPtr WakeState { get; }
        public uint IoProgress { get; }
        public int Status { get; }
        public uint GraphicsProc { get; }
        public IntPtr MemoryImage { get; }
        public IntPtr PerformanceStats { get; }
        public IntPtr BootLoaderLogMdl { get; }
        public IntPtr FirmwareRuntimeInformationMdl { get; }
        public IntPtr FirmwareRuntimeInformationVa { get; }
        public ulong IumFirmwareRuntimeInformationPageCount { get; }
        public ulong IumFirmwareRuntimeInformationPfnBase { get; }
        public IntPtr ResumeContext { get; }
        public uint ResumeContextPages { get; }
        public uint SecurePages { get; }
        public uint ProcessorCount { get; }
        public IntPtr ProcessorContext { get; }
        public IntPtr ProdConsBuffer { get; }
        public uint ProdConsSize { get; }
        public uint MaxDataPages { get; }
        public IntPtr ExtraBuffer { get; }
        public ulong ExtraBufferSize { get; }
        public IntPtr ExtraMapVa { get; }
        public ulong BitlockerKeyPFN { get; }
        public _POP_IO_INFO IoInfo { get; }
        public IntPtr IoChecksums { get; }
        public ulong IoChecksumsSize { get; }
        public uint HardwareConfigurationSignature { get; }
        public byte IumEnabled { get; }
        public byte SecureBoot { get; }
        public byte DisableCompressionCallbacks { get; }
        public byte LZ4BootPhaseEnabled { get; }
        public byte LZ4KernelPhaseEnabled { get; }
        public byte EnableVpciHibernationCallbacks { get; }

        public _POP_HIBER_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_HIBER_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_HIBER_CONTEXT.HiberFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.WroteHiberFile),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.KernelPhaseVerificationActive),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.InitializationFinished),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.NextTableLockHeld),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.BootPhaseFinishedBarrier),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.KernelResumeFinishedBarrier),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.HvCaptureReadyBarrier),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.HvCaptureCompletedBarrier),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.MapFrozen),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.BootRestoredPagesMap),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.DiscardMap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.KernelPhaseMap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.BootPhaseMap),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ClonedRanges),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ClonedRangeCount),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ClonedPageCount),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.CurrentMap),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.NextCloneRange),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.NextPreserve),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.LoaderMdl),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.AllocatedMdl),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.PagesOut),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IoPages),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IoPagesCount),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.CurrentMcb),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.DumpStack),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.WakeState),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IoProgress),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.Status),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.GraphicsProc),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.MemoryImage),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.PerformanceStats),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.BootLoaderLogMdl),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.FirmwareRuntimeInformationMdl),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.FirmwareRuntimeInformationVa),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IumFirmwareRuntimeInformationPageCount),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IumFirmwareRuntimeInformationPfnBase),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ResumeContext),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ResumeContextPages),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.SecurePages),
                    new ulong[]
                    {
                        284UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ProcessorCount),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ProcessorContext),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ProdConsBuffer),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ProdConsSize),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.MaxDataPages),
                    new ulong[]
                    {
                        316UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ExtraBuffer),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ExtraBufferSize),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.ExtraMapVa),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.BitlockerKeyPFN),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IoInfo),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IoChecksums),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IoChecksumsSize),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.HardwareConfigurationSignature),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.IumEnabled),
                    new ulong[]
                    {
                        484UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.SecureBoot),
                    new ulong[]
                    {
                        485UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.DisableCompressionCallbacks),
                    new ulong[]
                    {
                        486UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.LZ4BootPhaseEnabled),
                    new ulong[]
                    {
                        487UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.LZ4KernelPhaseEnabled),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_POP_HIBER_CONTEXT.EnableVpciHibernationCallbacks),
                    new ulong[]
                    {
                        489UL
                    }
                }
            };
            Register<_POP_HIBER_CONTEXT>((mem, ptr) => new _POP_HIBER_CONTEXT(mem, ptr), offsets);
        }
    }
}