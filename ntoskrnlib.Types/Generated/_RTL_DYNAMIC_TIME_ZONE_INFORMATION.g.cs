using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=432)]
public struct _RTL_DYNAMIC_TIME_ZONE_INFORMATION
{
    [FieldOffset(0)]
    public _RTL_TIME_ZONE_INFORMATION tzi;
    [FieldOffset(172)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]
    public short[] TimeZoneKeyName;
    [FieldOffset(428)]
    public byte DynamicDaylightTimeDisabled;
}
