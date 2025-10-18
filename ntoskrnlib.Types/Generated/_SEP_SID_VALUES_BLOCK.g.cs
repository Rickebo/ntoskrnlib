using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _SEP_SID_VALUES_BLOCK
{
    [FieldOffset(0)]
    public uint BlockLength;
    [FieldOffset(8)]
    public long ReferenceCount;
    [FieldOffset(16)]
    public uint SidCount;
    [FieldOffset(24)]
    public ulong SidValuesStart;
}
