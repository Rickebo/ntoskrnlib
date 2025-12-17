using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_IOMMU_INTERFACE")]
    public sealed class _DMA_IOMMU_INTERFACE : DynamicStructure
    {
        public uint Version { get; }
        public IntPtr CreateDomain { get; }
        public IntPtr DeleteDomain { get; }
        public IntPtr AttachDevice { get; }
        public IntPtr DetachDevice { get; }
        public IntPtr FlushDomain { get; }
        public IntPtr FlushDomainByVaList { get; }
        public IntPtr QueryInputMappings { get; }
        public IntPtr MapLogicalRange { get; }
        public IntPtr UnmapLogicalRange { get; }
        public IntPtr MapIdentityRange { get; }
        public IntPtr UnmapIdentityRange { get; }
        public IntPtr SetDeviceFaultReporting { get; }
        public IntPtr ConfigureDomain { get; }

        public _DMA_IOMMU_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_IOMMU_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_IOMMU_INTERFACE.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.CreateDomain),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.DeleteDomain),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.AttachDevice),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.DetachDevice),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.FlushDomain),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.FlushDomainByVaList),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.QueryInputMappings),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.MapLogicalRange),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.UnmapLogicalRange),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.MapIdentityRange),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.UnmapIdentityRange),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.SetDeviceFaultReporting),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE.ConfigureDomain),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_DMA_IOMMU_INTERFACE>((mem, ptr) => new _DMA_IOMMU_INTERFACE(mem, ptr), offsets);
        }
    }
}