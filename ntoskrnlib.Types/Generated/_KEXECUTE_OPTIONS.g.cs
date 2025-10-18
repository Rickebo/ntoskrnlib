using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1)]
public struct _KEXECUTE_OPTIONS
{
    [FieldOffset(0)]
    public byte ExecuteOptions;
    [FieldOffset(0)]
    public byte ExecuteOptionsNV;
}
