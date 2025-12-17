using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSR_FIRMWARE_INFORMATION")]
    public sealed class KsrFirmwareInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public KsrCapabilities DownlevelCapabilities { get => ReadStructure<KsrCapabilities>(nameof(DownlevelCapabilities)); set => WriteStructure(nameof(DownlevelCapabilities), value); }

        [Offset(8UL)]
        public UnicodeString EfiVersionString { get => ReadStructure<UnicodeString>(nameof(EfiVersionString)); set => WriteStructure(nameof(EfiVersionString), value); }

        [Offset(24UL)]
        public VirtualEfiRuntimeServices EfiRuntimeServices { get => ReadStructure<VirtualEfiRuntimeServices>(nameof(EfiRuntimeServices)); set => WriteStructure(nameof(EfiRuntimeServices), value); }

        [Offset(136UL)]
        public IntPtr EfiMemoryMap { get => ReadHere<IntPtr>(nameof(EfiMemoryMap)); set => WriteHere(nameof(EfiMemoryMap), value); }

        [Offset(144UL)]
        public uint EfiMemoryMapSize { get => ReadHere<uint>(nameof(EfiMemoryMapSize)); set => WriteHere(nameof(EfiMemoryMapSize), value); }

        [Offset(148UL)]
        public uint EfiMemoryMapDescriptorSize { get => ReadHere<uint>(nameof(EfiMemoryMapDescriptorSize)); set => WriteHere(nameof(EfiMemoryMapDescriptorSize), value); }

        [Offset(152UL)]
        public IntPtr CachingRequirements { get => ReadHere<IntPtr>(nameof(CachingRequirements)); set => WriteHere(nameof(CachingRequirements), value); }

        [Offset(160UL)]
        public uint CachingRequirementsCount { get => ReadHere<uint>(nameof(CachingRequirementsCount)); set => WriteHere(nameof(CachingRequirementsCount), value); }

        [Offset(168UL)]
        public IntPtr Smbios { get => ReadHere<IntPtr>(nameof(Smbios)); set => WriteHere(nameof(Smbios), value); }

        [Offset(176UL)]
        public IntPtr DisplayContext { get => ReadHere<IntPtr>(nameof(DisplayContext)); set => WriteHere(nameof(DisplayContext), value); }

        [Offset(184UL)]
        public IntPtr SecureBootPolicy { get => ReadHere<IntPtr>(nameof(SecureBootPolicy)); set => WriteHere(nameof(SecureBootPolicy), value); }

        [Offset(192UL)]
        public uint SecureBootPolicySize { get => ReadHere<uint>(nameof(SecureBootPolicySize)); set => WriteHere(nameof(SecureBootPolicySize), value); }

        [Offset(200UL)]
        public DebugMemoryRequirements DebugDeviceMemory { get => ReadStructure<DebugMemoryRequirements>(nameof(DebugDeviceMemory)); set => WriteStructure(nameof(DebugDeviceMemory), value); }

        [Offset(232UL)]
        public uint SoftRestartCount { get => ReadHere<uint>(nameof(SoftRestartCount)); set => WriteHere(nameof(SoftRestartCount), value); }

        [Offset(240UL)]
        public IntPtr CodeIntegrityPolicy { get => ReadHere<IntPtr>(nameof(CodeIntegrityPolicy)); set => WriteHere(nameof(CodeIntegrityPolicy), value); }

        [Offset(248UL)]
        public uint CodeIntegrityPolicySize { get => ReadHere<uint>(nameof(CodeIntegrityPolicySize)); set => WriteHere(nameof(CodeIntegrityPolicySize), value); }

        [Offset(256UL)]
        public IntPtr EfiMemoryAttributes { get => ReadHere<IntPtr>(nameof(EfiMemoryAttributes)); set => WriteHere(nameof(EfiMemoryAttributes), value); }

        [Offset(264UL)]
        public IntPtr Esrt { get => ReadHere<IntPtr>(nameof(Esrt)); set => WriteHere(nameof(Esrt), value); }

        [Offset(272UL)]
        public uint EsrtSize { get => ReadHere<uint>(nameof(EsrtSize)); set => WriteHere(nameof(EsrtSize), value); }

        [Offset(280UL)]
        public IntPtr CodeIntegrityPolicyHash { get => ReadHere<IntPtr>(nameof(CodeIntegrityPolicyHash)); set => WriteHere(nameof(CodeIntegrityPolicyHash), value); }

        [Offset(288UL)]
        public uint CodeIntegrityPolicyHashSize { get => ReadHere<uint>(nameof(CodeIntegrityPolicyHashSize)); set => WriteHere(nameof(CodeIntegrityPolicyHashSize), value); }

        [Offset(296UL)]
        public IntPtr CodeIntegrityPolicyOriginalHash { get => ReadHere<IntPtr>(nameof(CodeIntegrityPolicyOriginalHash)); set => WriteHere(nameof(CodeIntegrityPolicyOriginalHash), value); }

        [Offset(304UL)]
        public uint CodeIntegrityPolicyOriginalHashSize { get => ReadHere<uint>(nameof(CodeIntegrityPolicyOriginalHashSize)); set => WriteHere(nameof(CodeIntegrityPolicyOriginalHashSize), value); }

        [Offset(312UL)]
        public IntPtr BadPageRanges { get => ReadHere<IntPtr>(nameof(BadPageRanges)); set => WriteHere(nameof(BadPageRanges), value); }

        [Offset(320UL)]
        public uint BadPageRangeCount { get => ReadHere<uint>(nameof(BadPageRangeCount)); set => WriteHere(nameof(BadPageRangeCount), value); }

        [Offset(324UL)]
        public KsrCapabilities Capabilities { get => ReadStructure<KsrCapabilities>(nameof(Capabilities)); set => WriteStructure(nameof(Capabilities), value); }

        [Offset(328UL)]
        public KsrFlags Flags { get => ReadStructure<KsrFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        public KsrFirmwareInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsrFirmwareInformation>();
        }
    }
}