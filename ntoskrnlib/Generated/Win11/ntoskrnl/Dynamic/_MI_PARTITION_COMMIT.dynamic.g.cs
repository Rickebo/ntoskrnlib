using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_COMMIT")]
    public sealed class _MI_PARTITION_COMMIT : DynamicStructure
    {
        public ulong PeakCommitment { get; }
        public ulong TotalCommitLimitMaximum { get; }
        public uint[] Popups { get; }
        public ulong LowCommitThreshold { get; }
        public ulong HighCommitThreshold { get; }
        public ulong ExtremelyHighCommitThreshold { get; }
        public ulong IdealCommitTarget { get; }
        public int Lock { get; }
        public ulong SystemCommitReserve { get; }
        public ulong OverCommit { get; }

        public _MI_PARTITION_COMMIT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_COMMIT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_COMMIT.PeakCommitment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.TotalCommitLimitMaximum),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.Popups),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.LowCommitThreshold),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.HighCommitThreshold),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.ExtremelyHighCommitThreshold),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.IdealCommitTarget),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.Lock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.SystemCommitReserve),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_PARTITION_COMMIT.OverCommit),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_MI_PARTITION_COMMIT>((mem, ptr) => new _MI_PARTITION_COMMIT(mem, ptr), offsets);
        }
    }
}