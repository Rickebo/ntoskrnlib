using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KENTROPY_TIMING_STATE")]
    public sealed class KentropyTimingState : DynamicStructure
    {
        [Offset(0UL)]
        public uint EntropyCount { get => ReadHere<uint>(nameof(EntropyCount)); set => WriteHere(nameof(EntropyCount), value); }

        [Offset(4UL)]
        [Length(64)]
        public DynamicArray Buffer { get => ReadStructure<DynamicArray>(nameof(Buffer)); set => WriteStructure(nameof(Buffer), value); }

        [Offset(264UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(328UL)]
        public uint LastDeliveredBuffer { get => ReadHere<uint>(nameof(LastDeliveredBuffer)); set => WriteHere(nameof(LastDeliveredBuffer), value); }

        [Offset(336UL)]
        public IntPtr ReservedRawDataBuffer { get => ReadHere<IntPtr>(nameof(ReservedRawDataBuffer)); set => WriteHere(nameof(ReservedRawDataBuffer), value); }

        public KentropyTimingState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KentropyTimingState>();
        }
    }
}