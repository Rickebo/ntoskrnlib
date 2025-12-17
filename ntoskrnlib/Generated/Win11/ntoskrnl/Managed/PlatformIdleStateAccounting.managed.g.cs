using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PLATFORM_IDLE_STATE_ACCOUNTING")]
    public sealed class PlatformIdleStateAccounting : DynamicStructure
    {
        [Offset(0UL)]
        public uint CancelCount { get => ReadHere<uint>(nameof(CancelCount)); set => WriteHere(nameof(CancelCount), value); }

        [Offset(4UL)]
        public uint FailureCount { get => ReadHere<uint>(nameof(FailureCount)); set => WriteHere(nameof(FailureCount), value); }

        [Offset(8UL)]
        public uint SuccessCount { get => ReadHere<uint>(nameof(SuccessCount)); set => WriteHere(nameof(SuccessCount), value); }

        [Offset(16UL)]
        public ulong MaxTime { get => ReadHere<ulong>(nameof(MaxTime)); set => WriteHere(nameof(MaxTime), value); }

        [Offset(24UL)]
        public ulong MinTime { get => ReadHere<ulong>(nameof(MinTime)); set => WriteHere(nameof(MinTime), value); }

        [Offset(32UL)]
        public ulong TotalTime { get => ReadHere<ulong>(nameof(TotalTime)); set => WriteHere(nameof(TotalTime), value); }

        [Offset(40UL)]
        public uint InvalidBucketIndex { get => ReadHere<uint>(nameof(InvalidBucketIndex)); set => WriteHere(nameof(InvalidBucketIndex), value); }

        [Offset(48UL)]
        public PpmSelectionStatistics SelectionStatistics { get => ReadStructure<PpmSelectionStatistics>(nameof(SelectionStatistics)); set => WriteStructure(nameof(SelectionStatistics), value); }

        [Offset(192UL)]
        [Length(26)]
        public DynamicArray IdleTimeBuckets { get => ReadStructure<DynamicArray>(nameof(IdleTimeBuckets)); set => WriteStructure(nameof(IdleTimeBuckets), value); }

        public PlatformIdleStateAccounting(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PlatformIdleStateAccounting>();
        }
    }
}