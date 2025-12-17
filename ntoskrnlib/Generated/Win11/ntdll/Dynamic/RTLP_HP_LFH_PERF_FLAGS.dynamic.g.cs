using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!RTLP_HP_LFH_PERF_FLAGS")]
    public sealed class RTLP_HP_LFH_PERF_FLAGS : DynamicStructure
    {
        public uint HotspotDetection { get; }
        public uint LfhSubsegmentPrefetch { get; }
        public uint ThreadPrivateSlot { get; }
        public uint VsAffinitySlots { get; }
        public uint OpportunisticLargePreCommit { get; }
        public uint LfhForcedAffinity { get; }
        public uint LfhConservativeAffinity { get; }
        public uint LfhCachelinePadding { get; }
        public uint LfhSubsegmentHeat { get; }
        public uint SegCachedCommitLimitRatio { get; }
        public uint HotSubsegmentSizeShift { get; }
        public uint HotThresholdHighShift { get; }
        public uint Spare { get; }
        public uint AllFlags { get; }

        public RTLP_HP_LFH_PERF_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static RTLP_HP_LFH_PERF_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.HotspotDetection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.LfhSubsegmentPrefetch),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.ThreadPrivateSlot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.VsAffinitySlots),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.OpportunisticLargePreCommit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.LfhForcedAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.LfhConservativeAffinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.LfhCachelinePadding),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.LfhSubsegmentHeat),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.SegCachedCommitLimitRatio),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.HotSubsegmentSizeShift),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.HotThresholdHighShift),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(RTLP_HP_LFH_PERF_FLAGS.AllFlags),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<RTLP_HP_LFH_PERF_FLAGS>((mem, ptr) => new RTLP_HP_LFH_PERF_FLAGS(mem, ptr), offsets);
        }
    }
}