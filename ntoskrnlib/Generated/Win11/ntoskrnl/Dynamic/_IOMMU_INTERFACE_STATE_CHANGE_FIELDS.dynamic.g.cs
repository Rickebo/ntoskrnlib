using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_INTERFACE_STATE_CHANGE_FIELDS")]
    public sealed class _IOMMU_INTERFACE_STATE_CHANGE_FIELDS : DynamicStructure
    {
        public uint AvailableDomainTypes { get; }
        public uint Reserved { get; }
        public uint AsULONG { get; }

        public _IOMMU_INTERFACE_STATE_CHANGE_FIELDS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_INTERFACE_STATE_CHANGE_FIELDS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_INTERFACE_STATE_CHANGE_FIELDS.AvailableDomainTypes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_INTERFACE_STATE_CHANGE_FIELDS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_INTERFACE_STATE_CHANGE_FIELDS.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_IOMMU_INTERFACE_STATE_CHANGE_FIELDS>((mem, ptr) => new _IOMMU_INTERFACE_STATE_CHANGE_FIELDS(mem, ptr), offsets);
        }
    }
}