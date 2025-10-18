using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _KPRCB_TRACEPOINT_LOG_ENTRY
{
    [FieldOffset(0)]
    public ulong OldPc;
    [FieldOffset(8)]
    public ulong OldSp;
    [FieldOffset(16)]
    public ulong NewPc;
    [FieldOffset(24)]
    public ulong NewSp;
}
