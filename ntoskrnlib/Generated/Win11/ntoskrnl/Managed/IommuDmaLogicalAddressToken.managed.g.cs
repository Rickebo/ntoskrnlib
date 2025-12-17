using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN")]
    public sealed class IommuDmaLogicalAddressToken : DynamicStructure
    {
        [Offset(0UL)]
        public ulong LogicalAddressBase { get => ReadHere<ulong>(nameof(LogicalAddressBase)); set => WriteHere(nameof(LogicalAddressBase), value); }

        [Offset(8UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        public IommuDmaLogicalAddressToken(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaLogicalAddressToken>();
        }
    }
}