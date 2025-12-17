#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4160)]
    public partial struct _RTL_DYNAMIC_LOOKASIDE
    {
        [FieldOffset(0)]
        public ulong EnabledBucketBitmap;
        [FieldOffset(8)]
        public uint BucketCount;
        [FieldOffset(12)]
        public uint ActiveBucketCount;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _RTL_LOOKASIDE[] Buckets;
    }
}