#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _RTL_BALANCED_LINKS
    {
        [FieldOffset(0)]
        public IntPtr Parent;
        [FieldOffset(8)]
        public IntPtr LeftChild;
        [FieldOffset(16)]
        public IntPtr RightChild;
        [FieldOffset(24)]
        public sbyte Balance;
        [FieldOffset(25)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Reserved;
    }
}