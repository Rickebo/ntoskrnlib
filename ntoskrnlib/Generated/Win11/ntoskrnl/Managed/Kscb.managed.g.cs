using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSCB")]
    public sealed class Kscb : DynamicStructure
    {
        [Offset(0UL)]
        public ulong GenerationCycles { get => ReadHere<ulong>(nameof(GenerationCycles)); set => WriteHere(nameof(GenerationCycles), value); }

        [Offset(8UL)]
        public ulong MinQuotaCycleTarget { get => ReadHere<ulong>(nameof(MinQuotaCycleTarget)); set => WriteHere(nameof(MinQuotaCycleTarget), value); }

        [Offset(16UL)]
        public ulong MaxQuotaCycleTarget { get => ReadHere<ulong>(nameof(MaxQuotaCycleTarget)); set => WriteHere(nameof(MaxQuotaCycleTarget), value); }

        [Offset(24UL)]
        public ulong RankCycleTarget { get => ReadHere<ulong>(nameof(RankCycleTarget)); set => WriteHere(nameof(RankCycleTarget), value); }

        [Offset(32UL)]
        public ulong LongTermCycles { get => ReadHere<ulong>(nameof(LongTermCycles)); set => WriteHere(nameof(LongTermCycles), value); }

        [Offset(40UL)]
        public ulong LastReportedCycles { get => ReadHere<ulong>(nameof(LastReportedCycles)); set => WriteHere(nameof(LastReportedCycles), value); }

        [Offset(48UL)]
        public ulong OverQuotaHistory { get => ReadHere<ulong>(nameof(OverQuotaHistory)); set => WriteHere(nameof(OverQuotaHistory), value); }

        [Offset(56UL)]
        public ulong ReadyTime { get => ReadHere<ulong>(nameof(ReadyTime)); set => WriteHere(nameof(ReadyTime), value); }

        [Offset(64UL)]
        public ulong InsertTime { get => ReadHere<ulong>(nameof(InsertTime)); set => WriteHere(nameof(InsertTime), value); }

        [Offset(72UL)]
        public ListEntry PerProcessorList { get => ReadStructure<ListEntry>(nameof(PerProcessorList)); set => WriteStructure(nameof(PerProcessorList), value); }

        [Offset(88UL)]
        public RtlBalancedNode QueueNode { get => ReadStructure<RtlBalancedNode>(nameof(QueueNode)); set => WriteStructure(nameof(QueueNode), value); }

        [Offset(112UL)]
        public ushort Inserted { get => ReadHere<ushort>(nameof(Inserted)); set => WriteHere(nameof(Inserted), value); }

        [Offset(112UL)]
        public ushort MaxOverQuota { get => ReadHere<ushort>(nameof(MaxOverQuota)); set => WriteHere(nameof(MaxOverQuota), value); }

        [Offset(112UL)]
        public ushort MinOverQuota { get => ReadHere<ushort>(nameof(MinOverQuota)); set => WriteHere(nameof(MinOverQuota), value); }

        [Offset(112UL)]
        public ushort RankBias { get => ReadHere<ushort>(nameof(RankBias)); set => WriteHere(nameof(RankBias), value); }

        [Offset(112UL)]
        public ushort UnconstrainedMaxQuota { get => ReadHere<ushort>(nameof(UnconstrainedMaxQuota)); set => WriteHere(nameof(UnconstrainedMaxQuota), value); }

        [Offset(112UL)]
        public ushort UnconstrainedMinQuota { get => ReadHere<ushort>(nameof(UnconstrainedMinQuota)); set => WriteHere(nameof(UnconstrainedMinQuota), value); }

        [Offset(112UL)]
        public ushort ShareRankOwner { get => ReadHere<ushort>(nameof(ShareRankOwner)); set => WriteHere(nameof(ShareRankOwner), value); }

        [Offset(112UL)]
        public ushort PerProcHardCap { get => ReadHere<ushort>(nameof(PerProcHardCap)); set => WriteHere(nameof(PerProcHardCap), value); }

        [Offset(112UL)]
        public ushort Referenced { get => ReadHere<ushort>(nameof(Referenced)); set => WriteHere(nameof(Referenced), value); }

        [Offset(112UL)]
        public ushort PrcbLockFlags { get => ReadHere<ushort>(nameof(PrcbLockFlags)); set => WriteHere(nameof(PrcbLockFlags), value); }

        [Offset(114UL)]
        public byte Depth { get => ReadHere<byte>(nameof(Depth)); set => WriteHere(nameof(Depth), value); }

        [Offset(115UL)]
        public byte Pad1 { get => ReadHere<byte>(nameof(Pad1)); set => WriteHere(nameof(Pad1), value); }

        [Offset(116UL)]
        public uint OwningProcessorIndex { get => ReadHere<uint>(nameof(OwningProcessorIndex)); set => WriteHere(nameof(OwningProcessorIndex), value); }

        [Offset(120UL)]
        public ushort ReadySummary { get => ReadHere<ushort>(nameof(ReadySummary)); set => WriteHere(nameof(ReadySummary), value); }

        [Offset(122UL)]
        public ushort Pad2 { get => ReadHere<ushort>(nameof(Pad2)); set => WriteHere(nameof(Pad2), value); }

        [Offset(124UL)]
        public uint Rank { get => ReadHere<uint>(nameof(Rank)); set => WriteHere(nameof(Rank), value); }

        [Offset(128UL)]
        public IntPtr ShareRank { get => ReadHere<IntPtr>(nameof(ShareRank)); set => WriteHere(nameof(ShareRank), value); }

        [Offset(136UL)]
        public uint OwnerShareRank { get => ReadHere<uint>(nameof(OwnerShareRank)); set => WriteHere(nameof(OwnerShareRank), value); }

        [Offset(144UL)]
        [Length(16)]
        public DynamicArray ReadyListHead { get => ReadStructure<DynamicArray>(nameof(ReadyListHead)); set => WriteStructure(nameof(ReadyListHead), value); }

        [Offset(400UL)]
        public RtlRbTree ChildScbQueue { get => ReadStructure<RtlRbTree>(nameof(ChildScbQueue)); set => WriteStructure(nameof(ChildScbQueue), value); }

        [Offset(416UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(424UL)]
        public IntPtr Root { get => ReadHere<IntPtr>(nameof(Root)); set => WriteHere(nameof(Root), value); }

        [Offset(432UL)]
        public SingleListEntry TracingListEntry { get => ReadStructure<SingleListEntry>(nameof(TracingListEntry)); set => WriteStructure(nameof(TracingListEntry), value); }

        public Kscb(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kscb>();
        }
    }
}