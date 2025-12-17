using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_REGISTERED_IOMMU")]
    public sealed class _REGISTERED_IOMMU : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr InternalData { get; }
        public uint InternalDataSize { get; }
        public IntPtr InterruptContext { get; }
        public byte Irql { get; }
        public int Gsi { get; }
        public uint InterruptPolarity { get; }
        public uint InterruptMode { get; }
        public _EXT_IOMMU_FUNCTION_TABLE FunctionTable { get; }
        public _EXT_IOMMU_FUNCTION_TABLE_EXTENDED FunctionTableExtended { get; }
        public uint Flags { get; }
        public _IOMMU_PAGE_HANDLING_DATA PageHandling { get; }
        public uint MaximumDomainIds { get; }
        public ulong DomainIdBitmapLock { get; }
        public _RTL_BITMAP DomainIdBitmap { get; }
        public uint Capabilities { get; }
        public uint KnownType { get; }
        public uint PciSegment { get; }
        public uint PciBus { get; }
        public _PCI_SLOT_NUMBER PciSlot { get; }
        public _LARGE_INTEGER MsiAddress { get; }
        public ulong MsiData { get; }
        public uint MaximumAsids { get; }
        public uint Identifier { get; }
        public _UNICODE_STRING ResourceId { get; }
        public IntPtr ReservedDevices { get; }

        public _REGISTERED_IOMMU(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _REGISTERED_IOMMU()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_REGISTERED_IOMMU.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.InternalData),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.InternalDataSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.InterruptContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.Irql),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.Gsi),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.InterruptPolarity),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.InterruptMode),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.FunctionTable),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.FunctionTableExtended),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.Flags),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.PageHandling),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.MaximumDomainIds),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.DomainIdBitmapLock),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.DomainIdBitmap),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.Capabilities),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.KnownType),
                    new ulong[]
                    {
                        476UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.PciSegment),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.PciBus),
                    new ulong[]
                    {
                        484UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.PciSlot),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.MsiAddress),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.MsiData),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.MaximumAsids),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.Identifier),
                    new ulong[]
                    {
                        516UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.ResourceId),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_REGISTERED_IOMMU.ReservedDevices),
                    new ulong[]
                    {
                        536UL
                    }
                }
            };
            Register<_REGISTERED_IOMMU>((mem, ptr) => new _REGISTERED_IOMMU(mem, ptr), offsets);
        }
    }
}