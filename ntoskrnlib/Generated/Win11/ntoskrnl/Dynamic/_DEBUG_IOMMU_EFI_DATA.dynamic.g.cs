using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEBUG_IOMMU_EFI_DATA")]
    public sealed class _DEBUG_IOMMU_EFI_DATA : DynamicStructure
    {
        public IntPtr PciIoProtocolHandle { get; }
        public IntPtr Mapping { get; }

        public _DEBUG_IOMMU_EFI_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEBUG_IOMMU_EFI_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEBUG_IOMMU_EFI_DATA.PciIoProtocolHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEBUG_IOMMU_EFI_DATA.Mapping),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DEBUG_IOMMU_EFI_DATA>((mem, ptr) => new _DEBUG_IOMMU_EFI_DATA(mem, ptr), offsets);
        }
    }
}