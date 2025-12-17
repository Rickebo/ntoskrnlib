#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _RSDT_32
    {
        [FieldOffset(0)]
        public _DESCRIPTION_HEADER Header;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] Tables;
    }
}