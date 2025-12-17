using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION")]
    public sealed class MiPartition : DynamicStructure
    {
        [Offset(0UL)]
        public MiPartitionCore Core { get => ReadStructure<MiPartitionCore>(nameof(Core)); set => WriteStructure(nameof(Core), value); }

        [Offset(480UL)]
        public MiPartitionModwrites Modwriter { get => ReadStructure<MiPartitionModwrites>(nameof(Modwriter)); set => WriteStructure(nameof(Modwriter), value); }

        [Offset(1200UL)]
        public MiPartitionStores Store { get => ReadStructure<MiPartitionStores>(nameof(Store)); set => WriteStructure(nameof(Store), value); }

        [Offset(1728UL)]
        public MiPartitionSegments Segments { get => ReadStructure<MiPartitionSegments>(nameof(Segments)); set => WriteStructure(nameof(Segments), value); }

        [Offset(2880UL)]
        public MiPartitionPageLists PageLists { get => ReadStructure<MiPartitionPageLists>(nameof(PageLists)); set => WriteStructure(nameof(PageLists), value); }

        [Offset(16832UL)]
        public MiPartitionCommit Commit { get => ReadStructure<MiPartitionCommit>(nameof(Commit)); set => WriteStructure(nameof(Commit), value); }

        [Offset(16912UL)]
        public MiPartitionZeroing Zeroing { get => ReadStructure<MiPartitionZeroing>(nameof(Zeroing)); set => WriteStructure(nameof(Zeroing), value); }

        [Offset(16984UL)]
        public MiPageCombiningSupport PageCombine { get => ReadStructure<MiPageCombiningSupport>(nameof(PageCombine)); set => WriteStructure(nameof(PageCombine), value); }

        [Offset(17408UL)]
        public MiAccessLogState AccessLog { get => ReadStructure<MiAccessLogState>(nameof(AccessLog)); set => WriteStructure(nameof(AccessLog), value); }

        [Offset(17600UL)]
        public IntPtr WorkingSetControl { get => ReadHere<IntPtr>(nameof(WorkingSetControl)); set => WriteHere(nameof(WorkingSetControl), value); }

        [Offset(17608UL)]
        public MmworkingSetExpansionHead WorkingSetExpansionHead { get => ReadStructure<MmworkingSetExpansionHead>(nameof(WorkingSetExpansionHead)); set => WriteStructure(nameof(WorkingSetExpansionHead), value); }

        [Offset(17624UL)]
        public MiSpecialPurposeMemoryState SpecialPurposeMemory { get => ReadStructure<MiSpecialPurposeMemoryState>(nameof(SpecialPurposeMemory)); set => WriteStructure(nameof(SpecialPurposeMemory), value); }

        [Offset(17728UL)]
        public MiPartitionSlabs Slabs { get => ReadStructure<MiPartitionSlabs>(nameof(Slabs)); set => WriteStructure(nameof(Slabs), value); }

        [Offset(18432UL)]
        public ulong LastPeriodicTelemetryLogTime { get => ReadHere<ulong>(nameof(LastPeriodicTelemetryLogTime)); set => WriteHere(nameof(LastPeriodicTelemetryLogTime), value); }

        [Offset(18496UL)]
        public MiVisiblePartition Vp { get => ReadStructure<MiVisiblePartition>(nameof(Vp)); set => WriteStructure(nameof(Vp), value); }

        public MiPartition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartition>();
        }
    }
}