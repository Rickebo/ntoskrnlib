using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_HISTORY_ENTRY")]
    public sealed class _PROC_PERF_HISTORY_ENTRY : DynamicStructure
    {
        public ushort Utility { get; }
        public ushort AffinitizedUtility { get; }
        public ushort Frequency { get; }
        public byte ImportantPercent { get; }
        public byte IdealPercent { get; }
        public byte[] TaggedPercent { get; }

        public _PROC_PERF_HISTORY_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_PERF_HISTORY_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_PERF_HISTORY_ENTRY.Utility),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY_ENTRY.AffinitizedUtility),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY_ENTRY.Frequency),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY_ENTRY.ImportantPercent),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY_ENTRY.IdealPercent),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_PROC_PERF_HISTORY_ENTRY.TaggedPercent),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PROC_PERF_HISTORY_ENTRY>((mem, ptr) => new _PROC_PERF_HISTORY_ENTRY(mem, ptr), offsets);
        }
    }
}