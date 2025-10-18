using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _MMSUPPORT_FLAGS
{
    [FieldOffset(0)]
    public ushort u1;
    [FieldOffset(2)]
    public byte MemoryPriority;
    [FieldOffset(3)]
    public byte u2;
    [FieldOffset(0)]
    public uint EntireFlags;
}
