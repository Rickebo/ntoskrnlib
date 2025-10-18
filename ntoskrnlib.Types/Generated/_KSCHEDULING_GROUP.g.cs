using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=576)]
public struct _KSCHEDULING_GROUP
{
    [FieldOffset(0)]
    public _KSCHEDULING_GROUP_POLICY Policy;
    [FieldOffset(8)]
    public uint RelativeWeight;
    [FieldOffset(12)]
    public uint ChildMinRate;
    [FieldOffset(16)]
    public uint ChildMinWeight;
    [FieldOffset(20)]
    public uint ChildTotalWeight;
    [FieldOffset(24)]
    public ulong QueryHistoryTimeStamp;
    [FieldOffset(32)]
    public long NotificationCycles;
    [FieldOffset(40)]
    public long MaxQuotaLimitCycles;
    [FieldOffset(48)]
    public long MaxQuotaCyclesRemaining;
    [FieldOffset(56)]
    public _LIST_ENTRY SchedulingGroupList;
    [FieldOffset(56)]
    public _LIST_ENTRY Sibling;
    [FieldOffset(72)]
    public IntPtr NotificationDpc;
    [FieldOffset(80)]
    public _LIST_ENTRY ChildList;
    [FieldOffset(96)]
    public IntPtr Parent;
    [FieldOffset(128)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] PerProcessor;
}
