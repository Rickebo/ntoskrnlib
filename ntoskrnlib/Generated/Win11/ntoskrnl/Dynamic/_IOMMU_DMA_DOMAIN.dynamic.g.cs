using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_DOMAIN")]
    public sealed class _IOMMU_DMA_DOMAIN : DynamicStructure
    {
        public IntPtr DmaDomainOwner { get; }
        public uint DomainType { get; }
        public uint TranslationType { get; }
        public _LIST_ENTRY HardwareDomainListHead { get; }
        public ulong HardwareDomainListLock { get; }
        public IntPtr DmarptState { get; }
        public uint DomainId { get; }
        public byte IsStage1 { get; }
        public uint Asid { get; }
        public IntPtr LogicalAllocator { get; }
        public _LIST_ENTRY AttachedDevicesList { get; }
        public int AttachedDevicesListLock { get; }
        public uint HvReferences { get; }
        public byte HvDomainIdAllocated { get; }
        public _EX_PUSH_LOCK HvPushLock { get; }

        public _IOMMU_DMA_DOMAIN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DMA_DOMAIN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DMA_DOMAIN.DmaDomainOwner),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.DomainType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.TranslationType),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.HardwareDomainListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.HardwareDomainListLock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.DmarptState),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.DomainId),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.IsStage1),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.Asid),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.LogicalAllocator),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.AttachedDevicesList),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.AttachedDevicesListLock),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.HvReferences),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.HvDomainIdAllocated),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_IOMMU_DMA_DOMAIN.HvPushLock),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_IOMMU_DMA_DOMAIN>((mem, ptr) => new _IOMMU_DMA_DOMAIN(mem, ptr), offsets);
        }
    }
}