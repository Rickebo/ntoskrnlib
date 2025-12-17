using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DOMAIN")]
    public sealed class _EXT_IOMMU_DOMAIN : DynamicStructure
    {
        public uint DomainType { get; }
        public uint TranslationType { get; }
        public _unnamed_tag_ Flags { get; }
        public ushort FirmwareDomainId { get; }
        public _EXT_IOMMU_DOMAIN_SETTINGS Settings { get; }
        public uint ContextId { get; }
        public uint DeviceCount { get; }
        public _LIST_ENTRY Devices { get; }
        public _EXT_ENV_SPINLOCK Lock { get; }
        public IntPtr S2Domain { get; }

        public _EXT_IOMMU_DOMAIN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_DOMAIN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_DOMAIN.DomainType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.TranslationType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.FirmwareDomainId),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.Settings),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.ContextId),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.DeviceCount),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.Devices),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.Lock),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DOMAIN.S2Domain),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_EXT_IOMMU_DOMAIN>((mem, ptr) => new _EXT_IOMMU_DOMAIN(mem, ptr), offsets);
        }
    }
}