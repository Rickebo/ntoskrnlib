#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _ACPI_CACHED_TABLE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public _LARGE_INTEGER PhysicalAddress;
        [FieldOffset(24)]
        public _DESCRIPTION_HEADER Header;
    }
}