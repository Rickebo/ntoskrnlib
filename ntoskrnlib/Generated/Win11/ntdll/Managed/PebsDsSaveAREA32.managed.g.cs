using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PEBS_DS_SAVE_AREA32")]
    public sealed class PebsDsSaveAREA32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint BtsBufferBase { get => ReadHere<uint>(nameof(BtsBufferBase)); set => WriteHere(nameof(BtsBufferBase), value); }

        [Offset(4UL)]
        public uint BtsIndex { get => ReadHere<uint>(nameof(BtsIndex)); set => WriteHere(nameof(BtsIndex), value); }

        [Offset(8UL)]
        public uint BtsAbsoluteMaximum { get => ReadHere<uint>(nameof(BtsAbsoluteMaximum)); set => WriteHere(nameof(BtsAbsoluteMaximum), value); }

        [Offset(12UL)]
        public uint BtsInterruptThreshold { get => ReadHere<uint>(nameof(BtsInterruptThreshold)); set => WriteHere(nameof(BtsInterruptThreshold), value); }

        [Offset(16UL)]
        public uint PebsBufferBase { get => ReadHere<uint>(nameof(PebsBufferBase)); set => WriteHere(nameof(PebsBufferBase), value); }

        [Offset(20UL)]
        public uint PebsIndex { get => ReadHere<uint>(nameof(PebsIndex)); set => WriteHere(nameof(PebsIndex), value); }

        [Offset(24UL)]
        public uint PebsAbsoluteMaximum { get => ReadHere<uint>(nameof(PebsAbsoluteMaximum)); set => WriteHere(nameof(PebsAbsoluteMaximum), value); }

        [Offset(28UL)]
        public uint PebsInterruptThreshold { get => ReadHere<uint>(nameof(PebsInterruptThreshold)); set => WriteHere(nameof(PebsInterruptThreshold), value); }

        [Offset(32UL)]
        [Length(8)]
        public DynamicArray PebsGpCounterReset { get => ReadStructure<DynamicArray>(nameof(PebsGpCounterReset)); set => WriteStructure(nameof(PebsGpCounterReset), value); }

        [Offset(96UL)]
        [Length(4)]
        public DynamicArray PebsFixedCounterReset { get => ReadStructure<DynamicArray>(nameof(PebsFixedCounterReset)); set => WriteStructure(nameof(PebsFixedCounterReset), value); }

        public PebsDsSaveAREA32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PebsDsSaveAREA32>();
        }
    }
}