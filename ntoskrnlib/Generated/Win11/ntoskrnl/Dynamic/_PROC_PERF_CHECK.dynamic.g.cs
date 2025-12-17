using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_CHECK")]
    public sealed class _PROC_PERF_CHECK : DynamicStructure
    {
        public ulong LastActive { get; }
        public ulong LastTime { get; }
        public ulong LastStall { get; }
        public uint LastResponsivenessEvents { get; }
        public _PROC_PERF_CHECK_SNAP LastPerfCheckSnap { get; }
        public IntPtr LastPerfCheckCycleSnap { get; }
        public _PROC_PERF_CHECK_SNAP CurrentSnap { get; }
        public IntPtr CurrentCycleSnap { get; }
        public _PROC_PERF_CHECK_SNAP LastDeliveredSnap { get; }
        public IntPtr LastDeliveredCycleSnap { get; }
        public uint LastDeliveredPerformance { get; }
        public uint LastDeliveredFrequency { get; }
        public byte[] TaggedThreadPercent { get; }
        public byte ImportantPercent { get; }
        public byte IdealPercent { get; }
        public byte Class0FloorPerfSelection { get; }
        public byte Class1MinimumPerfSelection { get; }
        public uint CurrentResponsivenessEvents { get; }
        public byte[] CyclesByFreqBand { get; }

        public _PROC_PERF_CHECK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_CHECK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_CHECK.LastActive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastStall),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastResponsivenessEvents),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastPerfCheckSnap),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastPerfCheckCycleSnap),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.CurrentSnap),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.CurrentCycleSnap),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastDeliveredSnap),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastDeliveredCycleSnap),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastDeliveredPerformance),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.LastDeliveredFrequency),
                    new ulong[]
                    {
                        228UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.TaggedThreadPercent),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.ImportantPercent),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.IdealPercent),
                    new ulong[]
                    {
                        237UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.Class0FloorPerfSelection),
                    new ulong[]
                    {
                        238UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.Class1MinimumPerfSelection),
                    new ulong[]
                    {
                        239UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.CurrentResponsivenessEvents),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK.CyclesByFreqBand),
                    new ulong[]
                    {
                        248UL
                    }
                }
            };
            Register<_PROC_PERF_CHECK>((mem, ptr) => new _PROC_PERF_CHECK(mem, ptr), offsets);
        }
    }
}