using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!PROCESS_PERF_COUNTERS")]
    public sealed class PROCESS_PERF_COUNTERS : DynamicStructure
    {
        public ulong ProcessorTime { get; }
        public ulong UserTime { get; }
        public ulong PrivilegedTime { get; }
        public ulong VirtualBytesPeak { get; }
        public ulong VirtualBytes { get; }
        public uint PageFaults { get; }
        public uint HandleCount { get; }
        public ulong WorkingSetPeak { get; }
        public ulong WorkingSet { get; }
        public ulong PageFileBytesPeak { get; }
        public ulong PageFileBytes { get; }
        public ulong PrivateBytes { get; }
        public uint ThreadCount { get; }
        public uint PriorityBase { get; }
        public ulong ElapsedTime { get; }
        public uint ProcessId { get; }
        public uint CreatingProcessId { get; }
        public ulong PoolPagedBytes { get; }
        public ulong PoolNonpagedBytes { get; }
        public ulong IoReadOperations { get; }
        public ulong IoWriteOperations { get; }
        public ulong IoDataOperations { get; }
        public ulong IoOtherOperations { get; }
        public ulong IoReadBytes { get; }
        public ulong IoWriteBytes { get; }
        public ulong IoDataBytes { get; }
        public ulong IoOtherBytes { get; }
        public ulong WorkingSetPrivate { get; }
        public ulong PerfFreq { get; }
        public ulong PerfTime { get; }

        public PROCESS_PERF_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static PROCESS_PERF_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(PROCESS_PERF_COUNTERS.ProcessorTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.UserTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PrivilegedTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.VirtualBytesPeak),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.VirtualBytes),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PageFaults),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.HandleCount),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.WorkingSetPeak),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.WorkingSet),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PageFileBytesPeak),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PageFileBytes),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PrivateBytes),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.ThreadCount),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PriorityBase),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.ElapsedTime),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.ProcessId),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.CreatingProcessId),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PoolPagedBytes),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PoolNonpagedBytes),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.IoReadOperations),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.IoWriteOperations),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.IoDataOperations),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.IoOtherOperations),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.IoReadBytes),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.IoWriteBytes),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.IoDataBytes),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.IoOtherBytes),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.WorkingSetPrivate),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PerfFreq),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(PROCESS_PERF_COUNTERS.PerfTime),
                    new ulong[]
                    {
                        208UL
                    }
                }
            };
            Register<PROCESS_PERF_COUNTERS>((mem, ptr) => new PROCESS_PERF_COUNTERS(mem, ptr), offsets);
        }
    }
}