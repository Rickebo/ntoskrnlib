using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_COUNTERS")]
    public sealed class HeapCounters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TotalMemoryReserved { get => ReadHere<ulong>(nameof(TotalMemoryReserved)); set => WriteHere(nameof(TotalMemoryReserved), value); }

        [Offset(8UL)]
        public ulong TotalMemoryCommitted { get => ReadHere<ulong>(nameof(TotalMemoryCommitted)); set => WriteHere(nameof(TotalMemoryCommitted), value); }

        [Offset(16UL)]
        public ulong TotalMemoryLargeUCR { get => ReadHere<ulong>(nameof(TotalMemoryLargeUCR)); set => WriteHere(nameof(TotalMemoryLargeUCR), value); }

        [Offset(24UL)]
        public ulong TotalSizeInVirtualBlocks { get => ReadHere<ulong>(nameof(TotalSizeInVirtualBlocks)); set => WriteHere(nameof(TotalSizeInVirtualBlocks), value); }

        [Offset(32UL)]
        public uint TotalSegments { get => ReadHere<uint>(nameof(TotalSegments)); set => WriteHere(nameof(TotalSegments), value); }

        [Offset(36UL)]
        public uint TotalUCRs { get => ReadHere<uint>(nameof(TotalUCRs)); set => WriteHere(nameof(TotalUCRs), value); }

        [Offset(40UL)]
        public uint CommittOps { get => ReadHere<uint>(nameof(CommittOps)); set => WriteHere(nameof(CommittOps), value); }

        [Offset(44UL)]
        public uint DeCommitOps { get => ReadHere<uint>(nameof(DeCommitOps)); set => WriteHere(nameof(DeCommitOps), value); }

        [Offset(48UL)]
        public uint LockAcquires { get => ReadHere<uint>(nameof(LockAcquires)); set => WriteHere(nameof(LockAcquires), value); }

        [Offset(52UL)]
        public uint LockCollisions { get => ReadHere<uint>(nameof(LockCollisions)); set => WriteHere(nameof(LockCollisions), value); }

        [Offset(56UL)]
        public uint CommitRate { get => ReadHere<uint>(nameof(CommitRate)); set => WriteHere(nameof(CommitRate), value); }

        [Offset(60UL)]
        public uint DecommittRate { get => ReadHere<uint>(nameof(DecommittRate)); set => WriteHere(nameof(DecommittRate), value); }

        [Offset(64UL)]
        public uint CommitFailures { get => ReadHere<uint>(nameof(CommitFailures)); set => WriteHere(nameof(CommitFailures), value); }

        [Offset(68UL)]
        public uint InBlockCommitFailures { get => ReadHere<uint>(nameof(InBlockCommitFailures)); set => WriteHere(nameof(InBlockCommitFailures), value); }

        [Offset(72UL)]
        public uint PollIntervalCounter { get => ReadHere<uint>(nameof(PollIntervalCounter)); set => WriteHere(nameof(PollIntervalCounter), value); }

        [Offset(76UL)]
        public uint DecommitsSinceLastCheck { get => ReadHere<uint>(nameof(DecommitsSinceLastCheck)); set => WriteHere(nameof(DecommitsSinceLastCheck), value); }

        [Offset(80UL)]
        public uint HeapPollInterval { get => ReadHere<uint>(nameof(HeapPollInterval)); set => WriteHere(nameof(HeapPollInterval), value); }

        [Offset(84UL)]
        public uint AllocAndFreeOps { get => ReadHere<uint>(nameof(AllocAndFreeOps)); set => WriteHere(nameof(AllocAndFreeOps), value); }

        [Offset(88UL)]
        public uint AllocationIndicesActive { get => ReadHere<uint>(nameof(AllocationIndicesActive)); set => WriteHere(nameof(AllocationIndicesActive), value); }

        [Offset(92UL)]
        public uint InBlockDeccommits { get => ReadHere<uint>(nameof(InBlockDeccommits)); set => WriteHere(nameof(InBlockDeccommits), value); }

        [Offset(96UL)]
        public ulong InBlockDeccomitSize { get => ReadHere<ulong>(nameof(InBlockDeccomitSize)); set => WriteHere(nameof(InBlockDeccomitSize), value); }

        [Offset(104UL)]
        public ulong HighWatermarkSize { get => ReadHere<ulong>(nameof(HighWatermarkSize)); set => WriteHere(nameof(HighWatermarkSize), value); }

        [Offset(112UL)]
        public ulong LastPolledSize { get => ReadHere<ulong>(nameof(LastPolledSize)); set => WriteHere(nameof(LastPolledSize), value); }

        public HeapCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapCounters>();
        }
    }
}