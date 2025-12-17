using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_PAGE_HANDLING_DATA")]
    public sealed class _IOMMU_PAGE_HANDLING_DATA : DynamicStructure
    {
        public _EX_PUSH_LOCK ResetLock { get; }
        public ulong Lock { get; }
        public uint ValidGroupFaultSequenceNumber { get; }
        public IntPtr GetPageFault { get; }
        public IntPtr DismissPageFault { get; }

        public _IOMMU_PAGE_HANDLING_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_PAGE_HANDLING_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_PAGE_HANDLING_DATA.ResetLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_PAGE_HANDLING_DATA.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_PAGE_HANDLING_DATA.ValidGroupFaultSequenceNumber),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_PAGE_HANDLING_DATA.GetPageFault),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_PAGE_HANDLING_DATA.DismissPageFault),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_IOMMU_PAGE_HANDLING_DATA>((mem, ptr) => new _IOMMU_PAGE_HANDLING_DATA(mem, ptr), offsets);
        }
    }
}