#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ETW_SESSION_PERF_COUNTERS
    {
        [FieldOffset(0)]
        public int BufferMemoryPagedPool;
        [FieldOffset(4)]
        public int BufferMemoryNonPagedPool;
        [FieldOffset(8)]
        public ulong EventsLoggedCount;
        [FieldOffset(16)]
        public int EventsLost;
        [FieldOffset(20)]
        public int NumConsumers;
    }
}