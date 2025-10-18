using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _TRACE_ENABLE_INFO
{
    [FieldOffset(0)]
    public uint IsEnabled;
    [FieldOffset(4)]
    public byte Level;
    [FieldOffset(5)]
    public byte Reserved1;
    [FieldOffset(6)]
    public ushort LoggerId;
    [FieldOffset(8)]
    public uint EnableProperty;
    [FieldOffset(12)]
    public uint Reserved2;
    [FieldOffset(16)]
    public ulong MatchAnyKeyword;
    [FieldOffset(24)]
    public ulong MatchAllKeyword;
}
