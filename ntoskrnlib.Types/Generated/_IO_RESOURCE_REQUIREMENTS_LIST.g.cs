using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=72)]
public struct _IO_RESOURCE_REQUIREMENTS_LIST
{
    [FieldOffset(0)]
    public uint ListSize;
    [FieldOffset(4)]
    public IntPtr InterfaceType;
    [FieldOffset(8)]
    public uint BusNumber;
    [FieldOffset(12)]
    public uint SlotNumber;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public uint[] Reserved;
    [FieldOffset(28)]
    public uint AlternativeLists;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] List;
}
