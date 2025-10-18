using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1)]
public struct _PS_PROTECTION
{
    [FieldOffset(0)]
    public byte Level;
}
