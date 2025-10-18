using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _MIPFNFLINK
{
    [FieldOffset(0)]
    public IntPtr NextSlistPfn;
    [FieldOffset(0)]
    public IntPtr Next;
    [FieldOffset(0)]
    public ulong EntireField;
    [FieldOffset(0)]
    public _MI_ACTIVE_PFN Active;
}
