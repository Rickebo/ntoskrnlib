#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _RTL_HASH_TABLE
    {
        [FieldOffset(0)]
        public uint EntryCount;
        [FieldOffset(4)]
        public uint MaskBitCount;
        [FieldOffset(4)]
        public uint BucketCount;
        [FieldOffset(8)]
        public IntPtr Buckets;
    }
}