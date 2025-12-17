using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1")]
    public sealed class IommuDmaLogicalAllocatorOperationsV1 : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr AllocateLogicalAddress { get => ReadHere<IntPtr>(nameof(AllocateLogicalAddress)); set => WriteHere(nameof(AllocateLogicalAddress), value); }

        [Offset(8UL)]
        public IntPtr FreeLogicalAddress { get => ReadHere<IntPtr>(nameof(FreeLogicalAddress)); set => WriteHere(nameof(FreeLogicalAddress), value); }

        [Offset(16UL)]
        public IntPtr ReserveLogicalAddress { get => ReadHere<IntPtr>(nameof(ReserveLogicalAddress)); set => WriteHere(nameof(ReserveLogicalAddress), value); }

        [Offset(24UL)]
        public IntPtr QueryCapabilities { get => ReadHere<IntPtr>(nameof(QueryCapabilities)); set => WriteHere(nameof(QueryCapabilities), value); }

        [Offset(32UL)]
        public IntPtr CleanUp { get => ReadHere<IntPtr>(nameof(CleanUp)); set => WriteHere(nameof(CleanUp), value); }

        public IommuDmaLogicalAllocatorOperationsV1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaLogicalAllocatorOperationsV1>();
        }
    }
}