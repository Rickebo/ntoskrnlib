using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _KE_PRCB_RCU_DATA
{
    [FieldOffset(0)]
    public uint NestingLevel;
    [FieldOffset(4)]
    public byte DispatchPin;
    [FieldOffset(5)]
    public byte GracePeriodNeeded;
    [FieldOffset(6)]
    public byte ExpediteReporting;
    [FieldOffset(7)]
    public sbyte IdleState;
    [FieldOffset(8)]
    public ulong GraceSequenceQuiescent;
    [FieldOffset(16)]
    public ulong GraceSequenceReported;
    [FieldOffset(24)]
    public IntPtr AwaitingCompletion;
}
