#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MI_PAGING_FILE_SPACE_BITMAPS
    {
        [FieldOffset(0)]
        public uint RefCount;
        [FieldOffset(0)]
        public IntPtr Anchor;
        [FieldOffset(8)]
        public _RTL_BITMAP AllocationBitmap;
        [FieldOffset(24)]
        public _RTL_BITMAP ReservationBitmap;
        [FieldOffset(24)]
        public _RTL_BITMAP EvictedBitmap;
    }
}