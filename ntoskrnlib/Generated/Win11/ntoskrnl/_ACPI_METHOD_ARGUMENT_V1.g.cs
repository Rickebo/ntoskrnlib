#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ACPI_METHOD_ARGUMENT_V1
    {
        [FieldOffset(0)]
        public ushort Type;
        [FieldOffset(2)]
        public ushort DataLength;
        [FieldOffset(4)]
        public uint Argument;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Data;
    }
}