#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public partial struct _WHEA_ERROR_RECORD
    {
        [FieldOffset(0)]
        public _WHEA_ERROR_RECORD_HEADER Header;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR[] SectionDescriptor;
    }
}