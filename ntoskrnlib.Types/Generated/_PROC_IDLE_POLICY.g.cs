using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=6)]
public struct _PROC_IDLE_POLICY
{
    [FieldOffset(0)]
    public byte PromotePercent;
    [FieldOffset(1)]
    public byte DemotePercent;
    [FieldOffset(2)]
    public byte PromotePercentBase;
    [FieldOffset(3)]
    public byte DemotePercentBase;
    [FieldOffset(4)]
    public byte AllowScaling;
    [FieldOffset(5)]
    public byte ForceLightIdle;
}
