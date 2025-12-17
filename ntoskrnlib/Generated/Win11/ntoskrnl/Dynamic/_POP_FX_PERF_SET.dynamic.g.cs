using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_PERF_SET")]
    public sealed class _POP_FX_PERF_SET : DynamicStructure
    {
        public IntPtr PerfSet { get; }
        public ulong CurrentPerf { get; }
        public ulong CurrentPerfStamp { get; }
        public byte CurrentPerfNominal { get; }

        public _POP_FX_PERF_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_PERF_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_PERF_SET.PerfSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_SET.CurrentPerf),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_SET.CurrentPerfStamp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_PERF_SET.CurrentPerfNominal),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_POP_FX_PERF_SET>((mem, ptr) => new _POP_FX_PERF_SET(mem, ptr), offsets);
        }
    }
}