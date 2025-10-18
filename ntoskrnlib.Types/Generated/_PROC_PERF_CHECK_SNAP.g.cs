using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _PROC_PERF_CHECK_SNAP
{
    [FieldOffset(0)]
    public ulong Time;
    [FieldOffset(8)]
    public ulong Active;
    [FieldOffset(16)]
    public ulong Stall;
    [FieldOffset(24)]
    public ulong FrequencyScaledActive;
    [FieldOffset(32)]
    public ulong PerformanceScaledActive;
    [FieldOffset(40)]
    public ulong PerformanceScaledKernelActive;
    [FieldOffset(48)]
    public uint ResponsivenessEvents;
}
