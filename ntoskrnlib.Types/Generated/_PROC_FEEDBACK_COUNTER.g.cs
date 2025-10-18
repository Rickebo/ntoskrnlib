using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _PROC_FEEDBACK_COUNTER
{
    [FieldOffset(0)]
    public IntPtr InstantaneousRead;
    [FieldOffset(0)]
    public IntPtr DifferentialRead;
    [FieldOffset(8)]
    public ulong LastActualCount;
    [FieldOffset(16)]
    public ulong LastReferenceCount;
    [FieldOffset(24)]
    public uint CachedValue;
    [FieldOffset(32)]
    public byte Affinitized;
    [FieldOffset(33)]
    public byte Differential;
    [FieldOffset(34)]
    public byte DiscardIdleTime;
    [FieldOffset(36)]
    public uint Scaling;
    [FieldOffset(40)]
    public ulong Context;
}
