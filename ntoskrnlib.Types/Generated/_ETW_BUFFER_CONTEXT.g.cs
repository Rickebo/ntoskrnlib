using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _ETW_BUFFER_CONTEXT
{
    [FieldOffset(0)]
    public byte ProcessorNumber;
    [FieldOffset(1)]
    public byte Alignment;
    [FieldOffset(0)]
    public ushort ProcessorIndex;
    [FieldOffset(2)]
    public ushort LoggerId;
}
