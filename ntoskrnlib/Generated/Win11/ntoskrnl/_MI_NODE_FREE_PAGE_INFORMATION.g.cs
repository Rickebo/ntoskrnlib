#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1280)]
    public partial struct _MI_NODE_FREE_PAGE_INFORMATION
    {
        [FieldOffset(0)]
        public uint PageColorHand;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] FreeCount;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] FreeZeroCountByAttribute;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] FreePageListHeadsBitmap;
        [FieldOffset(384)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public ulong[] FreePageListHeadsBitmapBuffer;
        [FieldOffset(896)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] LargePageFreeCountHiLow;
        [FieldOffset(928)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] LargePageCount;
        [FieldOffset(992)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] LargePageEntries;
    }
}