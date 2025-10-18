using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _JOBOBJECT_ENERGY_TRACKING_STATE
{
    [FieldOffset(0)]
    public ulong Value;
    [FieldOffset(0)]
    public uint UpdateMask;
    [FieldOffset(4)]
    public uint DesiredState;
}
