using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_THERMAL_COOLING_INTERFACE")]
    public sealed class _THERMAL_COOLING_INTERFACE : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public IntPtr Context { get; }
        public IntPtr InterfaceReference { get; }
        public IntPtr InterfaceDereference { get; }
        public uint Flags { get; }
        public IntPtr ActiveCooling { get; }
        public IntPtr PassiveCooling { get; }

        public _THERMAL_COOLING_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _THERMAL_COOLING_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_THERMAL_COOLING_INTERFACE.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_THERMAL_COOLING_INTERFACE.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_THERMAL_COOLING_INTERFACE.Context),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_THERMAL_COOLING_INTERFACE.InterfaceReference),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_THERMAL_COOLING_INTERFACE.InterfaceDereference),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_THERMAL_COOLING_INTERFACE.Flags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_THERMAL_COOLING_INTERFACE.ActiveCooling),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_THERMAL_COOLING_INTERFACE.PassiveCooling),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_THERMAL_COOLING_INTERFACE>((mem, ptr) => new _THERMAL_COOLING_INTERFACE(mem, ptr), offsets);
        }
    }
}