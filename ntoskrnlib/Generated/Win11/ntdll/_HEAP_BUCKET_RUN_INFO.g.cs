#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HEAP_BUCKET_RUN_INFO
    {
        [FieldOffset(0)]
        public uint Bucket;
        [FieldOffset(4)]
        public uint RunLength;
        [FieldOffset(0)]
        public long Aggregate64;
    }
}