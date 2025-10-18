using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _TIME_FIELDS
{
    [FieldOffset(0)]
    public short Year;
    [FieldOffset(2)]
    public short Month;
    [FieldOffset(4)]
    public short Day;
    [FieldOffset(6)]
    public short Hour;
    [FieldOffset(8)]
    public short Minute;
    [FieldOffset(10)]
    public short Second;
    [FieldOffset(12)]
    public short Milliseconds;
    [FieldOffset(14)]
    public short Weekday;
}
