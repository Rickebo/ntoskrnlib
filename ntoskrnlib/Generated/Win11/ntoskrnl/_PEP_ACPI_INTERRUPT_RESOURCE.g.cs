#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _PEP_ACPI_INTERRUPT_RESOURCE
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint InterruptType;
        [FieldOffset(8)]
        public uint InterruptPolarity;
        [FieldOffset(12)]
        public _PEP_ACPI_RESOURCE_FLAGS Flags;
        [FieldOffset(16)]
        public byte Count;
        [FieldOffset(24)]
        public IntPtr Pins;
    }
}