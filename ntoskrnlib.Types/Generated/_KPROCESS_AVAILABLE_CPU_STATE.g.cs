using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=120)]
public struct _KPROCESS_AVAILABLE_CPU_STATE
{
    [FieldOffset(0)]
    public _RTL_TICK_LOCK SequenceNumber;
    [FieldOffset(8)]
    public ulong CpuSetSequenceNumber;
    [FieldOffset(16)]
    public ulong ForceParkSequenceNumber;
    [FieldOffset(24)]
    public IntPtr Affinity;
    [FieldOffset(32)]
    public _EX_PUSH_LOCK SubscriptionLock;
    [FieldOffset(40)]
    public _LIST_ENTRY SubscriptionList;
    [FieldOffset(56)]
    public _KI_AVAILABLE_CPUS_WORK_ITEM WorkItem;
}
