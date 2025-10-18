using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _TERMINATION_PORT
{
    [FieldOffset(0)]
    public IntPtr Next;
    [FieldOffset(8)]
    public IntPtr Port;
}
