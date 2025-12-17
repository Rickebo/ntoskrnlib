using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEBS_DS_SAVE_AREA64")]
    public sealed class PebsDsSaveAREA64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BtsBufferBase { get => ReadHere<ulong>(nameof(BtsBufferBase)); set => WriteHere(nameof(BtsBufferBase), value); }

        [Offset(8UL)]
        public ulong BtsIndex { get => ReadHere<ulong>(nameof(BtsIndex)); set => WriteHere(nameof(BtsIndex), value); }

        [Offset(16UL)]
        public ulong BtsAbsoluteMaximum { get => ReadHere<ulong>(nameof(BtsAbsoluteMaximum)); set => WriteHere(nameof(BtsAbsoluteMaximum), value); }

        [Offset(24UL)]
        public ulong BtsInterruptThreshold { get => ReadHere<ulong>(nameof(BtsInterruptThreshold)); set => WriteHere(nameof(BtsInterruptThreshold), value); }

        [Offset(32UL)]
        public ulong PebsBufferBase { get => ReadHere<ulong>(nameof(PebsBufferBase)); set => WriteHere(nameof(PebsBufferBase), value); }

        [Offset(40UL)]
        public ulong PebsIndex { get => ReadHere<ulong>(nameof(PebsIndex)); set => WriteHere(nameof(PebsIndex), value); }

        [Offset(48UL)]
        public ulong PebsAbsoluteMaximum { get => ReadHere<ulong>(nameof(PebsAbsoluteMaximum)); set => WriteHere(nameof(PebsAbsoluteMaximum), value); }

        [Offset(56UL)]
        public ulong PebsInterruptThreshold { get => ReadHere<ulong>(nameof(PebsInterruptThreshold)); set => WriteHere(nameof(PebsInterruptThreshold), value); }

        [Offset(64UL)]
        [Length(8)]
        public DynamicArray PebsGpCounterReset { get => ReadStructure<DynamicArray>(nameof(PebsGpCounterReset)); set => WriteStructure(nameof(PebsGpCounterReset), value); }

        [Offset(128UL)]
        [Length(4)]
        public DynamicArray PebsFixedCounterReset { get => ReadStructure<DynamicArray>(nameof(PebsFixedCounterReset)); set => WriteStructure(nameof(PebsFixedCounterReset), value); }

        public PebsDsSaveAREA64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PebsDsSaveAREA64>();
        }
    }
}