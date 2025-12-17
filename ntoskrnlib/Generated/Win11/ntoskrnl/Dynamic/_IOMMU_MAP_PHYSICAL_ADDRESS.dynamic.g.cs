using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_MAP_PHYSICAL_ADDRESS")]
    public sealed class _IOMMU_MAP_PHYSICAL_ADDRESS : DynamicStructure
    {
        public uint MapType { get; }
        public _unnamed_tag_ Mdl { get; }
        public _unnamed_tag_ ContiguousRange { get; }
        public _unnamed_tag_ PfnArray { get; }

        public _IOMMU_MAP_PHYSICAL_ADDRESS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_MAP_PHYSICAL_ADDRESS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_MAP_PHYSICAL_ADDRESS.MapType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_MAP_PHYSICAL_ADDRESS.Mdl),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_MAP_PHYSICAL_ADDRESS.ContiguousRange),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_MAP_PHYSICAL_ADDRESS.PfnArray),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IOMMU_MAP_PHYSICAL_ADDRESS>((mem, ptr) => new _IOMMU_MAP_PHYSICAL_ADDRESS(mem, ptr), offsets);
        }
    }
}