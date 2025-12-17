using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_CLOCK_TIMER_CONFIGURATION")]
    public sealed class _HAL_CLOCK_TIMER_CONFIGURATION : DynamicStructure
    {
        public byte Flags { get; }
        public byte AlwaysOnTimer { get; }
        public byte HighLatency { get; }
        public byte PerCpuTimer { get; }
        public byte DynamicTickSupported { get; }
        public uint KnownType { get; }
        public uint Capabilities { get; }
        public ulong MaxIncrement { get; }
        public uint MinIncrement { get; }

        public _HAL_CLOCK_TIMER_CONFIGURATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_CLOCK_TIMER_CONFIGURATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.AlwaysOnTimer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.HighLatency),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.PerCpuTimer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.DynamicTickSupported),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.KnownType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.Capabilities),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.MaxIncrement),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HAL_CLOCK_TIMER_CONFIGURATION.MinIncrement),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_HAL_CLOCK_TIMER_CONFIGURATION>((mem, ptr) => new _HAL_CLOCK_TIMER_CONFIGURATION(mem, ptr), offsets);
        }
    }
}