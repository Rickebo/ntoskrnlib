#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _PEP_ACPI_SPB_RESOURCE
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public _PEP_ACPI_RESOURCE_FLAGS Flags;
        [FieldOffset(8)]
        public ushort TypeSpecificFlags;
        [FieldOffset(10)]
        public byte ResourceSourceIndex;
        [FieldOffset(16)]
        public IntPtr ResourceSourceName;
        [FieldOffset(24)]
        public IntPtr VendorData;
        [FieldOffset(32)]
        public ushort VendorDataLength;
    }
}