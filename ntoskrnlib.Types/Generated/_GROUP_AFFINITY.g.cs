using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _GROUP_AFFINITY
{
    [FieldOffset(0)]
    public ulong Mask;
    [FieldOffset(8)]
    public ushort Group;
    [FieldOffset(10)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public ushort[] Reserved;
}
