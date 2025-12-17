using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!RTLP_HP_LFH_PERF_FLAGS")]
    public sealed class RtlpHpLfhPerfFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint HotspotDetection { get => ReadHere<uint>(nameof(HotspotDetection)); set => WriteHere(nameof(HotspotDetection), value); }

        [Offset(0UL)]
        public uint LfhSubsegmentPrefetch { get => ReadHere<uint>(nameof(LfhSubsegmentPrefetch)); set => WriteHere(nameof(LfhSubsegmentPrefetch), value); }

        [Offset(0UL)]
        public uint ThreadPrivateSlot { get => ReadHere<uint>(nameof(ThreadPrivateSlot)); set => WriteHere(nameof(ThreadPrivateSlot), value); }

        [Offset(0UL)]
        public uint VsAffinitySlots { get => ReadHere<uint>(nameof(VsAffinitySlots)); set => WriteHere(nameof(VsAffinitySlots), value); }

        [Offset(0UL)]
        public uint OpportunisticLargePreCommit { get => ReadHere<uint>(nameof(OpportunisticLargePreCommit)); set => WriteHere(nameof(OpportunisticLargePreCommit), value); }

        [Offset(0UL)]
        public uint LfhForcedAffinity { get => ReadHere<uint>(nameof(LfhForcedAffinity)); set => WriteHere(nameof(LfhForcedAffinity), value); }

        [Offset(0UL)]
        public uint LfhConservativeAffinity { get => ReadHere<uint>(nameof(LfhConservativeAffinity)); set => WriteHere(nameof(LfhConservativeAffinity), value); }

        [Offset(0UL)]
        public uint LfhCachelinePadding { get => ReadHere<uint>(nameof(LfhCachelinePadding)); set => WriteHere(nameof(LfhCachelinePadding), value); }

        [Offset(0UL)]
        public uint LfhSubsegmentHeat { get => ReadHere<uint>(nameof(LfhSubsegmentHeat)); set => WriteHere(nameof(LfhSubsegmentHeat), value); }

        [Offset(0UL)]
        public uint SegCachedCommitLimitRatio { get => ReadHere<uint>(nameof(SegCachedCommitLimitRatio)); set => WriteHere(nameof(SegCachedCommitLimitRatio), value); }

        [Offset(0UL)]
        public uint HotSubsegmentSizeShift { get => ReadHere<uint>(nameof(HotSubsegmentSizeShift)); set => WriteHere(nameof(HotSubsegmentSizeShift), value); }

        [Offset(0UL)]
        public uint HotThresholdHighShift { get => ReadHere<uint>(nameof(HotThresholdHighShift)); set => WriteHere(nameof(HotThresholdHighShift), value); }

        [Offset(0UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public uint AllFlags { get => ReadHere<uint>(nameof(AllFlags)); set => WriteHere(nameof(AllFlags), value); }

        public RtlpHpLfhPerfFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpHpLfhPerfFlags>();
        }
    }
}