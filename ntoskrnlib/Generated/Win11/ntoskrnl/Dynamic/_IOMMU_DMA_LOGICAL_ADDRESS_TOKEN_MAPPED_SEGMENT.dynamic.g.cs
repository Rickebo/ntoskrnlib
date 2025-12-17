using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT")]
    public sealed class _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT : DynamicStructure
    {
        public IntPtr OwningToken { get; }
        public ulong Offset { get; }
        public ulong Size { get; }

        public _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT.OwningToken),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT.Offset),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT.Size),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT>((mem, ptr) => new _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT(mem, ptr), offsets);
        }
    }
}