using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROC_PERF_CHECK_SNAP")]
    public sealed class _PROC_PERF_CHECK_SNAP : DynamicStructure
    {
        public ulong Time { get; }
        public ulong Active { get; }
        public ulong Stall { get; }
        public ulong FrequencyScaledActive { get; }
        public ulong PerformanceScaledActive { get; }
        public ulong PerformanceScaledKernelActive { get; }
        public uint ResponsivenessEvents { get; }

        public _PROC_PERF_CHECK_SNAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_CHECK_SNAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_CHECK_SNAP.Time),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_SNAP.Active),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_SNAP.Stall),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_SNAP.FrequencyScaledActive),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_SNAP.PerformanceScaledActive),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_SNAP.PerformanceScaledKernelActive),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROC_PERF_CHECK_SNAP.ResponsivenessEvents),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_PROC_PERF_CHECK_SNAP>((mem, ptr) => new _PROC_PERF_CHECK_SNAP(mem, ptr), offsets);
        }
    }
}