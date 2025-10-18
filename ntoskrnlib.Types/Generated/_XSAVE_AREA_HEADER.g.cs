using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _XSAVE_AREA_HEADER
{
    [FieldOffset(0)]
    public ulong Mask;
    [FieldOffset(8)]
    public ulong CompactionMask;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
    public ulong[] Reserved2;
}
