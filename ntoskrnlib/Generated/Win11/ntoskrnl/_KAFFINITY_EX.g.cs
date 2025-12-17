#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 264)]
    public partial struct _KAFFINITY_EX
    {
        [FieldOffset(0)]
        public ushort Count;
        [FieldOffset(2)]
        public ushort Size;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] Bitmap;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ulong[] StaticBitmap;
    }
}