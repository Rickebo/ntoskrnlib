using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_COUNTERS")]
    public sealed class _HEAP_COUNTERS : DynamicStructure
    {
        public ulong TotalMemoryReserved { get; }
        public ulong TotalMemoryCommitted { get; }
        public ulong TotalMemoryLargeUCR { get; }
        public ulong TotalSizeInVirtualBlocks { get; }
        public uint TotalSegments { get; }
        public uint TotalUCRs { get; }
        public uint CommittOps { get; }
        public uint DeCommitOps { get; }
        public uint LockAcquires { get; }
        public uint LockCollisions { get; }
        public uint CommitRate { get; }
        public uint DecommittRate { get; }
        public uint CommitFailures { get; }
        public uint InBlockCommitFailures { get; }
        public uint PollIntervalCounter { get; }
        public uint DecommitsSinceLastCheck { get; }
        public uint HeapPollInterval { get; }
        public uint AllocAndFreeOps { get; }
        public uint AllocationIndicesActive { get; }
        public uint InBlockDeccommits { get; }
        public ulong InBlockDeccomitSize { get; }
        public ulong HighWatermarkSize { get; }
        public ulong LastPolledSize { get; }

        public _HEAP_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_COUNTERS.TotalMemoryReserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.TotalMemoryCommitted),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.TotalMemoryLargeUCR),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.TotalSizeInVirtualBlocks),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.TotalSegments),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.TotalUCRs),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.CommittOps),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.DeCommitOps),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.LockAcquires),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.LockCollisions),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.CommitRate),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.DecommittRate),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.CommitFailures),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.InBlockCommitFailures),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.PollIntervalCounter),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.DecommitsSinceLastCheck),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.HeapPollInterval),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.AllocAndFreeOps),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.AllocationIndicesActive),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.InBlockDeccommits),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.InBlockDeccomitSize),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.HighWatermarkSize),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_HEAP_COUNTERS.LastPolledSize),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_HEAP_COUNTERS>((mem, ptr) => new _HEAP_COUNTERS(mem, ptr), offsets);
        }
    }
}