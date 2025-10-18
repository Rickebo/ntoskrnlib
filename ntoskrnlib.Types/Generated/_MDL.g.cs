using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _MDL
{
    [FieldOffset(0)]
    public IntPtr Next;
    [FieldOffset(8)]
    public short Size;
    [FieldOffset(10)]
    public short MdlFlags;
    [FieldOffset(12)]
    public ushort AllocationProcessorNumber;
    [FieldOffset(14)]
    public ushort Reserved;
    [FieldOffset(16)]
    public IntPtr Process;
    [FieldOffset(24)]
    public IntPtr MappedSystemVa;
    [FieldOffset(32)]
    public IntPtr StartVa;
    [FieldOffset(40)]
    public uint ByteCount;
    [FieldOffset(44)]
    public uint ByteOffset;
}
