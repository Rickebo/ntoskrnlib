using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1472)]
public struct _KPROCESSOR_STATE
{
    [FieldOffset(0)]
    public _KSPECIAL_REGISTERS SpecialRegisters;
    [FieldOffset(240)]
    public _CONTEXT ContextFrame;
}
