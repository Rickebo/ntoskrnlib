#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _FREE_DISPLAY
    {
        [FieldOffset(0)]
        public uint RealVectorSize;
        [FieldOffset(4)]
        public uint Hint;
        [FieldOffset(8)]
        public _RTL_BITMAP Display;
    }
}