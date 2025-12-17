using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSCHEDULING_GROUP")]
    public sealed class KschedulingGroup : DynamicStructure
    {
        [Offset(0UL)]
        public KschedulingGroupPolicy Policy { get => ReadStructure<KschedulingGroupPolicy>(nameof(Policy)); set => WriteStructure(nameof(Policy), value); }

        [Offset(8UL)]
        public uint RelativeWeight { get => ReadHere<uint>(nameof(RelativeWeight)); set => WriteHere(nameof(RelativeWeight), value); }

        [Offset(12UL)]
        public uint ChildMinRate { get => ReadHere<uint>(nameof(ChildMinRate)); set => WriteHere(nameof(ChildMinRate), value); }

        [Offset(16UL)]
        public uint ChildMinWeight { get => ReadHere<uint>(nameof(ChildMinWeight)); set => WriteHere(nameof(ChildMinWeight), value); }

        [Offset(20UL)]
        public uint ChildTotalWeight { get => ReadHere<uint>(nameof(ChildTotalWeight)); set => WriteHere(nameof(ChildTotalWeight), value); }

        [Offset(24UL)]
        public ulong QueryHistoryTimeStamp { get => ReadHere<ulong>(nameof(QueryHistoryTimeStamp)); set => WriteHere(nameof(QueryHistoryTimeStamp), value); }

        [Offset(32UL)]
        public long NotificationCycles { get => ReadHere<long>(nameof(NotificationCycles)); set => WriteHere(nameof(NotificationCycles), value); }

        [Offset(40UL)]
        public long MaxQuotaLimitCycles { get => ReadHere<long>(nameof(MaxQuotaLimitCycles)); set => WriteHere(nameof(MaxQuotaLimitCycles), value); }

        [Offset(48UL)]
        public long MaxQuotaCyclesRemaining { get => ReadHere<long>(nameof(MaxQuotaCyclesRemaining)); set => WriteHere(nameof(MaxQuotaCyclesRemaining), value); }

        [Offset(56UL)]
        public ListEntry SchedulingGroupList { get => ReadStructure<ListEntry>(nameof(SchedulingGroupList)); set => WriteStructure(nameof(SchedulingGroupList), value); }

        [Offset(56UL)]
        public ListEntry Sibling { get => ReadStructure<ListEntry>(nameof(Sibling)); set => WriteStructure(nameof(Sibling), value); }

        [Offset(72UL)]
        public IntPtr NotificationDpc { get => ReadHere<IntPtr>(nameof(NotificationDpc)); set => WriteHere(nameof(NotificationDpc), value); }

        [Offset(80UL)]
        public ListEntry ChildList { get => ReadStructure<ListEntry>(nameof(ChildList)); set => WriteStructure(nameof(ChildList), value); }

        [Offset(96UL)]
        public IntPtr Parent { get => ReadHere<IntPtr>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(128UL)]
        [Length(1)]
        public DynamicArray PerProcessor { get => ReadStructure<DynamicArray>(nameof(PerProcessor)); set => WriteStructure(nameof(PerProcessor), value); }

        public KschedulingGroup(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KschedulingGroup>();
        }
    }
}