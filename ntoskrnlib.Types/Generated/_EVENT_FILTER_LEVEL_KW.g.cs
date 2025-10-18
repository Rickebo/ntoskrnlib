using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _EVENT_FILTER_LEVEL_KW
{
    [FieldOffset(0)]
    public ulong MatchAnyKeyword;
    [FieldOffset(8)]
    public ulong MatchAllKeyword;
    [FieldOffset(16)]
    public byte Level;
    [FieldOffset(17)]
    public byte FilterIn;
}
