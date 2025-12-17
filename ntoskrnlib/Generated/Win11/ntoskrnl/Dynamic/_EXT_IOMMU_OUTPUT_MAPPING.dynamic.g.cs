using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_OUTPUT_MAPPING")]
    public sealed class _EXT_IOMMU_OUTPUT_MAPPING : DynamicStructure
    {
        public ulong OutputId { get; }

        public _EXT_IOMMU_OUTPUT_MAPPING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_OUTPUT_MAPPING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_OUTPUT_MAPPING.OutputId),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EXT_IOMMU_OUTPUT_MAPPING>((mem, ptr) => new _EXT_IOMMU_OUTPUT_MAPPING(mem, ptr), offsets);
        }
    }
}