#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_DLL_OVERFLOW_AREA
    {
        [FieldOffset(0)]
        public IntPtr RangeStart;
        [FieldOffset(8)]
        public IntPtr NextVa;
        [FieldOffset(16)]
        public IntPtr RangeStartAbove2gb;
        [FieldOffset(24)]
        public IntPtr NextVaAbove2gb;
    }
}