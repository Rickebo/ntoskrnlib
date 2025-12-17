#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _LEAP_SECOND_DATA
    {
        [FieldOffset(0)]
        public byte Enabled;
        [FieldOffset(4)]
        public uint Count;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _LARGE_INTEGER[] Data;
    }
}