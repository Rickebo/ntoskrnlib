using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_THERMAL_POLICY")]
    public sealed class _THERMAL_POLICY : DynamicStructure
    {
        public uint Version { get; }
        public byte WaitForUpdate { get; }
        public byte Hibernate { get; }
        public byte Critical { get; }
        public byte ThermalStandby { get; }
        public uint ActivationReasons { get; }
        public uint PassiveLimit { get; }
        public uint ActiveLevel { get; }
        public byte OverThrottled { get; }

        public _THERMAL_POLICY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _THERMAL_POLICY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_THERMAL_POLICY.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_THERMAL_POLICY.WaitForUpdate),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_THERMAL_POLICY.Hibernate),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_THERMAL_POLICY.Critical),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_THERMAL_POLICY.ThermalStandby),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_THERMAL_POLICY.ActivationReasons),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_THERMAL_POLICY.PassiveLimit),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_THERMAL_POLICY.ActiveLevel),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_THERMAL_POLICY.OverThrottled),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_THERMAL_POLICY>((mem, ptr) => new _THERMAL_POLICY(mem, ptr), offsets);
        }
    }
}