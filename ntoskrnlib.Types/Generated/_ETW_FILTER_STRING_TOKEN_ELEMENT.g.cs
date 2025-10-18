using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _ETW_FILTER_STRING_TOKEN_ELEMENT
{
    [FieldOffset(0)]
    public ushort Length;
    [FieldOffset(8)]
    public IntPtr String;
}
