using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ENERGY_STATE_DURATION")]
    public sealed class _ENERGY_STATE_DURATION : DynamicStructure
    {
        public ulong Value { get; }
        public uint LastChangeTime { get; }
        public uint Duration { get; }
        public uint IsInState { get; }

        public _ENERGY_STATE_DURATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ENERGY_STATE_DURATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ENERGY_STATE_DURATION.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ENERGY_STATE_DURATION.LastChangeTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ENERGY_STATE_DURATION.Duration),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ENERGY_STATE_DURATION.IsInState),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_ENERGY_STATE_DURATION>((mem, ptr) => new _ENERGY_STATE_DURATION(mem, ptr), offsets);
        }
    }
}