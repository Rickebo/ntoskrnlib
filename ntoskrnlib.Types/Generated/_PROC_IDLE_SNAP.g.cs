using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PROC_IDLE_SNAP
{
    [FieldOffset(0)]
    public ulong Time;
    [FieldOffset(8)]
    public ulong Idle;
}
