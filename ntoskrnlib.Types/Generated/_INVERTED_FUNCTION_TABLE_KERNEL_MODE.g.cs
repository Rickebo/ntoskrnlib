using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=6160)]
public struct _INVERTED_FUNCTION_TABLE_KERNEL_MODE
{
    [FieldOffset(0)]
    public uint CurrentSize;
    [FieldOffset(4)]
    public uint MaximumSize;
    [FieldOffset(8)]
    public uint Epoch;
    [FieldOffset(12)]
    public byte Overflow;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=256)]
    public byte[] TableEntry;
}
