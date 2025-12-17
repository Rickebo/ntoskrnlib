using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DOMAIN_SETTINGS")]
    public sealed class _EXT_IOMMU_DOMAIN_SETTINGS : DynamicStructure
    {
        public _EXT_IOMMU_S1_X64_DOMAIN_SETTINGS S1 { get; }
        public _unnamed_tag_ S2 { get; }

        public _EXT_IOMMU_DOMAIN_SETTINGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_DOMAIN_SETTINGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_DOMAIN_SETTINGS.S1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN_SETTINGS.S2),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_EXT_IOMMU_DOMAIN_SETTINGS>((mem, ptr) => new _EXT_IOMMU_DOMAIN_SETTINGS(mem, ptr), offsets);
        }
    }
}