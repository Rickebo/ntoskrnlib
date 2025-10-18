using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=172)]
public struct _RTL_TIME_ZONE_INFORMATION
{
    [FieldOffset(0)]
    public int Bias;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public short[] StandardName;
    [FieldOffset(68)]
    public _TIME_FIELDS StandardStart;
    [FieldOffset(84)]
    public int StandardBias;
    [FieldOffset(88)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public short[] DaylightName;
    [FieldOffset(152)]
    public _TIME_FIELDS DaylightStart;
    [FieldOffset(168)]
    public int DaylightBias;
}
