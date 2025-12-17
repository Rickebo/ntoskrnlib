using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_SETTINGS")]
    public sealed class _EXT_IOMMU_SETTINGS : DynamicStructure
    {
        public _unnamed_tag_ EnabledCapabilities { get; }
        public uint TranslationPolicy { get; }
        public uint RemappingPolicy { get; }
        public uint RemappingTableEntries { get; }

        public _EXT_IOMMU_SETTINGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_SETTINGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_SETTINGS.EnabledCapabilities),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_SETTINGS.TranslationPolicy),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_SETTINGS.RemappingPolicy),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_SETTINGS.RemappingTableEntries),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_EXT_IOMMU_SETTINGS>((mem, ptr) => new _EXT_IOMMU_SETTINGS(mem, ptr), offsets);
        }
    }
}