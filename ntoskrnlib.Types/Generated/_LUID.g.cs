using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _LUID
{
    [FieldOffset(0)]
    public uint LowPart;
    [FieldOffset(4)]
    public int HighPart;
}
