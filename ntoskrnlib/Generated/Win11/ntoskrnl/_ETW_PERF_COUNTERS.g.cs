#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ETW_PERF_COUNTERS
    {
        [FieldOffset(0)]
        public int TotalActiveSessions;
        [FieldOffset(4)]
        public int TotalBufferMemoryNonPagedPool;
        [FieldOffset(8)]
        public int TotalBufferMemoryPagedPool;
        [FieldOffset(12)]
        public int TotalGuidsEnabled;
        [FieldOffset(16)]
        public int TotalGuidsNotEnabled;
        [FieldOffset(20)]
        public int TotalGuidsPreEnabled;
    }
}