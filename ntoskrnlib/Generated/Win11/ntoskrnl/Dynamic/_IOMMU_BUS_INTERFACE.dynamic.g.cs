using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_BUS_INTERFACE")]
    public sealed class _IOMMU_BUS_INTERFACE : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public IntPtr Context { get; }
        public IntPtr InterfaceReference { get; }
        public IntPtr InterfaceDereference { get; }
        public IntPtr GetSvmCapabilities { get; }
        public IntPtr EnableSvmCapabilities { get; }
        public IntPtr DisableSvmCapabilities { get; }
        public IntPtr GetDeviceProperties { get; }
        public IntPtr GetDeviceId { get; }
        public IntPtr GetRootDevice { get; }

        public _IOMMU_BUS_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_BUS_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_BUS_INTERFACE.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.Context),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.InterfaceReference),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.InterfaceDereference),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.GetSvmCapabilities),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.EnableSvmCapabilities),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.DisableSvmCapabilities),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.GetDeviceProperties),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.GetDeviceId),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IOMMU_BUS_INTERFACE.GetRootDevice),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_IOMMU_BUS_INTERFACE>((mem, ptr) => new _IOMMU_BUS_INTERFACE(mem, ptr), offsets);
        }
    }
}