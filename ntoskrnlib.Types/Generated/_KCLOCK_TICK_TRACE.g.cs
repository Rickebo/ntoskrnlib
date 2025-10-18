using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _KCLOCK_TICK_TRACE
{
    [FieldOffset(0)]
    public ulong PerformanceCounter;
    [FieldOffset(8)]
    public ulong PreInterruptTime;
    [FieldOffset(16)]
    public ulong PostInterruptTime;
    [FieldOffset(24)]
    public ulong TimeStampCounter;
    [FieldOffset(32)]
    public byte IsClockOwner;
}
