using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCESS_ENERGY_VALUES")]
    public sealed class _PROCESS_ENERGY_VALUES : DynamicStructure
    {
        public byte[] Cycles { get; }
        public ulong DiskEnergy { get; }
        public ulong NetworkTailEnergy { get; }
        public ulong MBBTailEnergy { get; }
        public ulong NetworkTxRxBytes { get; }
        public ulong MBBTxRxBytes { get; }
        public byte[] Durations { get; }
        public _ENERGY_STATE_DURATION ForegroundDuration { get; }
        public _ENERGY_STATE_DURATION DesktopVisibleDuration { get; }
        public _ENERGY_STATE_DURATION PSMForegroundDuration { get; }
        public uint CompositionRendered { get; }
        public uint CompositionDirtyGenerated { get; }
        public uint CompositionDirtyPropagated { get; }
        public uint Reserved1 { get; }
        public byte[] AttributedCycles { get; }
        public byte[] WorkOnBehalfCycles { get; }

        public _PROCESS_ENERGY_VALUES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESS_ENERGY_VALUES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESS_ENERGY_VALUES.Cycles),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.DiskEnergy),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.NetworkTailEnergy),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.MBBTailEnergy),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.NetworkTxRxBytes),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.MBBTxRxBytes),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.Durations),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.ForegroundDuration),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.DesktopVisibleDuration),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.PSMForegroundDuration),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.CompositionRendered),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.CompositionDirtyGenerated),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.CompositionDirtyPropagated),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.Reserved1),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.AttributedCycles),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES.WorkOnBehalfCycles),
                    new ulong[]
                    {
                        208UL
                    }
                }
            };
            Register<_PROCESS_ENERGY_VALUES>((mem, ptr) => new _PROCESS_ENERGY_VALUES(mem, ptr), offsets);
        }
    }
}