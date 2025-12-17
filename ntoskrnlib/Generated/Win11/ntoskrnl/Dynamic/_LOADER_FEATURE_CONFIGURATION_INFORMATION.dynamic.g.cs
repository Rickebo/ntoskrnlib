using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_FEATURE_CONFIGURATION_INFORMATION")]
    public sealed class _LOADER_FEATURE_CONFIGURATION_INFORMATION : DynamicStructure
    {
        public IntPtr FeatureConfigurationBuffer { get; }
        public ulong FeatureConfigurationBufferSize { get; }
        public IntPtr UsageSubscriptionBuffer { get; }
        public ulong UsageSubscriptionBufferSize { get; }
        public IntPtr DelayedUsageReportBuffer { get; }
        public ulong DelayedUsageReportBufferSize { get; }
        public _LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION DiagnosticInformation { get; }

        public _LOADER_FEATURE_CONFIGURATION_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_FEATURE_CONFIGURATION_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION.FeatureConfigurationBuffer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION.FeatureConfigurationBufferSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION.UsageSubscriptionBuffer),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION.UsageSubscriptionBufferSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION.DelayedUsageReportBuffer),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION.DelayedUsageReportBufferSize),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION.DiagnosticInformation),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_LOADER_FEATURE_CONFIGURATION_INFORMATION>((mem, ptr) => new _LOADER_FEATURE_CONFIGURATION_INFORMATION(mem, ptr), offsets);
        }
    }
}