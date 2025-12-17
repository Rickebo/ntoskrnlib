using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE")]
    public sealed class _EXT_IOMMU_DEVICE : DynamicStructure
    {
        public IntPtr Context { get; }
        public IntPtr Iommu { get; }
        public IntPtr Domain { get; }
        public ulong AssociatedDomainId { get; }
        public ushort FirmwareDomainId { get; }
        public byte FaultReportingEnabled { get; }
        public byte IsReservedDevice { get; }

        public _EXT_IOMMU_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_DEVICE.Context),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE.Iommu),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE.Domain),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE.AssociatedDomainId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE.FirmwareDomainId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE.FaultReportingEnabled),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE.IsReservedDevice),
                    new ulong[]
                    {
                        35UL
                    }
                }
            };
            Register<_EXT_IOMMU_DEVICE>((mem, ptr) => new _EXT_IOMMU_DEVICE(mem, ptr), offsets);
        }
    }
}