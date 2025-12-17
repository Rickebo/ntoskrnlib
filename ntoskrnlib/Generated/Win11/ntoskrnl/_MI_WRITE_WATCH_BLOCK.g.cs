#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MI_WRITE_WATCH_BLOCK
    {
        [FieldOffset(0)]
        public int Lock;
        [FieldOffset(8)]
        public _RTL_BITMAP_EX BitMap;
    }
}