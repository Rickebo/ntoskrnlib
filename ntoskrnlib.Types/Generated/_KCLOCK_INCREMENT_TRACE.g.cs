using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _KCLOCK_INCREMENT_TRACE
{
    [FieldOffset(0)]
    public uint ActualIncrement;
    [FieldOffset(4)]
    public uint RequestedIncrement;
    [FieldOffset(8)]
    public ulong InterruptTime;
    [FieldOffset(16)]
    public ulong PerformanceCounter;
    [FieldOffset(24)]
    public byte OneShot;
}
