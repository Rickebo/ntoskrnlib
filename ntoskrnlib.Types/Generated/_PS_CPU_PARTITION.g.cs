using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _PS_CPU_PARTITION
{
    [FieldOffset(0)]
    public IntPtr Partition;
    [FieldOffset(8)]
    public IntPtr Parent;
    [FieldOffset(16)]
    public _LIST_ENTRY PartitionListEntry;
}
