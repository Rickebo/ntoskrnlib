using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_SVM_CAPABILITIES")]
    public sealed class _IOMMU_SVM_CAPABILITIES : DynamicStructure
    {
        public uint AtsCapability { get; }
        public uint PriCapability { get; }
        public uint PasidCapability { get; }
        public uint Rsvd0 { get; }
        public _unnamed_tag_ CapReg { get; }
        public _unnamed_tag_ EnabledCaps { get; }
        public _unnamed_tag_ DeviceInformation { get; }
        public uint AtsPriPasidBits { get; }
        public uint CapRegBits { get; }
        public uint EnabledCapsBits { get; }
        public uint DeviceInformationBits { get; }
        public uint Rsvd1 { get; }
        public uint AsULONG { get; }

        public _IOMMU_SVM_CAPABILITIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_SVM_CAPABILITIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.AtsCapability),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.PriCapability),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.PasidCapability),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.Rsvd0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.CapReg),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.EnabledCaps),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.DeviceInformation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.AtsPriPasidBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.CapRegBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.EnabledCapsBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.DeviceInformationBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.Rsvd1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_SVM_CAPABILITIES.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_IOMMU_SVM_CAPABILITIES>((mem, ptr) => new _IOMMU_SVM_CAPABILITIES(mem, ptr), offsets);
        }
    }
}