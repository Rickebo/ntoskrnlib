using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID_FLAGS")]
    public sealed class _EXT_IOMMU_DEVICE_ID_FLAGS : DynamicStructure
    {
        public ushort AsUSHORT { get; }
        public ushort IsAliased { get; }
        public ushort Reserved { get; }

        public _EXT_IOMMU_DEVICE_ID_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_DEVICE_ID_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_FLAGS.AsUSHORT),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_FLAGS.IsAliased),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EXT_IOMMU_DEVICE_ID_FLAGS>((mem, ptr) => new _EXT_IOMMU_DEVICE_ID_FLAGS(mem, ptr), offsets);
        }
    }
}