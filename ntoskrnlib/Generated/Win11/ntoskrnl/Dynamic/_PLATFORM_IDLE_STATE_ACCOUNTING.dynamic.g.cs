using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PLATFORM_IDLE_STATE_ACCOUNTING")]
    public sealed class _PLATFORM_IDLE_STATE_ACCOUNTING : DynamicStructure
    {
        public uint CancelCount { get; }
        public uint FailureCount { get; }
        public uint SuccessCount { get; }
        public ulong MaxTime { get; }
        public ulong MinTime { get; }
        public ulong TotalTime { get; }
        public uint InvalidBucketIndex { get; }
        public _PPM_SELECTION_STATISTICS SelectionStatistics { get; }
        public byte[] IdleTimeBuckets { get; }

        public _PLATFORM_IDLE_STATE_ACCOUNTING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PLATFORM_IDLE_STATE_ACCOUNTING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.CancelCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.FailureCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.SuccessCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.MaxTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.MinTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.TotalTime),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.InvalidBucketIndex),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.SelectionStatistics),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PLATFORM_IDLE_STATE_ACCOUNTING.IdleTimeBuckets),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_PLATFORM_IDLE_STATE_ACCOUNTING>((mem, ptr) => new _PLATFORM_IDLE_STATE_ACCOUNTING(mem, ptr), offsets);
        }
    }
}