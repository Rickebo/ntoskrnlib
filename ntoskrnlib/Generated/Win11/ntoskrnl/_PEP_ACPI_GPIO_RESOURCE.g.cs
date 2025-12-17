#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _PEP_ACPI_GPIO_RESOURCE
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public _PEP_ACPI_RESOURCE_FLAGS Flags;
        [FieldOffset(8)]
        public uint InterruptType;
        [FieldOffset(12)]
        public uint InterruptPolarity;
        [FieldOffset(16)]
        public uint PinConfig;
        [FieldOffset(20)]
        public uint IoRestrictionType;
        [FieldOffset(24)]
        public ushort DriveStrength;
        [FieldOffset(26)]
        public ushort DebounceTimeout;
        [FieldOffset(32)]
        public IntPtr PinTable;
        [FieldOffset(40)]
        public ushort PinCount;
        [FieldOffset(42)]
        public byte ResourceSourceIndex;
        [FieldOffset(48)]
        public IntPtr ResourceSourceName;
        [FieldOffset(56)]
        public IntPtr VendorData;
        [FieldOffset(64)]
        public ushort VendorDataLength;
    }
}