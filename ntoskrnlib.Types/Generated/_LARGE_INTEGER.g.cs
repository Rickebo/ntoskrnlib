using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _LARGE_INTEGER
{
    [FieldOffset(0)]
    public uint LowPart;
    [FieldOffset(4)]
    public int HighPart;
    [FieldOffset(0)]
    public _unnamed_tag_ u;
    [FieldOffset(0)]
    public long QuadPart;
}
