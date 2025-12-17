#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MI_ULTRA_VA_CONTEXT
    {
        [FieldOffset(0)]
        public int Lock;
        [FieldOffset(8)]
        public IntPtr ZeroMapping;
        [FieldOffset(16)]
        public ulong AllocationHintBit;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _RTL_BITMAP_EX[] Bitmap;
        [FieldOffset(56)]
        public uint ConcurrencyMaximum;
        [FieldOffset(60)]
        public int ConcurrencyCount;
    }
}