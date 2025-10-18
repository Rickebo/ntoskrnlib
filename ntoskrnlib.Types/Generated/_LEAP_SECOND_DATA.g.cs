using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _LEAP_SECOND_DATA
{
    [FieldOffset(0)]
    public byte Enabled;
    [FieldOffset(4)]
    public uint Count;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] Data;
}
