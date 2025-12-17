using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEADLESS_LOADER_BLOCK")]
    public sealed class _HEADLESS_LOADER_BLOCK : DynamicStructure
    {
        public byte UsedBiosSettings { get; }
        public byte DataBits { get; }
        public byte StopBits { get; }
        public byte Parity { get; }
        public uint BaudRate { get; }
        public uint PortNumber { get; }
        public IntPtr PortAddress { get; }
        public ushort PciDeviceId { get; }
        public ushort PciVendorId { get; }
        public byte PciBusNumber { get; }
        public ushort PciBusSegment { get; }
        public byte PciSlotNumber { get; }
        public byte PciFunctionNumber { get; }
        public uint PciFlags { get; }
        public _GUID SystemGUID { get; }
        public byte IsMMIODevice { get; }
        public byte TerminalType { get; }
        public byte InterfaceType { get; }
        public byte RegisterBitWidth { get; }
        public byte RegisterAccessSize { get; }

        public _HEADLESS_LOADER_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEADLESS_LOADER_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEADLESS_LOADER_BLOCK.UsedBiosSettings),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.DataBits),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.StopBits),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.Parity),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.BaudRate),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PortNumber),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PortAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PciDeviceId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PciVendorId),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PciBusNumber),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PciBusSegment),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PciSlotNumber),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PciFunctionNumber),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.PciFlags),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.SystemGUID),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.IsMMIODevice),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.TerminalType),
                    new ulong[]
                    {
                        57UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.InterfaceType),
                    new ulong[]
                    {
                        58UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.RegisterBitWidth),
                    new ulong[]
                    {
                        59UL
                    }
                },
                {
                    nameof(_HEADLESS_LOADER_BLOCK.RegisterAccessSize),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_HEADLESS_LOADER_BLOCK>((mem, ptr) => new _HEADLESS_LOADER_BLOCK(mem, ptr), offsets);
        }
    }
}