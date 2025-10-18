using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _POP_FX_COMPONENT_FLAGS
{
    [FieldOffset(0)]
    public int Value;
    [FieldOffset(4)]
    public int Value2;
}
