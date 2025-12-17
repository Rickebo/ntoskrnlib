using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID_TEST")]
    public sealed class _EXT_IOMMU_DEVICE_ID_TEST : DynamicStructure
    {
        public ulong UniqueId { get; }

        public _EXT_IOMMU_DEVICE_ID_TEST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_DEVICE_ID_TEST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_TEST.UniqueId),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EXT_IOMMU_DEVICE_ID_TEST>((mem, ptr) => new _EXT_IOMMU_DEVICE_ID_TEST(mem, ptr), offsets);
        }
    }
}