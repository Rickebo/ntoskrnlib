using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_TRANSFER_INFO")]
    public sealed class DmaTransferInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public DmaTransferInfoV1 V1 { get => ReadStructure<DmaTransferInfoV1>(nameof(V1)); set => WriteStructure(nameof(V1), value); }

        [Offset(4UL)]
        public DmaTransferInfoV2 V2 { get => ReadStructure<DmaTransferInfoV2>(nameof(V2)); set => WriteStructure(nameof(V2), value); }

        public DmaTransferInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaTransferInfo>();
        }
    }
}