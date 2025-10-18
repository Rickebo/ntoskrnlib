using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _EVENT_FILTER_HEADER
{
    [FieldOffset(0)]
    public ushort Id;
    [FieldOffset(2)]
    public byte Version;
    [FieldOffset(3)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public byte[] Reserved;
    [FieldOffset(8)]
    public ulong InstanceId;
    [FieldOffset(16)]
    public uint Size;
    [FieldOffset(20)]
    public uint NextOffset;
}
