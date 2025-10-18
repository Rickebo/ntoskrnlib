using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=2)]
public struct _PROC_PERF_LOAD
{
    [FieldOffset(0)]
    public byte BusyPercentage;
    [FieldOffset(1)]
    public byte FrequencyPercentage;
}
