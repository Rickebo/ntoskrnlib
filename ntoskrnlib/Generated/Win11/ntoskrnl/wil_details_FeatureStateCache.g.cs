#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct wil_details_FeatureStateCache
    {
        [FieldOffset(0)]
        public ulong exchange64;
        [FieldOffset(0)]
        public uint exchange;
        [FieldOffset(0)]
        public uint effectiveState;
        [FieldOffset(0)]
        public uint stateCached;
        [FieldOffset(0)]
        public uint hasNotificationCached;
        [FieldOffset(0)]
        public uint variantCached;
        [FieldOffset(0)]
        public uint deviceUsageFastPathEnabled;
        [FieldOffset(0)]
        public uint deviceOpportunityFastPathEnabled;
        [FieldOffset(0)]
        public uint desiredState;
        [FieldOffset(0)]
        public uint configuredState;
        [FieldOffset(0)]
        public uint needsRefresh;
        [FieldOffset(0)]
        public uint hasNotification;
        [FieldOffset(0)]
        public uint isWexpConfiguration;
        [FieldOffset(0)]
        public uint variant;
        [FieldOffset(0)]
        public uint unused;
        [FieldOffset(4)]
        public uint payloadId;
    }
}