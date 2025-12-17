using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEBUG_DEVICE_DESCRIPTOR")]
    public sealed class _DEBUG_DEVICE_DESCRIPTOR : DynamicStructure
    {
        public uint Bus { get; }
        public uint Slot { get; }
        public ushort Segment { get; }
        public ushort VendorID { get; }
        public ushort DeviceID { get; }
        public byte BaseClass { get; }
        public byte SubClass { get; }
        public byte ProgIf { get; }
        public byte Flags { get; }
        public byte DbgHalScratchAllocated { get; }
        public byte DbgBarsMapped { get; }
        public byte DbgScratchAllocated { get; }
        public byte DbgUncachedMemory { get; }
        public byte DbgSynthetic { get; }
        public byte Initialized { get; }
        public byte Configured { get; }
        public byte[] BaseAddress { get; }
        public DEBUG_MEMORY_REQUIREMENTS Memory { get; }
        public uint Dbg2TableIndex { get; }
        public ushort PortType { get; }
        public ushort PortSubtype { get; }
        public IntPtr OemData { get; }
        public uint OemDataLength { get; }
        public uint NameSpace { get; }
        public IntPtr NameSpacePath { get; }
        public uint NameSpacePathLength { get; }
        public uint TransportType { get; }
        public _DEBUG_TRANSPORT_DATA TransportData { get; }
        public _DEBUG_IOMMU_EFI_DATA EfiIoMmuData { get; }

        public _DEBUG_DEVICE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEBUG_DEVICE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.Bus),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.Slot),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.Segment),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.VendorID),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.DeviceID),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.BaseClass),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.SubClass),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.ProgIf),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.DbgHalScratchAllocated),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.DbgBarsMapped),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.DbgScratchAllocated),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.DbgUncachedMemory),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.DbgSynthetic),
                    new ulong[]
                    {
                        17UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.Initialized),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.Configured),
                    new ulong[]
                    {
                        19UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.BaseAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.Memory),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.Dbg2TableIndex),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.PortType),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.PortSubtype),
                    new ulong[]
                    {
                        206UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.OemData),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.OemDataLength),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.NameSpace),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.NameSpacePath),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.NameSpacePathLength),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.TransportType),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.TransportData),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_DEBUG_DEVICE_DESCRIPTOR.EfiIoMmuData),
                    new ulong[]
                    {
                        256UL
                    }
                }
            };
            Register<_DEBUG_DEVICE_DESCRIPTOR>((mem, ptr) => new _DEBUG_DEVICE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}