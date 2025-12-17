using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureStateCache")]
    public sealed class wil_details_FeatureStateCache : DynamicStructure
    {
        public ulong exchange64 { get; }
        public uint exchange { get; }
        public uint effectiveState { get; }
        public uint stateCached { get; }
        public uint hasNotificationCached { get; }
        public uint variantCached { get; }
        public uint deviceUsageFastPathEnabled { get; }
        public uint deviceOpportunityFastPathEnabled { get; }
        public uint desiredState { get; }
        public uint configuredState { get; }
        public uint needsRefresh { get; }
        public uint hasNotification { get; }
        public uint isWexpConfiguration { get; }
        public uint variant { get; }
        public uint unused { get; }
        public uint payloadId { get; }

        public wil_details_FeatureStateCache(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_details_FeatureStateCache()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_details_FeatureStateCache.exchange64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.exchange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.effectiveState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.stateCached),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.hasNotificationCached),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.variantCached),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.deviceUsageFastPathEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.deviceOpportunityFastPathEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.desiredState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.configuredState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.needsRefresh),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.hasNotification),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.isWexpConfiguration),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.variant),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.unused),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureStateCache.payloadId),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<wil_details_FeatureStateCache>((mem, ptr) => new wil_details_FeatureStateCache(mem, ptr), offsets);
        }
    }
}