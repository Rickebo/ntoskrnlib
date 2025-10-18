using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _PO_POWER_PLANE_PROFILE
{
    [FieldOffset(0)]
    public uint ExclusivePowerMw;
    [FieldOffset(4)]
    public uint PeakPowerMw;
}
