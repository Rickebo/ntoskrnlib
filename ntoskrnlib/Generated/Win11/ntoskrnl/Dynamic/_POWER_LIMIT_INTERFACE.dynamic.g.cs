using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POWER_LIMIT_INTERFACE")]
    public sealed class _POWER_LIMIT_INTERFACE : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public IntPtr Context { get; }
        public IntPtr InterfaceReference { get; }
        public IntPtr InterfaceDereference { get; }
        public uint DomainCount { get; }
        public IntPtr QueryAttributes { get; }
        public IntPtr SetPowerLimit { get; }
        public IntPtr QueryPowerLimit { get; }

        public _POWER_LIMIT_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POWER_LIMIT_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POWER_LIMIT_INTERFACE.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_INTERFACE.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_INTERFACE.Context),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_INTERFACE.InterfaceReference),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_INTERFACE.InterfaceDereference),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_INTERFACE.DomainCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_INTERFACE.QueryAttributes),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_INTERFACE.SetPowerLimit),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POWER_LIMIT_INTERFACE.QueryPowerLimit),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_POWER_LIMIT_INTERFACE>((mem, ptr) => new _POWER_LIMIT_INTERFACE(mem, ptr), offsets);
        }
    }
}