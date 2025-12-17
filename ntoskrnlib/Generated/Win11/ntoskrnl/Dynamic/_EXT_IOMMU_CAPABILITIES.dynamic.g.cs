using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_CAPABILITIES")]
    public sealed class _EXT_IOMMU_CAPABILITIES : DynamicStructure
    {
        public ulong AsUINT64 { get; }
        public ulong GeneratesMsiInterrupts { get; }
        public ulong CoherentTableWalks { get; }
        public ulong InterruptsNotSubjectToRemapping { get; }
        public ulong InterruptRemapping { get; }
        public ulong Stage2DmaRemapping { get; }
        public ulong Svm { get; }
        public ulong PcieFunctionBased { get; }

        public _EXT_IOMMU_CAPABILITIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_CAPABILITIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_CAPABILITIES.AsUINT64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CAPABILITIES.GeneratesMsiInterrupts),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CAPABILITIES.CoherentTableWalks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CAPABILITIES.InterruptsNotSubjectToRemapping),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CAPABILITIES.InterruptRemapping),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CAPABILITIES.Stage2DmaRemapping),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CAPABILITIES.Svm),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CAPABILITIES.PcieFunctionBased),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EXT_IOMMU_CAPABILITIES>((mem, ptr) => new _EXT_IOMMU_CAPABILITIES(mem, ptr), offsets);
        }
    }
}