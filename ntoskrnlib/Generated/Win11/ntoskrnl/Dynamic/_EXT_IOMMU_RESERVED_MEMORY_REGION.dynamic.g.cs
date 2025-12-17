using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_RESERVED_MEMORY_REGION")]
    public sealed class _EXT_IOMMU_RESERVED_MEMORY_REGION : DynamicStructure
    {
        public _LARGE_INTEGER Base { get; }
        public _LARGE_INTEGER Limit { get; }
        public byte Ignored { get; }

        public _EXT_IOMMU_RESERVED_MEMORY_REGION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_RESERVED_MEMORY_REGION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_RESERVED_MEMORY_REGION.Base),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_RESERVED_MEMORY_REGION.Limit),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_RESERVED_MEMORY_REGION.Ignored),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_EXT_IOMMU_RESERVED_MEMORY_REGION>((mem, ptr) => new _EXT_IOMMU_RESERVED_MEMORY_REGION(mem, ptr), offsets);
        }
    }
}