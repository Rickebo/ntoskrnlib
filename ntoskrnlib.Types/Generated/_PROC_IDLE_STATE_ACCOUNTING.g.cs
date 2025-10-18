using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1016)]
public struct _PROC_IDLE_STATE_ACCOUNTING
{
    [FieldOffset(0)]
    public ulong TotalTime;
    [FieldOffset(8)]
    public uint CancelCount;
    [FieldOffset(12)]
    public uint FailureCount;
    [FieldOffset(16)]
    public uint SuccessCount;
    [FieldOffset(20)]
    public uint InvalidBucketIndex;
    [FieldOffset(24)]
    public ulong MinTime;
    [FieldOffset(32)]
    public ulong MaxTime;
    [FieldOffset(40)]
    public _PPM_SELECTION_STATISTICS SelectionStatistics;
    [FieldOffset(184)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=26)]
    public byte[] IdleTimeBuckets;
}
