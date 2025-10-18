using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=112)]
public struct _KCPU_PARTITION
{
    [FieldOffset(0)]
    public IntPtr Affinity;
    [FieldOffset(8)]
    public ulong Lock;
    [FieldOffset(16)]
    public _LIST_ENTRY ProcessList;
    [FieldOffset(32)]
    public IntPtr CpuPartitionObject;
    [FieldOffset(40)]
    public _KI_AVAILABLE_CPUS_WORK_ITEM AvailableCpusNotificationWorkItem;
    [FieldOffset(104)]
    public uint Flags;
}
