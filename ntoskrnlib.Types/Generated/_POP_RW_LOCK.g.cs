using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _POP_RW_LOCK
{
    [FieldOffset(0)]
    public _EX_PUSH_LOCK Lock;
    [FieldOffset(8)]
    public IntPtr Thread;
}
