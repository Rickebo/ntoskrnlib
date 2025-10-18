using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _KSHARED_READY_QUEUE_AFFINITY_STATISTICS
{
    [FieldOffset(0)]
    public ulong AffinitySummary;
}
