using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _PROCESSOR_IDLE_CONSTRAINTS
{
    [FieldOffset(0)]
    public ulong TotalTime;
    [FieldOffset(8)]
    public ulong IdleTime;
    [FieldOffset(16)]
    public ulong ExpectedIdleDuration;
    [FieldOffset(24)]
    public ulong MaxIdleDuration;
    [FieldOffset(32)]
    public uint OverrideState;
    [FieldOffset(36)]
    public uint TimeCheck;
    [FieldOffset(40)]
    public byte PromotePercent;
    [FieldOffset(41)]
    public byte DemotePercent;
    [FieldOffset(42)]
    public byte Parked;
    [FieldOffset(43)]
    public byte Interruptible;
    [FieldOffset(44)]
    public byte PlatformIdle;
    [FieldOffset(45)]
    public byte ExpectedWakeReason;
    [FieldOffset(46)]
    public byte IdleStateMax;
}
