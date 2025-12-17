using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_CREATE_DEVICE_FLAGS")]
    public sealed class _EXT_IOMMU_CREATE_DEVICE_FLAGS : DynamicStructure
    {
        public uint AsUINT32 { get; }
        public uint WildCard { get; }
        public uint ForceCreate { get; }
        public uint LiveTraffic { get; }
        public uint DeviceIsReserved { get; }
        public uint Reserved { get; }

        public _EXT_IOMMU_CREATE_DEVICE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_CREATE_DEVICE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_CREATE_DEVICE_FLAGS.AsUINT32),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CREATE_DEVICE_FLAGS.WildCard),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CREATE_DEVICE_FLAGS.ForceCreate),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CREATE_DEVICE_FLAGS.LiveTraffic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CREATE_DEVICE_FLAGS.DeviceIsReserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_CREATE_DEVICE_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EXT_IOMMU_CREATE_DEVICE_FLAGS>((mem, ptr) => new _EXT_IOMMU_CREATE_DEVICE_FLAGS(mem, ptr), offsets);
        }
    }
}