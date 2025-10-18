using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _EX_FAST_REF
{
    [FieldOffset(0)]
    public IntPtr Object;
    [FieldOffset(0)]
    public ulong Value;
}
