using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOMMU_TRACKED_DEVICE")]
    public sealed class _IOMMU_TRACKED_DEVICE : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public ulong Lock { get; }
        public IntPtr Iommu { get; }
        public uint IommuCapabilities { get; }
        public uint ReferenceCount { get; }
        public ulong SourceId { get; }
        public _IOMMU_SVM_CAPABILITIES Capabilities { get; }
        public uint Flags { get; }
        public _LIST_ENTRY ActiveDeviceListHead { get; }
        public IntPtr DmaDevice { get; }
        public uint LastGroupFaultSequenceNumber { get; }
        public byte[] GroupFaultReferences { get; }

        public _IOMMU_TRACKED_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOMMU_TRACKED_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOMMU_TRACKED_DEVICE.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.Iommu),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.IommuCapabilities),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.ReferenceCount),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.SourceId),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.Capabilities),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.Flags),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.ActiveDeviceListHead),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.DmaDevice),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.LastGroupFaultSequenceNumber),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_IOMMU_TRACKED_DEVICE.GroupFaultReferences),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_IOMMU_TRACKED_DEVICE>((mem, ptr) => new _IOMMU_TRACKED_DEVICE(mem, ptr), offsets);
        }
    }
}