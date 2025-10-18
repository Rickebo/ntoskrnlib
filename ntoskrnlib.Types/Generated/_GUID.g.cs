using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _GUID
{
    [FieldOffset(0)]
    public uint Data1;
    [FieldOffset(4)]
    public ushort Data2;
    [FieldOffset(6)]
    public ushort Data3;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public byte[] Data4;
}
