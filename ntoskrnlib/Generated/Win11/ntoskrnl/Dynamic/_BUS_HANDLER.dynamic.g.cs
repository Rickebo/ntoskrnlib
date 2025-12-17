using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BUS_HANDLER")]
    public sealed class _BUS_HANDLER : DynamicStructure
    {
        public uint Version { get; }
        public uint InterfaceType { get; }
        public uint ConfigurationType { get; }
        public uint BusNumber { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr ParentHandler { get; }
        public IntPtr BusData { get; }
        public uint DeviceControlExtensionSize { get; }
        public IntPtr BusAddresses { get; }
        public uint[] Reserved { get; }
        public IntPtr GetBusData { get; }
        public IntPtr SetBusData { get; }
        public IntPtr AdjustResourceList { get; }
        public IntPtr AssignSlotResources { get; }
        public IntPtr TranslateBusAddress { get; }
        public IntPtr Spare1 { get; }
        public IntPtr Spare2 { get; }
        public IntPtr Spare3 { get; }
        public IntPtr Spare4 { get; }
        public IntPtr Spare5 { get; }
        public IntPtr Spare6 { get; }
        public IntPtr Spare7 { get; }
        public IntPtr Spare8 { get; }

        public _BUS_HANDLER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BUS_HANDLER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BUS_HANDLER.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.InterfaceType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.ConfigurationType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.BusNumber),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.DeviceObject),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.ParentHandler),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.BusData),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.DeviceControlExtensionSize),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.BusAddresses),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Reserved),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.GetBusData),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.SetBusData),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.AdjustResourceList),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.AssignSlotResources),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.TranslateBusAddress),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Spare1),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Spare2),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Spare3),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Spare4),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Spare5),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Spare6),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Spare7),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_BUS_HANDLER.Spare8),
                    new ulong[]
                    {
                        168UL
                    }
                }
            };
            Register<_BUS_HANDLER>((mem, ptr) => new _BUS_HANDLER(mem, ptr), offsets);
        }
    }
}