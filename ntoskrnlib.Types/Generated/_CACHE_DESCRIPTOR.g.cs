using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=12)]
public struct _CACHE_DESCRIPTOR
{
    [FieldOffset(0)]
    public byte Level;
    [FieldOffset(1)]
    public byte Associativity;
    [FieldOffset(2)]
    public ushort LineSize;
    [FieldOffset(4)]
    public uint Size;
    [FieldOffset(8)]
    public IntPtr Type;
}
