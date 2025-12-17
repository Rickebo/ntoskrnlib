using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_ADAPTER_INFO_V1")]
    public sealed class DmaAdapterInfoV1 : DynamicStructure
    {
        [Offset(0UL)]
        public uint ReadDmaCounterAvailable { get => ReadHere<uint>(nameof(ReadDmaCounterAvailable)); set => WriteHere(nameof(ReadDmaCounterAvailable), value); }

        [Offset(4UL)]
        public uint ScatterGatherLimit { get => ReadHere<uint>(nameof(ScatterGatherLimit)); set => WriteHere(nameof(ScatterGatherLimit), value); }

        [Offset(8UL)]
        public uint DmaAddressWidth { get => ReadHere<uint>(nameof(DmaAddressWidth)); set => WriteHere(nameof(DmaAddressWidth), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public uint MinimumTransferUnit { get => ReadHere<uint>(nameof(MinimumTransferUnit)); set => WriteHere(nameof(MinimumTransferUnit), value); }

        public DmaAdapterInfoV1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaAdapterInfoV1>();
        }
    }
}