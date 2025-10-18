using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _ETW_FILTER_EVENT_NAME_DATA
{
    [FieldOffset(0)]
    public byte FilterIn;
    [FieldOffset(1)]
    public byte Level;
    [FieldOffset(8)]
    public ulong MatchAnyKeyword;
    [FieldOffset(16)]
    public ulong MatchAllKeyword;
    [FieldOffset(24)]
    public _RTL_HASH_TABLE NameTable;
}
