using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=28)]
public struct _CM_PARTIAL_RESOURCE_LIST
{
    [FieldOffset(0)]
    public ushort Version;
    [FieldOffset(2)]
    public ushort Revision;
    [FieldOffset(4)]
    public uint Count;
    [FieldOffset(8)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] PartialDescriptors;
}
