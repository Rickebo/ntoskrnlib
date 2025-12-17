#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct RTLP_HP_LFH_PERF_FLAGS
    {
        [FieldOffset(0)]
        public uint HotspotDetection;
        [FieldOffset(0)]
        public uint LfhSubsegmentPrefetch;
        [FieldOffset(0)]
        public uint ThreadPrivateSlot;
        [FieldOffset(0)]
        public uint VsAffinitySlots;
        [FieldOffset(0)]
        public uint OpportunisticLargePreCommit;
        [FieldOffset(0)]
        public uint LfhForcedAffinity;
        [FieldOffset(0)]
        public uint LfhConservativeAffinity;
        [FieldOffset(0)]
        public uint LfhCachelinePadding;
        [FieldOffset(0)]
        public uint LfhSubsegmentHeat;
        [FieldOffset(0)]
        public uint SegCachedCommitLimitRatio;
        [FieldOffset(0)]
        public uint HotSubsegmentSizeShift;
        [FieldOffset(0)]
        public uint HotThresholdHighShift;
        [FieldOffset(0)]
        public uint Spare;
        [FieldOffset(0)]
        public uint AllFlags;
    }
}