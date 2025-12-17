#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _VACB
    {
        [FieldOffset(0)]
        public IntPtr BaseAddress;
        [FieldOffset(8)]
        public IntPtr SharedCacheMap;
        [FieldOffset(16)]
        public _unnamed_tag_ Overlay;
        [FieldOffset(32)]
        public IntPtr ArrayHead;
    }
}