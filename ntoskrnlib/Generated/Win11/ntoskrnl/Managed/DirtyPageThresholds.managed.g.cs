using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DIRTY_PAGE_THRESHOLDS")]
    public sealed class DirtyPageThresholds : DynamicStructure
    {
        [Offset(0UL)]
        public ulong DirtyPageThreshold { get => ReadHere<ulong>(nameof(DirtyPageThreshold)); set => WriteHere(nameof(DirtyPageThreshold), value); }

        [Offset(8UL)]
        public ulong DirtyPageThresholdTop { get => ReadHere<ulong>(nameof(DirtyPageThresholdTop)); set => WriteHere(nameof(DirtyPageThresholdTop), value); }

        [Offset(16UL)]
        public ulong DirtyPageThresholdBottom { get => ReadHere<ulong>(nameof(DirtyPageThresholdBottom)); set => WriteHere(nameof(DirtyPageThresholdBottom), value); }

        [Offset(24UL)]
        public uint DirtyPageTarget { get => ReadHere<uint>(nameof(DirtyPageTarget)); set => WriteHere(nameof(DirtyPageTarget), value); }

        [Offset(32UL)]
        public ulong AggregateAvailablePages { get => ReadHere<ulong>(nameof(AggregateAvailablePages)); set => WriteHere(nameof(AggregateAvailablePages), value); }

        [Offset(40UL)]
        public ulong AggregateDirtyPages { get => ReadHere<ulong>(nameof(AggregateDirtyPages)); set => WriteHere(nameof(AggregateDirtyPages), value); }

        [Offset(48UL)]
        public uint AvailableHistory { get => ReadHere<uint>(nameof(AvailableHistory)); set => WriteHere(nameof(AvailableHistory), value); }

        public DirtyPageThresholds(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DirtyPageThresholds>();
        }
    }
}