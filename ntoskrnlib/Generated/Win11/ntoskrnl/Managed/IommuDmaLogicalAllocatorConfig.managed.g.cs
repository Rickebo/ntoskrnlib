using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG")]
    public sealed class IommuDmaLogicalAllocatorConfig : DynamicStructure
    {
        [Offset(0UL)]
        public uint LogicalAllocatorType { get => ReadHere<uint>(nameof(LogicalAllocatorType)); set => WriteHere(nameof(LogicalAllocatorType), value); }

        [Offset(4UL)]
        public UnnamedTag BuddyAllocatorConfig { get => ReadStructure<UnnamedTag>(nameof(BuddyAllocatorConfig)); set => WriteStructure(nameof(BuddyAllocatorConfig), value); }

        public IommuDmaLogicalAllocatorConfig(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaLogicalAllocatorConfig>();
        }
    }
}