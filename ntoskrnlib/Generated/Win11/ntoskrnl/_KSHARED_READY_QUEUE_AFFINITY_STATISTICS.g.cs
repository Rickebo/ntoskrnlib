#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KSHARED_READY_QUEUE_AFFINITY_STATISTICS
    {
        [FieldOffset(0)]
        public ulong AffinitySummary;
    }
}