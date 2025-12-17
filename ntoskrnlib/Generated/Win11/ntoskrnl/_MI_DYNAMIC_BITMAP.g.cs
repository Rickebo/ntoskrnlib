#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MI_DYNAMIC_BITMAP
    {
        [FieldOffset(0)]
        public _RTL_BITMAP_EX Bitmap;
        [FieldOffset(16)]
        public ulong MaximumSize;
        [FieldOffset(24)]
        public ulong Hint;
        [FieldOffset(32)]
        public IntPtr BaseVa;
        [FieldOffset(40)]
        public ulong SizeTopDown;
        [FieldOffset(48)]
        public ulong HintTopDown;
        [FieldOffset(56)]
        public IntPtr BaseVaTopDown;
        [FieldOffset(64)]
        public int SpinLock;
    }
}