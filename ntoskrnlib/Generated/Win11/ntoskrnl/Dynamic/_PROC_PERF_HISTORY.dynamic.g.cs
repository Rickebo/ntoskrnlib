using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_HISTORY")]
    public sealed class _PROC_PERF_HISTORY : DynamicStructure
    {
        public uint Count { get; }
        public uint Slot { get; }
        public uint UtilityTotal { get; }
        public uint AffinitizedUtilityTotal { get; }
        public uint FrequencyTotal { get; }
        public uint ImportantPercentTotal { get; }
        public uint IdealPercentTotal { get; }
        public uint[] TaggedPercentTotal { get; }
        public byte[] HistoryList { get; }

        public _PROC_PERF_HISTORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_HISTORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_HISTORY.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY.Slot),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY.UtilityTotal),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY.AffinitizedUtilityTotal),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY.FrequencyTotal),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY.ImportantPercentTotal),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY.IdealPercentTotal),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY.TaggedPercentTotal),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY.HistoryList),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_PROC_PERF_HISTORY>((mem, ptr) => new _PROC_PERF_HISTORY(mem, ptr), offsets);
        }
    }
}