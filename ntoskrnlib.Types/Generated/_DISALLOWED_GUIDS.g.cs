using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _DISALLOWED_GUIDS
{
    [FieldOffset(0)]
    public ushort Count;
    [FieldOffset(8)]
    public IntPtr Guids;
}
