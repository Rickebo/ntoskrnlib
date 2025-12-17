#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _PEP_ACPI_RESOURCE_FLAGS
    {
        [FieldOffset(0)]
        public uint AsULong;
        [FieldOffset(0)]
        public uint Shared;
        [FieldOffset(0)]
        public uint Wake;
        [FieldOffset(0)]
        public uint ResourceUsage;
        [FieldOffset(0)]
        public uint SlaveMode;
        [FieldOffset(0)]
        public uint AddressingMode;
        [FieldOffset(0)]
        public uint SharedMode;
        [FieldOffset(0)]
        public uint Reserved;
    }
}