using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_ATS_SETTINGS")]
    public sealed class _IOMMU_ATS_SETTINGS : DynamicStructure
    {
        public byte AtsSupported { get; }
        public byte AtsRequired { get; }
        public byte Rsvd { get; }
        public byte AsUCHAR { get; }

        public _IOMMU_ATS_SETTINGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_ATS_SETTINGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_ATS_SETTINGS.AtsSupported),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_ATS_SETTINGS.AtsRequired),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_ATS_SETTINGS.Rsvd),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_ATS_SETTINGS.AsUCHAR),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_IOMMU_ATS_SETTINGS>((mem, ptr) => new _IOMMU_ATS_SETTINGS(mem, ptr), offsets);
        }
    }
}