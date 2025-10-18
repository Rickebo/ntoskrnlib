using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=12)]
public struct _LUID_AND_ATTRIBUTES
{
    [FieldOffset(0)]
    public _LUID Luid;
    [FieldOffset(8)]
    public uint Attributes;
}
