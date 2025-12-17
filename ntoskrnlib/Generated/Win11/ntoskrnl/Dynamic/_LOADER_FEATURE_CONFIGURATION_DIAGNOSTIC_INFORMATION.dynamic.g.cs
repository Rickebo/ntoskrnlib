using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION")]
    public sealed class _LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION : DynamicStructure
    {
        public byte OriginalBootStatus { get; }
        public byte NewBootStatus { get; }
        public byte ConfigurationLoaded { get; }
        public byte Spare { get; }
        public _unnamed_tag_ Flags { get; }
        public int ConfigurationComparisonStatus { get; }
        public int CurrentConfigurationLoadStatus { get; }
        public int LkgConfigurationLoadStatus { get; }
        public int UsageSubscriptionLoadStatus { get; }

        public _LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.OriginalBootStatus),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.NewBootStatus),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.ConfigurationLoaded),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.Spare),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.ConfigurationComparisonStatus),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.CurrentConfigurationLoadStatus),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.LkgConfigurationLoadStatus),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION.UsageSubscriptionLoadStatus),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION>((mem, ptr) => new _LOADER_FEATURE_CONFIGURATION_DIAGNOSTIC_INFORMATION(mem, ptr), offsets);
        }
    }
}