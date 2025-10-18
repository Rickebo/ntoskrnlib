using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _XSTATE_SAVE
{
    [FieldOffset(0)]
    public IntPtr Prev;
    [FieldOffset(8)]
    public IntPtr Thread;
    [FieldOffset(16)]
    public byte Level;
    [FieldOffset(24)]
    public _XSTATE_CONTEXT XStateContext;
}
