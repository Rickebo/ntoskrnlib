using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PI_BUS_EXTENSION")]
    public sealed class _PI_BUS_EXTENSION : DynamicStructure
    {
        public uint Flags { get; }
        public byte NumberCSNs { get; }
        public IntPtr ReadDataPort { get; }
        public byte DataPortMapped { get; }
        public IntPtr AddressPort { get; }
        public byte AddrPortMapped { get; }
        public IntPtr CommandPort { get; }
        public byte CmdPortMapped { get; }
        public uint NextSlotNumber { get; }
        public _SINGLE_LIST_ENTRY DeviceList { get; }
        public _SINGLE_LIST_ENTRY CardList { get; }
        public IntPtr PhysicalBusDevice { get; }
        public IntPtr FunctionalBusDevice { get; }
        public IntPtr AttachedDevice { get; }
        public uint BusNumber { get; }
        public uint SystemPowerState { get; }
        public uint DevicePowerState { get; }

        public _PI_BUS_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PI_BUS_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PI_BUS_EXTENSION.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.NumberCSNs),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.ReadDataPort),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.DataPortMapped),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.AddressPort),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.AddrPortMapped),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.CommandPort),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.CmdPortMapped),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.NextSlotNumber),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.DeviceList),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.CardList),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.PhysicalBusDevice),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.FunctionalBusDevice),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.AttachedDevice),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.BusNumber),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.SystemPowerState),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_PI_BUS_EXTENSION.DevicePowerState),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_PI_BUS_EXTENSION>((mem, ptr) => new _PI_BUS_EXTENSION(mem, ptr), offsets);
        }
    }
}