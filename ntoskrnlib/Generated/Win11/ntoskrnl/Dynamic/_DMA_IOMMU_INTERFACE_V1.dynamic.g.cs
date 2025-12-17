using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_IOMMU_INTERFACE_V1")]
    public sealed class _DMA_IOMMU_INTERFACE_V1 : DynamicStructure
    {
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

        public _DMA_IOMMU_INTERFACE_V1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_IOMMU_INTERFACE_V1()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.CreateDomain),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.DeleteDomain),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.AttachDevice),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.DetachDevice),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.FlushDomain),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.FlushDomainByVaList),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.QueryInputMappings),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.MapLogicalRange),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.UnmapLogicalRange),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.MapIdentityRange),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.UnmapIdentityRange),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.SetDeviceFaultReporting),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V1.ConfigureDomain),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_DMA_IOMMU_INTERFACE_V1>((mem, ptr) => new _DMA_IOMMU_INTERFACE_V1(mem, ptr), offsets);
        }
    }
}