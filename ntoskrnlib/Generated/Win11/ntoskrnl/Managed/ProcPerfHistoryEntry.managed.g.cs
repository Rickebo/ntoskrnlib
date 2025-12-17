using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_HISTORY_ENTRY")]
    public sealed class ProcPerfHistoryEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Utility { get => ReadHere<ushort>(nameof(Utility)); set => WriteHere(nameof(Utility), value); }

        [Offset(2UL)]
        public ushort AffinitizedUtility { get => ReadHere<ushort>(nameof(AffinitizedUtility)); set => WriteHere(nameof(AffinitizedUtility), value); }

        [Offset(4UL)]
        public ushort Frequency { get => ReadHere<ushort>(nameof(Frequency)); set => WriteHere(nameof(Frequency), value); }

        [Offset(6UL)]
        public byte ImportantPercent { get => ReadHere<byte>(nameof(ImportantPercent)); set => WriteHere(nameof(ImportantPercent), value); }

        [Offset(7UL)]
        public byte IdealPercent { get => ReadHere<byte>(nameof(IdealPercent)); set => WriteHere(nameof(IdealPercent), value); }

        [Offset(8UL)]
        [Length(4)]
        public DynamicArray TaggedPercent { get => ReadStructure<DynamicArray>(nameof(TaggedPercent)); set => WriteStructure(nameof(TaggedPercent), value); }

        public ProcPerfHistoryEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfHistoryEntry>();
        }
    }
}