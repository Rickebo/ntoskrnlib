using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _MI_PFN_FLAGS4
{
    [FieldOffset(0)]
    public ulong EntireField;
}
