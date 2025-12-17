#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 336)]
    public partial struct _KSR_FIRMWARE_INFORMATION
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public _KSR_CAPABILITIES DownlevelCapabilities;
        [FieldOffset(8)]
        public _UNICODE_STRING EfiVersionString;
        [FieldOffset(24)]
        public _VIRTUAL_EFI_RUNTIME_SERVICES EfiRuntimeServices;
        [FieldOffset(136)]
        public IntPtr EfiMemoryMap;
        [FieldOffset(144)]
        public uint EfiMemoryMapSize;
        [FieldOffset(148)]
        public uint EfiMemoryMapDescriptorSize;
        [FieldOffset(152)]
        public IntPtr CachingRequirements;
        [FieldOffset(160)]
        public uint CachingRequirementsCount;
        [FieldOffset(168)]
        public IntPtr Smbios;
        [FieldOffset(176)]
        public IntPtr DisplayContext;
        [FieldOffset(184)]
        public IntPtr SecureBootPolicy;
        [FieldOffset(192)]
        public uint SecureBootPolicySize;
        [FieldOffset(200)]
        public DEBUG_MEMORY_REQUIREMENTS DebugDeviceMemory;
        [FieldOffset(232)]
        public uint SoftRestartCount;
        [FieldOffset(240)]
        public IntPtr CodeIntegrityPolicy;
        [FieldOffset(248)]
        public uint CodeIntegrityPolicySize;
        [FieldOffset(256)]
        public IntPtr EfiMemoryAttributes;
        [FieldOffset(264)]
        public IntPtr Esrt;
        [FieldOffset(272)]
        public uint EsrtSize;
        [FieldOffset(280)]
        public IntPtr CodeIntegrityPolicyHash;
        [FieldOffset(288)]
        public uint CodeIntegrityPolicyHashSize;
        [FieldOffset(296)]
        public IntPtr CodeIntegrityPolicyOriginalHash;
        [FieldOffset(304)]
        public uint CodeIntegrityPolicyOriginalHashSize;
        [FieldOffset(312)]
        public IntPtr BadPageRanges;
        [FieldOffset(320)]
        public uint BadPageRangeCount;
        [FieldOffset(324)]
        public _KSR_CAPABILITIES Capabilities;
        [FieldOffset(328)]
        public _KSR_FLAGS Flags;
    }
}