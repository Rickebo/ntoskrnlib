using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_INTERFACE_STATE_CHANGE")]
    public sealed class _IOMMU_INTERFACE_STATE_CHANGE : DynamicStructure
    {
        public _IOMMU_INTERFACE_STATE_CHANGE_FIELDS PresentFields { get; }
        public uint AvailableDomainTypes { get; }

        public _IOMMU_INTERFACE_STATE_CHANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_INTERFACE_STATE_CHANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_INTERFACE_STATE_CHANGE.PresentFields),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_INTERFACE_STATE_CHANGE.AvailableDomainTypes),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_IOMMU_INTERFACE_STATE_CHANGE>((mem, ptr) => new _IOMMU_INTERFACE_STATE_CHANGE(mem, ptr), offsets);
        }
    }
}