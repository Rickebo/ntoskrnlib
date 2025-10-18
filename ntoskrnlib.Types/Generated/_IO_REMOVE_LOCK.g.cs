using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _IO_REMOVE_LOCK
{
    [FieldOffset(0)]
    public _IO_REMOVE_LOCK_COMMON_BLOCK Common;
}
