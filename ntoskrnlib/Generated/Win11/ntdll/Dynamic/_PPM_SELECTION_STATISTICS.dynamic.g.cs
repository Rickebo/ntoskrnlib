using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_SELECTION_STATISTICS")]
    public sealed class _PPM_SELECTION_STATISTICS : DynamicStructure
    {
        public ulong SelectedCount { get; }
        public ulong VetoCount { get; }
        public ulong PreVetoCount { get; }
        public ulong WrongProcessorCount { get; }
        public ulong LatencyCount { get; }
        public ulong IdleDurationCount { get; }
        public ulong DeviceDependencyCount { get; }
        public ulong ProcessorDependencyCount { get; }
        public ulong PlatformOnlyCount { get; }
        public ulong InterruptibleCount { get; }
        public ulong LegacyOverrideCount { get; }
        public ulong CstateCheckCount { get; }
        public ulong NoCStateCount { get; }
        public ulong CoordinatedDependencyCount { get; }
        public ulong NotClockOwnerCount { get; }
        public ulong DependencyIdleDurationCount { get; }
        public ulong DependencyLatencyCount { get; }
        public IntPtr PreVetoAccounting { get; }

        public _PPM_SELECTION_STATISTICS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_SELECTION_STATISTICS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_SELECTION_STATISTICS.SelectedCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.VetoCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.PreVetoCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.WrongProcessorCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.LatencyCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.IdleDurationCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.DeviceDependencyCount),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.ProcessorDependencyCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.PlatformOnlyCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.InterruptibleCount),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.LegacyOverrideCount),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.CstateCheckCount),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.NoCStateCount),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.CoordinatedDependencyCount),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.NotClockOwnerCount),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.DependencyIdleDurationCount),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.DependencyLatencyCount),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_STATISTICS.PreVetoAccounting),
                    new ulong[]
                    {
                        136UL
                    }
                }
            };
            Register<_PPM_SELECTION_STATISTICS>((mem, ptr) => new _PPM_SELECTION_STATISTICS(mem, ptr), offsets);
        }
    }
}