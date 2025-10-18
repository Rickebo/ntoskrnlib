using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _RTL_DYNAMIC_HASH_TABLE
{
    [FieldOffset(0)]
    public uint Flags;
    [FieldOffset(4)]
    public uint Shift;
    [FieldOffset(8)]
    public uint TableSize;
    [FieldOffset(12)]
    public uint Pivot;
    [FieldOffset(16)]
    public uint DivisorMask;
    [FieldOffset(20)]
    public uint NumEntries;
    [FieldOffset(24)]
    public uint NonEmptyBuckets;
    [FieldOffset(28)]
    public uint NumEnumerators;
    [FieldOffset(32)]
    public IntPtr Directory;
}
