using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_RESERVED_DEVICE_LIST")]
    public sealed class _IOMMU_RESERVED_DEVICE_LIST : DynamicStructure
    {
        public uint Count { get; }
        public byte[] Devices { get; }

        public _IOMMU_RESERVED_DEVICE_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_RESERVED_DEVICE_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_RESERVED_DEVICE_LIST.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_RESERVED_DEVICE_LIST.Devices),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IOMMU_RESERVED_DEVICE_LIST>((mem, ptr) => new _IOMMU_RESERVED_DEVICE_LIST(mem, ptr), offsets);
        }
    }
}