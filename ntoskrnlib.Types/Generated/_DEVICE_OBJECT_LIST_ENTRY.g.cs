using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _DEVICE_OBJECT_LIST_ENTRY
{
    [FieldOffset(0)]
    public IntPtr DeviceObject;
    [FieldOffset(8)]
    public IntPtr RelationLevel;
    [FieldOffset(12)]
    public uint Ordinal;
    [FieldOffset(16)]
    public uint Flags;
}
