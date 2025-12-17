#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _XSAVE_AREA_HEADER
    {
        [FieldOffset(0)]
        public ulong Mask;
        [FieldOffset(8)]
        public ulong CompactionMask;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ulong[] Reserved2;
    }
}