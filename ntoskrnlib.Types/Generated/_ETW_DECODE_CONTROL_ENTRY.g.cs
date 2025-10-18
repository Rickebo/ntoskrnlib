using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _ETW_DECODE_CONTROL_ENTRY
{
    [FieldOffset(0)]
    public IntPtr Next;
    [FieldOffset(8)]
    public _GUID Decode;
    [FieldOffset(24)]
    public _GUID Control;
    [FieldOffset(40)]
    public byte ConsumersNotified;
}
