using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=272)]
public struct _SID_AND_ATTRIBUTES_HASH
{
    [FieldOffset(0)]
    public uint SidCount;
    [FieldOffset(8)]
    public IntPtr SidAttr;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public ulong[] Hash;
}
