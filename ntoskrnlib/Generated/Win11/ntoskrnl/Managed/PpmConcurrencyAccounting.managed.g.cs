using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_CONCURRENCY_ACCOUNTING")]
    public sealed class PpmConcurrencyAccounting : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public uint Processors { get => ReadHere<uint>(nameof(Processors)); set => WriteHere(nameof(Processors), value); }

        [Offset(12UL)]
        public uint ActiveProcessors { get => ReadHere<uint>(nameof(ActiveProcessors)); set => WriteHere(nameof(ActiveProcessors), value); }

        [Offset(16UL)]
        public ulong LastUpdateTime { get => ReadHere<ulong>(nameof(LastUpdateTime)); set => WriteHere(nameof(LastUpdateTime), value); }

        [Offset(24UL)]
        public ulong TotalTime { get => ReadHere<ulong>(nameof(TotalTime)); set => WriteHere(nameof(TotalTime), value); }

        [Offset(32UL)]
        [Length(37)]
        public DynamicArray IdleIntervalStats { get => ReadStructure<DynamicArray>(nameof(IdleIntervalStats)); set => WriteStructure(nameof(IdleIntervalStats), value); }

        [Offset(328UL)]
        [Length(1)]
        public DynamicArray AccumulatedTime { get => ReadStructure<DynamicArray>(nameof(AccumulatedTime)); set => WriteStructure(nameof(AccumulatedTime), value); }

        public PpmConcurrencyAccounting(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmConcurrencyAccounting>();
        }
    }
}