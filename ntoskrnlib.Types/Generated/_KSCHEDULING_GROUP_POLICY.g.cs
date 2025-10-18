using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _KSCHEDULING_GROUP_POLICY
{
    [FieldOffset(0)]
    public uint Value;
    [FieldOffset(0)]
    public ushort Weight;
    [FieldOffset(0)]
    public ushort MinRate;
    [FieldOffset(2)]
    public ushort MaxRate;
    [FieldOffset(4)]
    public uint AllFlags;
}
