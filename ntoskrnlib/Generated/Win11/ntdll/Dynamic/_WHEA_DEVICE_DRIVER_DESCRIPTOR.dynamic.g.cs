using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_DEVICE_DRIVER_DESCRIPTOR")]
    public sealed class _WHEA_DEVICE_DRIVER_DESCRIPTOR : DynamicStructure
    {
        public ushort Type { get; }
        public byte Enabled { get; }
        public byte Reserved { get; }
        public _GUID SourceGuid { get; }
        public ushort LogTag { get; }
        public ushort Reserved2 { get; }
        public uint PacketLength { get; }
        public uint PacketCount { get; }
        public IntPtr PacketBuffer { get; }
        public _WHEA_ERROR_SOURCE_CONFIGURATION_DD Config { get; }
        public _GUID CreatorId { get; }
        public _GUID PartitionId { get; }
        public uint MaxSectionDataLength { get; }
        public uint MaxSectionsPerRecord { get; }
        public IntPtr PacketStateBuffer { get; }
        public int OpenHandles { get; }

        public _WHEA_DEVICE_DRIVER_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_DEVICE_DRIVER_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.Enabled),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.SourceGuid),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.LogTag),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.Reserved2),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.PacketLength),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.PacketCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.PacketBuffer),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.Config),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.CreatorId),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.PartitionId),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.MaxSectionDataLength),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.MaxSectionsPerRecord),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.PacketStateBuffer),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_WHEA_DEVICE_DRIVER_DESCRIPTOR.OpenHandles),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_WHEA_DEVICE_DRIVER_DESCRIPTOR>((mem, ptr) => new _WHEA_DEVICE_DRIVER_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}