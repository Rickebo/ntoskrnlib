using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _ENERGY_STATE_DURATION
{
    [FieldOffset(0)]
    public ulong Value;
    [FieldOffset(0)]
    public uint LastChangeTime;
}
