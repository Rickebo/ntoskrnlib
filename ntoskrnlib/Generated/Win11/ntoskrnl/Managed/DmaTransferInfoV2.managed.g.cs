using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_TRANSFER_INFO_V2")]
    public sealed class DmaTransferInfoV2 : DynamicStructure
    {
        [Offset(0UL)]
        public uint MapRegisterCount { get => ReadHere<uint>(nameof(MapRegisterCount)); set => WriteHere(nameof(MapRegisterCount), value); }

        [Offset(4UL)]
        public uint ScatterGatherElementCount { get => ReadHere<uint>(nameof(ScatterGatherElementCount)); set => WriteHere(nameof(ScatterGatherElementCount), value); }

        [Offset(8UL)]
        public uint ScatterGatherListSize { get => ReadHere<uint>(nameof(ScatterGatherListSize)); set => WriteHere(nameof(ScatterGatherListSize), value); }

        [Offset(12UL)]
        public uint LogicalPageCount { get => ReadHere<uint>(nameof(LogicalPageCount)); set => WriteHere(nameof(LogicalPageCount), value); }

        public DmaTransferInfoV2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaTransferInfoV2>();
        }
    }
}