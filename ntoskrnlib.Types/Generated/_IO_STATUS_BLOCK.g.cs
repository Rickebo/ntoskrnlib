using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _IO_STATUS_BLOCK
{
    [FieldOffset(0)]
    public int Status;
    [FieldOffset(0)]
    public IntPtr Pointer;
    [FieldOffset(8)]
    public ulong Information;
}
