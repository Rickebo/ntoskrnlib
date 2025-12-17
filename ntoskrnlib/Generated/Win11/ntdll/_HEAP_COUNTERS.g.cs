#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _HEAP_COUNTERS
    {
        [FieldOffset(0)]
        public ulong TotalMemoryReserved;
        [FieldOffset(8)]
        public ulong TotalMemoryCommitted;
        [FieldOffset(16)]
        public ulong TotalMemoryLargeUCR;
        [FieldOffset(24)]
        public ulong TotalSizeInVirtualBlocks;
        [FieldOffset(32)]
        public uint TotalSegments;
        [FieldOffset(36)]
        public uint TotalUCRs;
        [FieldOffset(40)]
        public uint CommittOps;
        [FieldOffset(44)]
        public uint DeCommitOps;
        [FieldOffset(48)]
        public uint LockAcquires;
        [FieldOffset(52)]
        public uint LockCollisions;
        [FieldOffset(56)]
        public uint CommitRate;
        [FieldOffset(60)]
        public uint DecommittRate;
        [FieldOffset(64)]
        public uint CommitFailures;
        [FieldOffset(68)]
        public uint InBlockCommitFailures;
        [FieldOffset(72)]
        public uint PollIntervalCounter;
        [FieldOffset(76)]
        public uint DecommitsSinceLastCheck;
        [FieldOffset(80)]
        public uint HeapPollInterval;
        [FieldOffset(84)]
        public uint AllocAndFreeOps;
        [FieldOffset(88)]
        public uint AllocationIndicesActive;
        [FieldOffset(92)]
        public uint InBlockDeccommits;
        [FieldOffset(96)]
        public ulong InBlockDeccomitSize;
        [FieldOffset(104)]
        public ulong HighWatermarkSize;
        [FieldOffset(112)]
        public ulong LastPolledSize;
    }
}