#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _PEP_ACPI_IO_MEMORY_RESOURCE
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public byte Information;
        [FieldOffset(8)]
        public _LARGE_INTEGER MinimumAddress;
        [FieldOffset(16)]
        public _LARGE_INTEGER MaximumAddress;
        [FieldOffset(24)]
        public uint Alignment;
        [FieldOffset(28)]
        public uint Length;
    }
}