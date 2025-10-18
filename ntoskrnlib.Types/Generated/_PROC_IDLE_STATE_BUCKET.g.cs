using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _PROC_IDLE_STATE_BUCKET
{
    [FieldOffset(0)]
    public ulong TotalTime;
    [FieldOffset(8)]
    public ulong MinTime;
    [FieldOffset(16)]
    public ulong MaxTime;
    [FieldOffset(24)]
    public uint Count;
}
