using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _EX_PUSH_LOCK
{
    [FieldOffset(0)]
    public ulong Value;
    [FieldOffset(0)]
    public IntPtr Ptr;
}
