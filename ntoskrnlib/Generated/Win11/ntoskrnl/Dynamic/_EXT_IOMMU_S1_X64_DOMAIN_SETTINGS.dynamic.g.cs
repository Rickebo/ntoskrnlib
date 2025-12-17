using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_S1_X64_DOMAIN_SETTINGS")]
    public sealed class _EXT_IOMMU_S1_X64_DOMAIN_SETTINGS : DynamicStructure
    {
        public _unnamed_tag_ Flags { get; }
        public ulong PageTableRoot { get; }

        public _EXT_IOMMU_S1_X64_DOMAIN_SETTINGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_S1_X64_DOMAIN_SETTINGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_S1_X64_DOMAIN_SETTINGS.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_S1_X64_DOMAIN_SETTINGS.PageTableRoot),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EXT_IOMMU_S1_X64_DOMAIN_SETTINGS>((mem, ptr) => new _EXT_IOMMU_S1_X64_DOMAIN_SETTINGS(mem, ptr), offsets);
        }
    }
}