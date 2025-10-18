using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1304)]
public struct _KCLOCK_TIMER_STATE
{
    [FieldOffset(0)]
    public ulong NextTickDueTime;
    [FieldOffset(8)]
    public uint TimeIncrement;
    [FieldOffset(12)]
    public uint LastRequestedTimeIncrement;
    [FieldOffset(16)]
    public IntPtr OneShotState;
    [FieldOffset(20)]
    public IntPtr ExpectedWakeReason;
    [FieldOffset(24)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=7)]
    public byte[] ClockTimerEntries;
    [FieldOffset(136)]
    public byte ClockActive;
    [FieldOffset(137)]
    public byte ClockArmedForIdle;
    [FieldOffset(140)]
    public uint ClockTickTraceIndex;
    [FieldOffset(144)]
    public uint ClockIncrementTraceIndex;
    [FieldOffset(152)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public byte[] ClockTickTraces;
    [FieldOffset(792)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public byte[] ClockIncrementTraces;
}
