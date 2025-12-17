using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_DEVICE_PROPERTIES")]
    public sealed class _IOMMU_DEVICE_PROPERTIES : DynamicStructure
    {
        public uint IsThunderbolt { get; }
        public uint DmaCapableAtBoot { get; }
        public uint ForceDisableDmaRemapping { get; }
        public uint IsUntrustedPort { get; }
        public uint ForceEnableDmaRemapping { get; }
        public uint Rsvd { get; }
        public uint AsULONG { get; }

        public _IOMMU_DEVICE_PROPERTIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_DEVICE_PROPERTIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_DEVICE_PROPERTIES.IsThunderbolt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_PROPERTIES.DmaCapableAtBoot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_PROPERTIES.ForceDisableDmaRemapping),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_PROPERTIES.IsUntrustedPort),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_PROPERTIES.ForceEnableDmaRemapping),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_PROPERTIES.Rsvd),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_DEVICE_PROPERTIES.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_IOMMU_DEVICE_PROPERTIES>((mem, ptr) => new _IOMMU_DEVICE_PROPERTIES(mem, ptr), offsets);
        }
    }
}