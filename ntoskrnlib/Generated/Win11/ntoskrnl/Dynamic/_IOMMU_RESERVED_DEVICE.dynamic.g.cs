using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_RESERVED_DEVICE")]
    public sealed class _IOMMU_RESERVED_DEVICE : DynamicStructure
    {
        public IntPtr DeviceId { get; }
        public IntPtr PageTable { get; }
        public _LARGE_INTEGER PageTablePhysical { get; }
        public IntPtr ExtDevice { get; }
        public uint RegionCount { get; }
        public byte[] Regions { get; }

        public _IOMMU_RESERVED_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_RESERVED_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_RESERVED_DEVICE.DeviceId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_RESERVED_DEVICE.PageTable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_RESERVED_DEVICE.PageTablePhysical),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_RESERVED_DEVICE.ExtDevice),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_RESERVED_DEVICE.RegionCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IOMMU_RESERVED_DEVICE.Regions),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_IOMMU_RESERVED_DEVICE>((mem, ptr) => new _IOMMU_RESERVED_DEVICE(mem, ptr), offsets);
        }
    }
}