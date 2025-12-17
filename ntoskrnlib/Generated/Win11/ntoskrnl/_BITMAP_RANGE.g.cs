#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _BITMAP_RANGE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public long BasePage;
        [FieldOffset(24)]
        public uint FirstDirtyPage;
        [FieldOffset(28)]
        public uint LastDirtyPage;
        [FieldOffset(32)]
        public uint DirtyPages;
        [FieldOffset(40)]
        public IntPtr Bitmap;
    }
}