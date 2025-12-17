#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _DIRTY_PAGE_THRESHOLDS
    {
        [FieldOffset(0)]
        public ulong DirtyPageThreshold;
        [FieldOffset(8)]
        public ulong DirtyPageThresholdTop;
        [FieldOffset(16)]
        public ulong DirtyPageThresholdBottom;
        [FieldOffset(24)]
        public uint DirtyPageTarget;
        [FieldOffset(32)]
        public ulong AggregateAvailablePages;
        [FieldOffset(40)]
        public ulong AggregateDirtyPages;
        [FieldOffset(48)]
        public uint AvailableHistory;
    }
}