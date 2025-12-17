#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HEAP_BUCKET_COUNTERS
    {
        [FieldOffset(0)]
        public uint TotalBlocks;
        [FieldOffset(4)]
        public uint SubSegmentCounts;
        [FieldOffset(0)]
        public long Aggregate64;
    }
}