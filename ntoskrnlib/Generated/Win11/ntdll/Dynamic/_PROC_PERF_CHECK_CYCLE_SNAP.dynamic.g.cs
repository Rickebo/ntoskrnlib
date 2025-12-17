using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROC_PERF_CHECK_CYCLE_SNAP")]
    public sealed class _PROC_PERF_CHECK_CYCLE_SNAP : DynamicStructure
    {
        public ulong CyclesActive { get; }
        public ulong CyclesAffinitized { get; }
        public ulong[] TaggedThreadCycles { get; }
        public uint WorkloadClasses { get; }
        public ulong[] ThreadTypeCycles { get; }

        public _PROC_PERF_CHECK_CYCLE_SNAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_CHECK_CYCLE_SNAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_CHECK_CYCLE_SNAP.CyclesActive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CYCLE_SNAP.CyclesAffinitized),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CYCLE_SNAP.TaggedThreadCycles),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CYCLE_SNAP.WorkloadClasses),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_CYCLE_SNAP.ThreadTypeCycles),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_PROC_PERF_CHECK_CYCLE_SNAP>((mem, ptr) => new _PROC_PERF_CHECK_CYCLE_SNAP(mem, ptr), offsets);
        }
    }
}