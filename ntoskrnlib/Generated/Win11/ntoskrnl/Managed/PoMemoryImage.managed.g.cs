using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!PO_MEMORY_IMAGE")]
    public sealed class PoMemoryImage : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint ImageType { get => ReadHere<uint>(nameof(ImageType)); set => WriteHere(nameof(ImageType), value); }

        [Offset(8UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        [Offset(12UL)]
        public uint LengthSelf { get => ReadHere<uint>(nameof(LengthSelf)); set => WriteHere(nameof(LengthSelf), value); }

        [Offset(16UL)]
        public ulong PageSelf { get => ReadHere<ulong>(nameof(PageSelf)); set => WriteHere(nameof(PageSelf), value); }

        [Offset(24UL)]
        public uint PageSize { get => ReadHere<uint>(nameof(PageSize)); set => WriteHere(nameof(PageSize), value); }

        [Offset(32UL)]
        public LargeInteger SystemTime { get => ReadStructure<LargeInteger>(nameof(SystemTime)); set => WriteStructure(nameof(SystemTime), value); }

        [Offset(40UL)]
        public ulong InterruptTime { get => ReadHere<ulong>(nameof(InterruptTime)); set => WriteHere(nameof(InterruptTime), value); }

        [Offset(48UL)]
        public ulong FeatureFlags { get => ReadHere<ulong>(nameof(FeatureFlags)); set => WriteHere(nameof(FeatureFlags), value); }

        [Offset(56UL)]
        public byte HiberFlags { get => ReadHere<byte>(nameof(HiberFlags)); set => WriteHere(nameof(HiberFlags), value); }

        [Offset(57UL)]
        public byte HiberSimulateFlags { get => ReadHere<byte>(nameof(HiberSimulateFlags)); set => WriteHere(nameof(HiberSimulateFlags), value); }

        [Offset(58UL)]
        [Length(2)]
        public DynamicArray spare { get => ReadStructure<DynamicArray>(nameof(spare)); set => WriteStructure(nameof(spare), value); }

        [Offset(60UL)]
        public uint NoHiberPtes { get => ReadHere<uint>(nameof(NoHiberPtes)); set => WriteHere(nameof(NoHiberPtes), value); }

        [Offset(64UL)]
        public ulong HiberVa { get => ReadHere<ulong>(nameof(HiberVa)); set => WriteHere(nameof(HiberVa), value); }

        [Offset(72UL)]
        public uint RestoredPagesBitmapSize { get => ReadHere<uint>(nameof(RestoredPagesBitmapSize)); set => WriteHere(nameof(RestoredPagesBitmapSize), value); }

        [Offset(76UL)]
        public uint RestoredPagesBitmapBitmapCheck { get => ReadHere<uint>(nameof(RestoredPagesBitmapBitmapCheck)); set => WriteHere(nameof(RestoredPagesBitmapBitmapCheck), value); }

        [Offset(80UL)]
        public uint WakeCheck { get => ReadHere<uint>(nameof(WakeCheck)); set => WriteHere(nameof(WakeCheck), value); }

        [Offset(88UL)]
        public ulong NumPagesForLoader { get => ReadHere<ulong>(nameof(NumPagesForLoader)); set => WriteHere(nameof(NumPagesForLoader), value); }

        [Offset(96UL)]
        public ulong FirstSecureRestorePage { get => ReadHere<ulong>(nameof(FirstSecureRestorePage)); set => WriteHere(nameof(FirstSecureRestorePage), value); }

        [Offset(104UL)]
        public ulong FirstBootRestorePage { get => ReadHere<ulong>(nameof(FirstBootRestorePage)); set => WriteHere(nameof(FirstBootRestorePage), value); }

        [Offset(112UL)]
        public ulong FirstKernelRestorePage { get => ReadHere<ulong>(nameof(FirstKernelRestorePage)); set => WriteHere(nameof(FirstKernelRestorePage), value); }

        [Offset(120UL)]
        public ulong FirstChecksumRestorePage { get => ReadHere<ulong>(nameof(FirstChecksumRestorePage)); set => WriteHere(nameof(FirstChecksumRestorePage), value); }

        [Offset(128UL)]
        public ulong NoChecksumEntries { get => ReadHere<ulong>(nameof(NoChecksumEntries)); set => WriteHere(nameof(NoChecksumEntries), value); }

        [Offset(136UL)]
        public PoHiberPerf PerfInfo { get => ReadStructure<PoHiberPerf>(nameof(PerfInfo)); set => WriteStructure(nameof(PerfInfo), value); }

        [Offset(880UL)]
        public uint FirmwareRuntimeInformationPages { get => ReadHere<uint>(nameof(FirmwareRuntimeInformationPages)); set => WriteHere(nameof(FirmwareRuntimeInformationPages), value); }

        [Offset(888UL)]
        [Length(1)]
        public DynamicArray FirmwareRuntimeInformation { get => ReadStructure<DynamicArray>(nameof(FirmwareRuntimeInformation)); set => WriteStructure(nameof(FirmwareRuntimeInformation), value); }

        [Offset(896UL)]
        public ulong IumFirmwareRuntimeInformationPageCount { get => ReadHere<ulong>(nameof(IumFirmwareRuntimeInformationPageCount)); set => WriteHere(nameof(IumFirmwareRuntimeInformationPageCount), value); }

        [Offset(904UL)]
        public ulong IumFirmwareRuntimeInformationPfnBase { get => ReadHere<ulong>(nameof(IumFirmwareRuntimeInformationPfnBase)); set => WriteHere(nameof(IumFirmwareRuntimeInformationPfnBase), value); }

        [Offset(912UL)]
        public uint SpareUlong { get => ReadHere<uint>(nameof(SpareUlong)); set => WriteHere(nameof(SpareUlong), value); }

        [Offset(916UL)]
        public uint NoBootLoaderLogPages { get => ReadHere<uint>(nameof(NoBootLoaderLogPages)); set => WriteHere(nameof(NoBootLoaderLogPages), value); }

        [Offset(920UL)]
        [Length(24)]
        public DynamicArray BootLoaderLogPages { get => ReadStructure<DynamicArray>(nameof(BootLoaderLogPages)); set => WriteStructure(nameof(BootLoaderLogPages), value); }

        [Offset(1112UL)]
        public uint NotUsed { get => ReadHere<uint>(nameof(NotUsed)); set => WriteHere(nameof(NotUsed), value); }

        [Offset(1116UL)]
        public uint ResumeContextCheck { get => ReadHere<uint>(nameof(ResumeContextCheck)); set => WriteHere(nameof(ResumeContextCheck), value); }

        [Offset(1120UL)]
        public uint ResumeContextPages { get => ReadHere<uint>(nameof(ResumeContextPages)); set => WriteHere(nameof(ResumeContextPages), value); }

        [Offset(1124UL)]
        public uint Hiberboot { get => ReadHere<uint>(nameof(Hiberboot)); set => WriteHere(nameof(Hiberboot), value); }

        [Offset(1124UL)]
        public uint SecureLaunched { get => ReadHere<uint>(nameof(SecureLaunched)); set => WriteHere(nameof(SecureLaunched), value); }

        [Offset(1124UL)]
        public uint SecureBoot { get => ReadHere<uint>(nameof(SecureBoot)); set => WriteHere(nameof(SecureBoot), value); }

        [Offset(1124UL)]
        public uint Fasr { get => ReadHere<uint>(nameof(Fasr)); set => WriteHere(nameof(Fasr), value); }

        [Offset(1124UL)]
        public uint HiberResumeXhciHandoffSkip { get => ReadHere<uint>(nameof(HiberResumeXhciHandoffSkip)); set => WriteHere(nameof(HiberResumeXhciHandoffSkip), value); }

        [Offset(1124UL)]
        public uint InitializeUSBCore { get => ReadHere<uint>(nameof(InitializeUSBCore)); set => WriteHere(nameof(InitializeUSBCore), value); }

        [Offset(1124UL)]
        public uint ValidUSBCoreId { get => ReadHere<uint>(nameof(ValidUSBCoreId)); set => WriteHere(nameof(ValidUSBCoreId), value); }

        [Offset(1124UL)]
        public uint SkipMemoryMapValidation { get => ReadHere<uint>(nameof(SkipMemoryMapValidation)); set => WriteHere(nameof(SkipMemoryMapValidation), value); }

        [Offset(1124UL)]
        public uint SuppressResumePrompt { get => ReadHere<uint>(nameof(SuppressResumePrompt)); set => WriteHere(nameof(SuppressResumePrompt), value); }

        [Offset(1124UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(1128UL)]
        public ulong HvPageTableRoot { get => ReadHere<ulong>(nameof(HvPageTableRoot)); set => WriteHere(nameof(HvPageTableRoot), value); }

        [Offset(1136UL)]
        public ulong HvEntryPoint { get => ReadHere<ulong>(nameof(HvEntryPoint)); set => WriteHere(nameof(HvEntryPoint), value); }

        [Offset(1144UL)]
        public ulong HvReservedTransitionAddress { get => ReadHere<ulong>(nameof(HvReservedTransitionAddress)); set => WriteHere(nameof(HvReservedTransitionAddress), value); }

        [Offset(1152UL)]
        public ulong HvReservedTransitionAddressSize { get => ReadHere<ulong>(nameof(HvReservedTransitionAddressSize)); set => WriteHere(nameof(HvReservedTransitionAddressSize), value); }

        [Offset(1160UL)]
        public ulong BootFlags { get => ReadHere<ulong>(nameof(BootFlags)); set => WriteHere(nameof(BootFlags), value); }

        [Offset(1168UL)]
        public ulong RestoreProcessorStateRoutine { get => ReadHere<ulong>(nameof(RestoreProcessorStateRoutine)); set => WriteHere(nameof(RestoreProcessorStateRoutine), value); }

        [Offset(1176UL)]
        public ulong HighestPhysicalPage { get => ReadHere<ulong>(nameof(HighestPhysicalPage)); set => WriteHere(nameof(HighestPhysicalPage), value); }

        [Offset(1184UL)]
        [Length(4)]
        public DynamicArray BitlockerKeyPfns { get => ReadStructure<DynamicArray>(nameof(BitlockerKeyPfns)); set => WriteStructure(nameof(BitlockerKeyPfns), value); }

        [Offset(1216UL)]
        public uint HardwareSignature { get => ReadHere<uint>(nameof(HardwareSignature)); set => WriteHere(nameof(HardwareSignature), value); }

        [Offset(1224UL)]
        public LargeInteger SMBiosTablePhysicalAddress { get => ReadStructure<LargeInteger>(nameof(SMBiosTablePhysicalAddress)); set => WriteStructure(nameof(SMBiosTablePhysicalAddress), value); }

        [Offset(1232UL)]
        public uint SMBiosTableLength { get => ReadHere<uint>(nameof(SMBiosTableLength)); set => WriteHere(nameof(SMBiosTableLength), value); }

        [Offset(1236UL)]
        public byte SMBiosMajorVersion { get => ReadHere<byte>(nameof(SMBiosMajorVersion)); set => WriteHere(nameof(SMBiosMajorVersion), value); }

        [Offset(1237UL)]
        public byte SMBiosMinorVersion { get => ReadHere<byte>(nameof(SMBiosMinorVersion)); set => WriteHere(nameof(SMBiosMinorVersion), value); }

        [Offset(1238UL)]
        public byte USBCoreId { get => ReadHere<byte>(nameof(USBCoreId)); set => WriteHere(nameof(USBCoreId), value); }

        public PoMemoryImage(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoMemoryImage>();
        }
    }
}