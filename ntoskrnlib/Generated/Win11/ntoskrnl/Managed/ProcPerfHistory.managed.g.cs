using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_HISTORY")]
    public sealed class ProcPerfHistory : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(4UL)]
        public uint Slot { get => ReadHere<uint>(nameof(Slot)); set => WriteHere(nameof(Slot), value); }

        [Offset(8UL)]
        public uint UtilityTotal { get => ReadHere<uint>(nameof(UtilityTotal)); set => WriteHere(nameof(UtilityTotal), value); }

        [Offset(12UL)]
        public uint AffinitizedUtilityTotal { get => ReadHere<uint>(nameof(AffinitizedUtilityTotal)); set => WriteHere(nameof(AffinitizedUtilityTotal), value); }

        [Offset(16UL)]
        public uint FrequencyTotal { get => ReadHere<uint>(nameof(FrequencyTotal)); set => WriteHere(nameof(FrequencyTotal), value); }

        [Offset(20UL)]
        public uint ImportantPercentTotal { get => ReadHere<uint>(nameof(ImportantPercentTotal)); set => WriteHere(nameof(ImportantPercentTotal), value); }

        [Offset(24UL)]
        public uint IdealPercentTotal { get => ReadHere<uint>(nameof(IdealPercentTotal)); set => WriteHere(nameof(IdealPercentTotal), value); }

        [Offset(28UL)]
        [Length(4)]
        public DynamicArray TaggedPercentTotal { get => ReadStructure<DynamicArray>(nameof(TaggedPercentTotal)); set => WriteStructure(nameof(TaggedPercentTotal), value); }

        [Offset(44UL)]
        [Length(1)]
        public DynamicArray HistoryList { get => ReadStructure<DynamicArray>(nameof(HistoryList)); set => WriteStructure(nameof(HistoryList), value); }

        public ProcPerfHistory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfHistory>();
        }
    }
}