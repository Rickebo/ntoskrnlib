using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _POP_FX_DEPENDENT
{
    [FieldOffset(0)]
    public uint Index;
    [FieldOffset(4)]
    public uint ProviderIndex;
}
