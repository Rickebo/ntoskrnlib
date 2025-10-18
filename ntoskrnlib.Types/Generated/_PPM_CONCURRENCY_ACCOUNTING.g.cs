using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=336)]
public struct _PPM_CONCURRENCY_ACCOUNTING
{
    [FieldOffset(0)]
    public ulong Lock;
    [FieldOffset(8)]
    public uint Processors;
    [FieldOffset(12)]
    public uint ActiveProcessors;
    [FieldOffset(16)]
    public ulong LastUpdateTime;
    [FieldOffset(24)]
    public ulong TotalTime;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=37)]
    public ulong[] IdleIntervalStats;
    [FieldOffset(328)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public ulong[] AccumulatedTime;
}
