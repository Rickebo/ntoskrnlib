using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID_PCI")]
    public sealed class _EXT_IOMMU_DEVICE_ID_PCI : DynamicStructure
    {
        public ulong AsUINT64 { get; }
        public ushort PciSegmentNumber { get; }
        public ushort PhantomFunctionBits { get; }
        public ushort Reserved { get; }
        public ushort StartBusNumber { get; }
        public ushort Bdf { get; }
        public ushort DevicePathLength { get; }
        public IntPtr DevicePath { get; }

        public _EXT_IOMMU_DEVICE_ID_PCI(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_IOMMU_DEVICE_ID_PCI()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_PCI.AsUINT64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_PCI.PciSegmentNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_PCI.PhantomFunctionBits),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_PCI.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_PCI.StartBusNumber),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_PCI.Bdf),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_PCI.DevicePathLength),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_EXT_IOMMU_DEVICE_ID_PCI.DevicePath),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EXT_IOMMU_DEVICE_ID_PCI>((mem, ptr) => new _EXT_IOMMU_DEVICE_ID_PCI(mem, ptr), offsets);
        }
    }
}