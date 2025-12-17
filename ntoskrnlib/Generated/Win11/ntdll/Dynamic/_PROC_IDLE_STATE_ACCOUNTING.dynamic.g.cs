using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROC_IDLE_STATE_ACCOUNTING")]
    public sealed class _PROC_IDLE_STATE_ACCOUNTING : DynamicStructure
    {
        public ulong TotalTime { get; }
        public uint CancelCount { get; }
        public uint FailureCount { get; }
        public uint SuccessCount { get; }
        public uint InvalidBucketIndex { get; }
        public ulong MinTime { get; }
        public ulong MaxTime { get; }
        public _PPM_SELECTION_STATISTICS SelectionStatistics { get; }
        public byte[] IdleTimeBuckets { get; }

        public _PROC_IDLE_STATE_ACCOUNTING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROC_IDLE_STATE_ACCOUNTING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.TotalTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.CancelCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.FailureCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.SuccessCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.InvalidBucketIndex),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.MinTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.MaxTime),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.SelectionStatistics),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROC_IDLE_STATE_ACCOUNTING.IdleTimeBuckets),
                    new ulong[]
                    {
                        184UL
                    }
                }
            };
            Register<_PROC_IDLE_STATE_ACCOUNTING>((mem, ptr) => new _PROC_IDLE_STATE_ACCOUNTING(mem, ptr), offsets);
        }
    }
}