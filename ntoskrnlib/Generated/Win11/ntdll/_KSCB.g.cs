#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 440)]
    public partial struct _KSCB
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
        public ushort Inserted;
        [FieldOffset(112)]
        public ushort MaxOverQuota;
        [FieldOffset(112)]
        public ushort MinOverQuota;
        [FieldOffset(112)]
        public ushort RankBias;
        [FieldOffset(112)]
        public ushort UnconstrainedMaxQuota;
        [FieldOffset(112)]
        public ushort UnconstrainedMinQuota;
        [FieldOffset(112)]
        public ushort ShareRankOwner;
        [FieldOffset(112)]
        public ushort PerProcHardCap;
        [FieldOffset(112)]
        public ushort Referenced;
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
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _LIST_ENTRY[] ReadyListHead;
        [FieldOffset(400)]
        public _RTL_RB_TREE ChildScbQueue;
        [FieldOffset(416)]
        public IntPtr Parent;
        [FieldOffset(424)]
        public IntPtr Root;
        [FieldOffset(432)]
        public _SINGLE_LIST_ENTRY TracingListEntry;
    }
}