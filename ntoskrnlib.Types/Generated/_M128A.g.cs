using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _M128A
{
    [FieldOffset(0)]
    public ulong Low;
    [FieldOffset(8)]
    public long High;
}
