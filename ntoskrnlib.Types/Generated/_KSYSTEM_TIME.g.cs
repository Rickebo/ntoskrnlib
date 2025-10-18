using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=12)]
public struct _KSYSTEM_TIME
{
    [FieldOffset(0)]
    public uint LowPart;
    [FieldOffset(4)]
    public int High1Time;
    [FieldOffset(8)]
    public int High2Time;
}
