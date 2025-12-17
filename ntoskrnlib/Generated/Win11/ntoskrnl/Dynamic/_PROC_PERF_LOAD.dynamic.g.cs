using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_LOAD")]
    public sealed class _PROC_PERF_LOAD : DynamicStructure
    {
        public byte BusyPercentage { get; }
        public byte FrequencyPercentage { get; }

        public _PROC_PERF_LOAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_LOAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_LOAD.BusyPercentage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_LOAD.FrequencyPercentage),
                    new ulong[]
                    {
                        1UL
                    }
                }
            };
            Register<_PROC_PERF_LOAD>((mem, ptr) => new _PROC_PERF_LOAD(mem, ptr), offsets);
        }
    }
}