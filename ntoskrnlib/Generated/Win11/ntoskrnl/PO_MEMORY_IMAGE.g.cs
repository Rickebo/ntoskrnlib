#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1240)]
    public partial struct PO_MEMORY_IMAGE
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint ImageType;
        [FieldOffset(8)]
        public uint CheckSum;
        [FieldOffset(12)]
        public uint LengthSelf;
        [FieldOffset(16)]
        public ulong PageSelf;
        [FieldOffset(24)]
        public uint PageSize;
        [FieldOffset(32)]
        public _LARGE_INTEGER SystemTime;
        [FieldOffset(40)]
        public ulong InterruptTime;
        [FieldOffset(48)]
        public ulong FeatureFlags;
        [FieldOffset(56)]
        public byte HiberFlags;
        [FieldOffset(57)]
        public byte HiberSimulateFlags;
        [FieldOffset(58)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] spare;
        [FieldOffset(60)]
        public uint NoHiberPtes;
        [FieldOffset(64)]
        public ulong HiberVa;
        [FieldOffset(72)]
        public uint RestoredPagesBitmapSize;
        [FieldOffset(76)]
        public uint RestoredPagesBitmapBitmapCheck;
        [FieldOffset(80)]
        public uint WakeCheck;
        [FieldOffset(88)]
        public ulong NumPagesForLoader;
        [FieldOffset(96)]
        public ulong FirstSecureRestorePage;
        [FieldOffset(104)]
        public ulong FirstBootRestorePage;
        [FieldOffset(112)]
        public ulong FirstKernelRestorePage;
        [FieldOffset(120)]
        public ulong FirstChecksumRestorePage;
        [FieldOffset(128)]
        public ulong NoChecksumEntries;
        [FieldOffset(136)]
        public _PO_HIBER_PERF PerfInfo;
        [FieldOffset(880)]
        public uint FirmwareRuntimeInformationPages;
        [FieldOffset(888)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] FirmwareRuntimeInformation;
        [FieldOffset(896)]
        public ulong IumFirmwareRuntimeInformationPageCount;
        [FieldOffset(904)]
        public ulong IumFirmwareRuntimeInformationPfnBase;
        [FieldOffset(912)]
        public uint SpareUlong;
        [FieldOffset(916)]
        public uint NoBootLoaderLogPages;
        [FieldOffset(920)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public ulong[] BootLoaderLogPages;
        [FieldOffset(1112)]
        public uint NotUsed;
        [FieldOffset(1116)]
        public uint ResumeContextCheck;
        [FieldOffset(1120)]
        public uint ResumeContextPages;
        [FieldOffset(1124)]
        public uint Hiberboot;
        [FieldOffset(1124)]
        public uint SecureLaunched;
        [FieldOffset(1124)]
        public uint SecureBoot;
        [FieldOffset(1124)]
        public uint Fasr;
        [FieldOffset(1124)]
        public uint HiberResumeXhciHandoffSkip;
        [FieldOffset(1124)]
        public uint InitializeUSBCore;
        [FieldOffset(1124)]
        public uint ValidUSBCoreId;
        [FieldOffset(1124)]
        public uint SkipMemoryMapValidation;
        [FieldOffset(1124)]
        public uint SuppressResumePrompt;
        [FieldOffset(1124)]
        public uint Reserved;
        [FieldOffset(1128)]
        public ulong HvPageTableRoot;
        [FieldOffset(1136)]
        public ulong HvEntryPoint;
        [FieldOffset(1144)]
        public ulong HvReservedTransitionAddress;
        [FieldOffset(1152)]
        public ulong HvReservedTransitionAddressSize;
        [FieldOffset(1160)]
        public ulong BootFlags;
        [FieldOffset(1168)]
        public ulong RestoreProcessorStateRoutine;
        [FieldOffset(1176)]
        public ulong HighestPhysicalPage;
        [FieldOffset(1184)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] BitlockerKeyPfns;
        [FieldOffset(1216)]
        public uint HardwareSignature;
        [FieldOffset(1224)]
        public _LARGE_INTEGER SMBiosTablePhysicalAddress;
        [FieldOffset(1232)]
        public uint SMBiosTableLength;
        [FieldOffset(1236)]
        public byte SMBiosMajorVersion;
        [FieldOffset(1237)]
        public byte SMBiosMinorVersion;
        [FieldOffset(1238)]
        public byte USBCoreId;
    }
}