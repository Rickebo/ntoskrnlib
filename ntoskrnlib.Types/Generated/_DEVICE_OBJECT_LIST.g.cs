using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _DEVICE_OBJECT_LIST
{
    [FieldOffset(0)]
    public uint Count;
    [FieldOffset(4)]
    public uint MaxCount;
    [FieldOffset(8)]
    public uint TagCount;
    [FieldOffset(12)]
    public IntPtr OperationCode;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] Devices;
}
