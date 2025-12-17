#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _EFI_FIRMWARE_INFORMATION
    {
        [FieldOffset(0)]
        public uint FirmwareVersion;
        [FieldOffset(8)]
        public IntPtr VirtualEfiRuntimeServices;
        [FieldOffset(16)]
        public int SetVirtualAddressMapStatus;
        [FieldOffset(20)]
        public uint MissedMappingsCount;
        [FieldOffset(24)]
        public _LIST_ENTRY FirmwareResourceList;
        [FieldOffset(40)]
        public IntPtr EfiMemoryMap;
        [FieldOffset(48)]
        public uint EfiMemoryMapSize;
        [FieldOffset(52)]
        public uint EfiMemoryMapDescriptorSize;
    }
}