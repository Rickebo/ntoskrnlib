using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _RELATION_LIST
{
    [FieldOffset(0)]
    public IntPtr DeviceObjectList;
    [FieldOffset(8)]
    public byte Sorted;
}
