using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_COMMIT")]
    public sealed class MiPartitionCommit : DynamicStructure
    {
        [Offset(0UL)]
        public ulong PeakCommitment { get => ReadHere<ulong>(nameof(PeakCommitment)); set => WriteHere(nameof(PeakCommitment), value); }

        [Offset(8UL)]
        public ulong TotalCommitLimitMaximum { get => ReadHere<ulong>(nameof(TotalCommitLimitMaximum)); set => WriteHere(nameof(TotalCommitLimitMaximum), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray Popups { get => ReadStructure<DynamicArray>(nameof(Popups)); set => WriteStructure(nameof(Popups), value); }

        [Offset(24UL)]
        public ulong LowCommitThreshold { get => ReadHere<ulong>(nameof(LowCommitThreshold)); set => WriteHere(nameof(LowCommitThreshold), value); }

        [Offset(32UL)]
        public ulong HighCommitThreshold { get => ReadHere<ulong>(nameof(HighCommitThreshold)); set => WriteHere(nameof(HighCommitThreshold), value); }

        [Offset(40UL)]
        public ulong ExtremelyHighCommitThreshold { get => ReadHere<ulong>(nameof(ExtremelyHighCommitThreshold)); set => WriteHere(nameof(ExtremelyHighCommitThreshold), value); }

        [Offset(48UL)]
        public ulong IdealCommitTarget { get => ReadHere<ulong>(nameof(IdealCommitTarget)); set => WriteHere(nameof(IdealCommitTarget), value); }

        [Offset(56UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(64UL)]
        public ulong SystemCommitReserve { get => ReadHere<ulong>(nameof(SystemCommitReserve)); set => WriteHere(nameof(SystemCommitReserve), value); }

        [Offset(72UL)]
        public ulong OverCommit { get => ReadHere<ulong>(nameof(OverCommit)); set => WriteHere(nameof(OverCommit), value); }

        public MiPartitionCommit(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionCommit>();
        }
    }
}