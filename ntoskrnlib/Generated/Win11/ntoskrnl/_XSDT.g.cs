#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial struct _XSDT
    {
        [FieldOffset(0)]
        public _DESCRIPTION_HEADER Header;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _LARGE_INTEGER[] Tables;
    }
}