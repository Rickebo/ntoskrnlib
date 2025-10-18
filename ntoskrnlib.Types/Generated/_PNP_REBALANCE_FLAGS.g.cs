using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _PNP_REBALANCE_FLAGS
{
    [FieldOffset(0)]
    public _unnamed_tag_ u;
    [FieldOffset(0)]
    public uint AsUlong;
}
