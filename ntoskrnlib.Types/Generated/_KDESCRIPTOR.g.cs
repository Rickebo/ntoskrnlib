using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _KDESCRIPTOR
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public ushort[] Pad;
    [FieldOffset(6)]
    public ushort Limit;
    [FieldOffset(8)]
    public IntPtr Base;
}
