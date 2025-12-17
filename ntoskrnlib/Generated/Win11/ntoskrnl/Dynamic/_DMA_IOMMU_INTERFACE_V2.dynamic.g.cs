using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_IOMMU_INTERFACE_V2")]
    public sealed class _DMA_IOMMU_INTERFACE_V2 : DynamicStructure
    {
        public IntPtr CreateDomainEx { get; }
        public IntPtr DeleteDomain { get; }
        public IntPtr AttachDeviceEx { get; }
        public IntPtr DetachDeviceEx { get; }
        public IntPtr FlushDomain { get; }
        public IntPtr FlushDomainByVaList { get; }
        public IntPtr QueryInputMappings { get; }
        public IntPtr MapLogicalRangeEx { get; }
        public IntPtr UnmapLogicalRange { get; }
        public IntPtr MapIdentityRangeEx { get; }
        public IntPtr UnmapIdentityRangeEx { get; }
        public IntPtr SetDeviceFaultReportingEx { get; }
        public IntPtr ConfigureDomain { get; }
        public IntPtr QueryAvailableDomainTypes { get; }
        public IntPtr RegisterInterfaceStateChangeCallback { get; }
        public IntPtr UnregisterInterfaceStateChangeCallback { get; }
        public IntPtr ReserveLogicalAddressRange { get; }
        public IntPtr FreeReservedLogicalAddressRange { get; }
        public IntPtr MapReservedLogicalRange { get; }
        public IntPtr UnmapReservedLogicalRange { get; }
        public IntPtr CreateDevice { get; }
        public IntPtr DeleteDevice { get; }

        public _DMA_IOMMU_INTERFACE_V2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_IOMMU_INTERFACE_V2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.CreateDomainEx),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.DeleteDomain),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.AttachDeviceEx),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.DetachDeviceEx),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.FlushDomain),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.FlushDomainByVaList),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.QueryInputMappings),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.MapLogicalRangeEx),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.UnmapLogicalRange),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.MapIdentityRangeEx),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.UnmapIdentityRangeEx),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.SetDeviceFaultReportingEx),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.ConfigureDomain),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.QueryAvailableDomainTypes),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.RegisterInterfaceStateChangeCallback),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.UnregisterInterfaceStateChangeCallback),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.ReserveLogicalAddressRange),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.FreeReservedLogicalAddressRange),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.MapReservedLogicalRange),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.UnmapReservedLogicalRange),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.CreateDevice),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_DMA_IOMMU_INTERFACE_V2.DeleteDevice),
                    new ulong[]
                    {
                        168UL
                    }
                }
            };
            Register<_DMA_IOMMU_INTERFACE_V2>((mem, ptr) => new _DMA_IOMMU_INTERFACE_V2(mem, ptr), offsets);
        }
    }
}