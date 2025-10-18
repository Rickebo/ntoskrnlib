using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _ACPI_METHOD_ARGUMENT_V1
{
    [FieldOffset(0)]
    public ushort Type;
    [FieldOffset(2)]
    public ushort DataLength;
    [FieldOffset(4)]
    public uint Argument;
    [FieldOffset(4)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] Data;
}
