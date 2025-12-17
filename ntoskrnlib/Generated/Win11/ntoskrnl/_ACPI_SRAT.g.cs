#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _ACPI_SRAT
    {
        [FieldOffset(0)]
        public _DESCRIPTION_HEADER Header;
        [FieldOffset(36)]
        public uint TableRevision;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Reserved;
    }
}