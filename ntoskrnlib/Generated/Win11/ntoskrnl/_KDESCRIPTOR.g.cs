#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KDESCRIPTOR
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] Pad;
        [FieldOffset(6)]
        public ushort Limit;
        [FieldOffset(8)]
        public IntPtr Base;
    }
}