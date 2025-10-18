using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _IO_RESOURCE_DESCRIPTOR
{
    [FieldOffset(0)]
    public byte Option;
    [FieldOffset(1)]
    public byte Type;
    [FieldOffset(2)]
    public byte ShareDisposition;
    [FieldOffset(3)]
    public byte Spare1;
    [FieldOffset(4)]
    public ushort Flags;
    [FieldOffset(6)]
    public ushort Spare2;
    [FieldOffset(8)]
    public _unnamed_tag_ u;
}
