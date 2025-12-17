using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_FUNCTION_TABLE_EXTENDED")]
    public sealed class _EXT_IOMMU_FUNCTION_TABLE_EXTENDED : DynamicStructure
    {
        public IntPtr FindDevice { get; }
        public IntPtr SetDeviceSvmCapabilities { get; }
        public IntPtr SetDevicePasidTable { get; }
        public IntPtr GrowPasidTable { get; }
        public IntPtr SetPasidAddressSpace { get; }
        public IntPtr FlushTb { get; }
        public IntPtr FlushDeviceTbOnly { get; }
        public IntPtr DismissPageFault { get; }
        public IntPtr GetPageFault { get; }
        public IntPtr SetMessageInterruptRouting { get; }
        public IntPtr EnableInterrupt { get; }
        public IntPtr DisableInterrupt { get; }
        public IntPtr HandleInterrupt { get; }
        public IntPtr CheckForReservedRegion { get; }
        public IntPtr MarkHiberRegions { get; }
        public IntPtr DrainSvmPageRequests { get; }
        public IntPtr CancelPageRequests { get; }
        public IntPtr EnumerateReservedDevices { get; }
        public IntPtr ProcessReservedDomains { get; }
        public IntPtr QueryAcpiDeviceMapping { get; }
        public IntPtr GetRidAcpiMapCount { get; }
        public IntPtr ConfigureAts { get; }
        public IntPtr SetDeviceSvmCapabilitiesLegacy { get; }

        public _EXT_IOMMU_FUNCTION_TABLE_EXTENDED(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_FUNCTION_TABLE_EXTENDED()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.FindDevice),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.SetDeviceSvmCapabilities),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.SetDevicePasidTable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.GrowPasidTable),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.SetPasidAddressSpace),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.FlushTb),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.FlushDeviceTbOnly),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.DismissPageFault),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.GetPageFault),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.SetMessageInterruptRouting),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.EnableInterrupt),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.DisableInterrupt),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.HandleInterrupt),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.CheckForReservedRegion),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.MarkHiberRegions),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.DrainSvmPageRequests),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.CancelPageRequests),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.EnumerateReservedDevices),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.ProcessReservedDomains),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.QueryAcpiDeviceMapping),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.GetRidAcpiMapCount),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.ConfigureAts),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE_EXTENDED.SetDeviceSvmCapabilitiesLegacy),
                    new ulong[]
                    {
                        176UL
                    }
                }
            };
            Register<_EXT_IOMMU_FUNCTION_TABLE_EXTENDED>((mem, ptr) => new _EXT_IOMMU_FUNCTION_TABLE_EXTENDED(mem, ptr), offsets);
        }
    }
}