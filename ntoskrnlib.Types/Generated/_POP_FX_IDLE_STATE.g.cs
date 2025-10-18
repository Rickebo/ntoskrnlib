using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _POP_FX_IDLE_STATE
{
    [FieldOffset(0)]
    public ulong TransitionLatency;
    [FieldOffset(8)]
    public ulong ResidencyRequirement;
    [FieldOffset(16)]
    public uint NominalPower;
}
