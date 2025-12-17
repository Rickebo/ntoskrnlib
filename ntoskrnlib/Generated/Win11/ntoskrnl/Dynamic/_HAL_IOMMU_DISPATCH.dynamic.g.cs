using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_IOMMU_DISPATCH")]
    public sealed class _HAL_IOMMU_DISPATCH : DynamicStructure
    {
        public IntPtr HalIommuSupportEnabled { get; }
        public IntPtr HalIommuGetConfiguration { get; }
        public IntPtr HalIommuGetLibraryContext { get; }
        public IntPtr HalIommuMapDevice { get; }
        public IntPtr HalIommuEnableDevicePasid { get; }
        public IntPtr HalIommuSetAddressSpace { get; }
        public IntPtr HalIommuDisableDevicePasid { get; }
        public IntPtr HalIommuUnmapDevice { get; }
        public IntPtr HalIommuFreeLibraryContext { get; }
        public IntPtr HalIommuFlushTb { get; }
        public IntPtr HalIommuFlushAllPasid { get; }
        public IntPtr HalIommuProcessPageRequestQueue { get; }
        public IntPtr HalIommuFaultRoutine { get; }
        public IntPtr HalIommuReferenceAsid { get; }
        public IntPtr HalIommuDereferenceAsid { get; }
        public IntPtr HalIommuServicePageFault { get; }
        public IntPtr HalIommuDevicePowerChange { get; }
        public IntPtr HalIommuBeginDeviceReset { get; }
        public IntPtr HalIommuFinalizeDeviceReset { get; }
        public IntPtr HalIommuGetAtsSettings { get; }
        public IntPtr HalIommuCreateAtsDevice { get; }
        public IntPtr HalIommuDeleteAtsDevice { get; }
        public IntPtr HalIommuGetDomainTransitionSupport { get; }
        public IntPtr HalIommuSetDeviceMpam { get; }
        public IntPtr HalIommuGetDeviceMpam { get; }

        public _HAL_IOMMU_DISPATCH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_IOMMU_DISPATCH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuSupportEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuGetConfiguration),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuGetLibraryContext),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuMapDevice),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuEnableDevicePasid),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuSetAddressSpace),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuDisableDevicePasid),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuUnmapDevice),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuFreeLibraryContext),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuFlushTb),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuFlushAllPasid),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuProcessPageRequestQueue),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuFaultRoutine),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuReferenceAsid),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuDereferenceAsid),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuServicePageFault),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuDevicePowerChange),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuBeginDeviceReset),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuFinalizeDeviceReset),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuGetAtsSettings),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuCreateAtsDevice),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuDeleteAtsDevice),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuGetDomainTransitionSupport),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuSetDeviceMpam),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_HAL_IOMMU_DISPATCH.HalIommuGetDeviceMpam),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_HAL_IOMMU_DISPATCH>((mem, ptr) => new _HAL_IOMMU_DISPATCH(mem, ptr), offsets);
        }
    }
}