using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ALLOCATOR")]
    public sealed class IommuDmaLogicalAllocator : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Operations { get => ReadHere<IntPtr>(nameof(Operations)); set => WriteHere(nameof(Operations), value); }

        [Offset(8UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(12UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(16UL)]
        public uint AllocatorType { get => ReadHere<uint>(nameof(AllocatorType)); set => WriteHere(nameof(AllocatorType), value); }

        public IommuDmaLogicalAllocator(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaLogicalAllocator>();
        }
    }
}