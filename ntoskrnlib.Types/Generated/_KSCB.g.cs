using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=440)]
public struct _KSCB
{
    [FieldOffset(0)]
    public ulong GenerationCycles;
    [FieldOffset(8)]
    public ulong MinQuotaCycleTarget;
    [FieldOffset(16)]
    public ulong MaxQuotaCycleTarget;
    [FieldOffset(24)]
    public ulong RankCycleTarget;
    [FieldOffset(32)]
    public ulong LongTermCycles;
    [FieldOffset(40)]
    public ulong LastReportedCycles;
    [FieldOffset(48)]
    public ulong OverQuotaHistory;
    [FieldOffset(56)]
    public ulong ReadyTime;
    [FieldOffset(64)]
    public ulong InsertTime;
    [FieldOffset(72)]
    public _LIST_ENTRY PerProcessorList;
    [FieldOffset(88)]
    public _RTL_BALANCED_NODE QueueNode;
    [FieldOffset(112)]
    public ushort PrcbLockFlags;
    [FieldOffset(114)]
    public byte Depth;
    [FieldOffset(115)]
    public byte Pad1;
    [FieldOffset(116)]
    public uint OwningProcessorIndex;
    [FieldOffset(120)]
    public ushort ReadySummary;
    [FieldOffset(122)]
    public ushort Pad2;
    [FieldOffset(124)]
    public uint Rank;
    [FieldOffset(128)]
    public IntPtr ShareRank;
    [FieldOffset(136)]
    public uint OwnerShareRank;
    [FieldOffset(144)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=16)]
    public byte[] ReadyListHead;
    [FieldOffset(400)]
    public _RTL_RB_TREE ChildScbQueue;
    [FieldOffset(416)]
    public IntPtr Parent;
    [FieldOffset(424)]
    public IntPtr Root;
    [FieldOffset(432)]
    public _SINGLE_LIST_ENTRY TracingListEntry;
}
