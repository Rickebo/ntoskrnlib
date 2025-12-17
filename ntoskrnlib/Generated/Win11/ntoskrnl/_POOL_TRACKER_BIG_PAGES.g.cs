#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _POOL_TRACKER_BIG_PAGES
    {
        [FieldOffset(0)]
        public ulong Va;
        [FieldOffset(8)]
        public uint Key;
        [FieldOffset(12)]
        public uint Pattern;
        [FieldOffset(12)]
        public uint PoolFlags;
        [FieldOffset(12)]
        public uint SlushSize;
        [FieldOffset(16)]
        public ulong NumberOfBytes;
        [FieldOffset(24)]
        public IntPtr ProcessBilled;
    }
}