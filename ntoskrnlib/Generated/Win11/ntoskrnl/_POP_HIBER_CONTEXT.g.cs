#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 496)]
    public partial struct _POP_HIBER_CONTEXT
    {
        [FieldOffset(0)]
        public byte HiberFlags;
        [FieldOffset(1)]
        public byte WroteHiberFile;
        [FieldOffset(2)]
        public byte KernelPhaseVerificationActive;
        [FieldOffset(3)]
        public byte InitializationFinished;
        [FieldOffset(4)]
        public int NextTableLockHeld;
        [FieldOffset(8)]
        public int BootPhaseFinishedBarrier;
        [FieldOffset(12)]
        public int KernelResumeFinishedBarrier;
        [FieldOffset(16)]
        public int HvCaptureReadyBarrier;
        [FieldOffset(20)]
        public int HvCaptureCompletedBarrier;
        [FieldOffset(24)]
        public byte MapFrozen;
        [FieldOffset(32)]
        public _RTL_BITMAP BootRestoredPagesMap;
        [FieldOffset(48)]
        public _RTL_BITMAP DiscardMap;
        [FieldOffset(48)]
        public _RTL_BITMAP KernelPhaseMap;
        [FieldOffset(64)]
        public _RTL_BITMAP BootPhaseMap;
        [FieldOffset(80)]
        public _LIST_ENTRY ClonedRanges;
        [FieldOffset(96)]
        public uint ClonedRangeCount;
        [FieldOffset(104)]
        public ulong ClonedPageCount;
        [FieldOffset(112)]
        public IntPtr CurrentMap;
        [FieldOffset(120)]
        public IntPtr NextCloneRange;
        [FieldOffset(128)]
        public ulong NextPreserve;
        [FieldOffset(136)]
        public IntPtr LoaderMdl;
        [FieldOffset(144)]
        public IntPtr AllocatedMdl;
        [FieldOffset(152)]
        public ulong PagesOut;
        [FieldOffset(160)]
        public IntPtr IoPages;
        [FieldOffset(168)]
        public uint IoPagesCount;
        [FieldOffset(176)]
        public IntPtr CurrentMcb;
        [FieldOffset(184)]
        public IntPtr DumpStack;
        [FieldOffset(192)]
        public IntPtr WakeState;
        [FieldOffset(200)]
        public uint IoProgress;
        [FieldOffset(204)]
        public int Status;
        [FieldOffset(208)]
        public uint GraphicsProc;
        [FieldOffset(216)]
        public IntPtr MemoryImage;
        [FieldOffset(224)]
        public IntPtr PerformanceStats;
        [FieldOffset(232)]
        public IntPtr BootLoaderLogMdl;
        [FieldOffset(240)]
        public IntPtr FirmwareRuntimeInformationMdl;
        [FieldOffset(248)]
        public IntPtr FirmwareRuntimeInformationVa;
        [FieldOffset(256)]
        public ulong IumFirmwareRuntimeInformationPageCount;
        [FieldOffset(264)]
        public ulong IumFirmwareRuntimeInformationPfnBase;
        [FieldOffset(272)]
        public IntPtr ResumeContext;
        [FieldOffset(280)]
        public uint ResumeContextPages;
        [FieldOffset(284)]
        public uint SecurePages;
        [FieldOffset(288)]
        public uint ProcessorCount;
        [FieldOffset(296)]
        public IntPtr ProcessorContext;
        [FieldOffset(304)]
        public IntPtr ProdConsBuffer;
        [FieldOffset(312)]
        public uint ProdConsSize;
        [FieldOffset(316)]
        public uint MaxDataPages;
        [FieldOffset(320)]
        public IntPtr ExtraBuffer;
        [FieldOffset(328)]
        public ulong ExtraBufferSize;
        [FieldOffset(336)]
        public IntPtr ExtraMapVa;
        [FieldOffset(344)]
        public ulong BitlockerKeyPFN;
        [FieldOffset(352)]
        public _POP_IO_INFO IoInfo;
        [FieldOffset(464)]
        public IntPtr IoChecksums;
        [FieldOffset(472)]
        public ulong IoChecksumsSize;
        [FieldOffset(480)]
        public uint HardwareConfigurationSignature;
        [FieldOffset(484)]
        public byte IumEnabled;
        [FieldOffset(485)]
        public byte SecureBoot;
        [FieldOffset(486)]
        public byte DisableCompressionCallbacks;
        [FieldOffset(487)]
        public byte LZ4BootPhaseEnabled;
        [FieldOffset(488)]
        public byte LZ4KernelPhaseEnabled;
        [FieldOffset(489)]
        public byte EnableVpciHibernationCallbacks;
    }
}