using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _PROCESSOR_NUMBER
{
    [FieldOffset(0)]
    public ushort Group;
    [FieldOffset(2)]
    public byte Number;
    [FieldOffset(3)]
    public byte Reserved;
}
