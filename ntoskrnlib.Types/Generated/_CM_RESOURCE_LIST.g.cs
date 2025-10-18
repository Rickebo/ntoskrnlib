using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _CM_RESOURCE_LIST
{
    [FieldOffset(0)]
    public uint Count;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] List;
}
