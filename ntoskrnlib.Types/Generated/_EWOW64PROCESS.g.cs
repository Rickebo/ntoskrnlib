using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _EWOW64PROCESS
{
    [FieldOffset(0)]
    public IntPtr Peb;
    [FieldOffset(8)]
    public IntPtr NtdllType;
}
