using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_FUNCTION_TABLE")]
    public sealed class _EXT_IOMMU_FUNCTION_TABLE : DynamicStructure
    {
        public IntPtr ConfigureSettings { get; }
        public IntPtr Initialize { get; }
        public IntPtr AllocateDomain { get; }
        public IntPtr FreeDomain { get; }
        public IntPtr CreateDevice { get; }
        public IntPtr DeleteDevice { get; }
        public IntPtr OwnDevice { get; }
        public IntPtr ConfigureDeviceFaultReporting { get; }
        public IntPtr AttachDeviceDomain { get; }
        public IntPtr DetachDeviceDomain { get; }
        public IntPtr FlushDomainTb { get; }
        public IntPtr SyncFlush { get; }
        public IntPtr CompleteFlush { get; }
        public IntPtr AllocateRemappingTableEntry { get; }
        public IntPtr FreeRemappingTableEntry { get; }
        public IntPtr UpdateRemappingTableEntry { get; }
        public IntPtr InvalidateRemappingTableEntry { get; }
        public IntPtr UpdateRemappingDestination { get; }
        public IntPtr CaptureGlobalCrashdumpState { get; }

        public _EXT_IOMMU_FUNCTION_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_FUNCTION_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.ConfigureSettings),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.Initialize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.AllocateDomain),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.FreeDomain),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.CreateDevice),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.DeleteDevice),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.OwnDevice),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.ConfigureDeviceFaultReporting),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.AttachDeviceDomain),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.DetachDeviceDomain),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.FlushDomainTb),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.SyncFlush),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.CompleteFlush),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.AllocateRemappingTableEntry),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.FreeRemappingTableEntry),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.UpdateRemappingTableEntry),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.InvalidateRemappingTableEntry),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.UpdateRemappingDestination),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_FUNCTION_TABLE.CaptureGlobalCrashdumpState),
                    new ulong[]
                    {
                        144UL
                    }
                }
            };
            Register<_EXT_IOMMU_FUNCTION_TABLE>((mem, ptr) => new _EXT_IOMMU_FUNCTION_TABLE(mem, ptr), offsets);
        }
    }
}