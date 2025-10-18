using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _COUNTER_READING
{
    [FieldOffset(0)]
    public IntPtr Type;
    [FieldOffset(4)]
    public uint Index;
    [FieldOffset(8)]
    public ulong Start;
    [FieldOffset(16)]
    public ulong Total;
}
