#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_BALANCED_NODE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] Children;
        [FieldOffset(0)]
        public IntPtr Left;
        [FieldOffset(8)]
        public IntPtr Right;
        [FieldOffset(16)]
        public byte Red;
        [FieldOffset(16)]
        public byte Balance;
        [FieldOffset(16)]
        public ulong ParentValue;
    }
}