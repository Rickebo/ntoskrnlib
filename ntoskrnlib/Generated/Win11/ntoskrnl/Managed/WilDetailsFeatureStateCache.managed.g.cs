using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureStateCache")]
    public sealed class WilDetailsFeatureStateCache : DynamicStructure
    {
        [Offset(0UL)]
        public ulong exchange64 { get => ReadHere<ulong>(nameof(exchange64)); set => WriteHere(nameof(exchange64), value); }

        [Offset(0UL)]
        public uint exchange { get => ReadHere<uint>(nameof(exchange)); set => WriteHere(nameof(exchange), value); }

        [Offset(0UL)]
        public uint effectiveState { get => ReadHere<uint>(nameof(effectiveState)); set => WriteHere(nameof(effectiveState), value); }

        [Offset(0UL)]
        public uint stateCached { get => ReadHere<uint>(nameof(stateCached)); set => WriteHere(nameof(stateCached), value); }

        [Offset(0UL)]
        public uint hasNotificationCached { get => ReadHere<uint>(nameof(hasNotificationCached)); set => WriteHere(nameof(hasNotificationCached), value); }

        [Offset(0UL)]
        public uint variantCached { get => ReadHere<uint>(nameof(variantCached)); set => WriteHere(nameof(variantCached), value); }

        [Offset(0UL)]
        public uint deviceUsageFastPathEnabled { get => ReadHere<uint>(nameof(deviceUsageFastPathEnabled)); set => WriteHere(nameof(deviceUsageFastPathEnabled), value); }

        [Offset(0UL)]
        public uint deviceOpportunityFastPathEnabled { get => ReadHere<uint>(nameof(deviceOpportunityFastPathEnabled)); set => WriteHere(nameof(deviceOpportunityFastPathEnabled), value); }

        [Offset(0UL)]
        public uint desiredState { get => ReadHere<uint>(nameof(desiredState)); set => WriteHere(nameof(desiredState), value); }

        [Offset(0UL)]
        public uint configuredState { get => ReadHere<uint>(nameof(configuredState)); set => WriteHere(nameof(configuredState), value); }

        [Offset(0UL)]
        public uint needsRefresh { get => ReadHere<uint>(nameof(needsRefresh)); set => WriteHere(nameof(needsRefresh), value); }

        [Offset(0UL)]
        public uint hasNotification { get => ReadHere<uint>(nameof(hasNotification)); set => WriteHere(nameof(hasNotification), value); }

        [Offset(0UL)]
        public uint isWexpConfiguration { get => ReadHere<uint>(nameof(isWexpConfiguration)); set => WriteHere(nameof(isWexpConfiguration), value); }

        [Offset(0UL)]
        public uint variant { get => ReadHere<uint>(nameof(variant)); set => WriteHere(nameof(variant), value); }

        [Offset(0UL)]
        public uint unused { get => ReadHere<uint>(nameof(unused)); set => WriteHere(nameof(unused), value); }

        [Offset(4UL)]
        public uint payloadId { get => ReadHere<uint>(nameof(payloadId)); set => WriteHere(nameof(payloadId), value); }

        public WilDetailsFeatureStateCache(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilDetailsFeatureStateCache>();
        }
    }
}