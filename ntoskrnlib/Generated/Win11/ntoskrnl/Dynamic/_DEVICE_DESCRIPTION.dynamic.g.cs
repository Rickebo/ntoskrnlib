using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_DESCRIPTION")]
    public sealed class _DEVICE_DESCRIPTION : DynamicStructure
    {
        public uint Version { get; }
        public byte Master { get; }
        public byte ScatterGather { get; }
        public byte DemandMode { get; }
        public byte AutoInitialize { get; }
        public byte Dma32BitAddresses { get; }
        public byte IgnoreCount { get; }
        public byte Reserved1 { get; }
        public byte Dma64BitAddresses { get; }
        public uint BusNumber { get; }
        public uint DmaChannel { get; }
        public uint InterfaceType { get; }
        public uint DmaWidth { get; }
        public uint DmaSpeed { get; }
        public uint MaximumLength { get; }
        public uint DmaPort { get; }
        public uint DmaAddressWidth { get; }
        public uint DmaControllerInstance { get; }
        public uint DmaRequestLine { get; }
        public _LARGE_INTEGER DeviceAddress { get; }

        public _DEVICE_DESCRIPTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_DESCRIPTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_DESCRIPTION.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.Master),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.ScatterGather),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DemandMode),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.AutoInitialize),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.Dma32BitAddresses),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.IgnoreCount),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.Reserved1),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.Dma64BitAddresses),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.BusNumber),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DmaChannel),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.InterfaceType),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DmaWidth),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DmaSpeed),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.MaximumLength),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DmaPort),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DmaAddressWidth),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DmaControllerInstance),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DmaRequestLine),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DEVICE_DESCRIPTION.DeviceAddress),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_DEVICE_DESCRIPTION>((mem, ptr) => new _DEVICE_DESCRIPTION(mem, ptr), offsets);
        }
    }
}