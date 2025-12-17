using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT")]
    public sealed class IommuDmaLogicalAddressTokenMappedSegment : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr OwningToken { get => ReadHere<IntPtr>(nameof(OwningToken)); set => WriteHere(nameof(OwningToken), value); }

        [Offset(8UL)]
        public ulong Offset { get => ReadHere<ulong>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(16UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        public IommuDmaLogicalAddressTokenMappedSegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaLogicalAddressTokenMappedSegment>();
        }
    }
}