using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_TRANSFER_CONTEXT")]
    public sealed class DmaTransferContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public DmaTransferContextV1 V1 { get => ReadStructure<DmaTransferContextV1>(nameof(V1)); set => WriteStructure(nameof(V1), value); }

        public DmaTransferContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaTransferContext>();
        }
    }
}