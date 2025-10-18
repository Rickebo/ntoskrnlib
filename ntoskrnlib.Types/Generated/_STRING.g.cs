using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _STRING
{
    [FieldOffset(0)]
    public ushort Length;
    [FieldOffset(2)]
    public ushort MaximumLength;
    [FieldOffset(8)]
    public IntPtr Buffer;
}
