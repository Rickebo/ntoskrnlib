using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_FEATURE_CONFIGURATION_INFORMATION2")]
    public sealed class _LOADER_FEATURE_CONFIGURATION_INFORMATION2 : DynamicStructure
    {
        public uint Version { get; }
        public IntPtr DelayedFeatureUsageDataBuffer { get; }
        public ulong DelayedFeatureUsageDataBufferSize { get; }
        public byte ExperimentationClientPresent { get; }
        public IntPtr GovernedFeatureInfoTable { get; }
        public ulong GovernedFeatureInfoTableSize { get; }

        public _LOADER_FEATURE_CONFIGURATION_INFORMATION2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_FEATURE_CONFIGURATION_INFORMATION2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION2.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION2.DelayedFeatureUsageDataBuffer),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION2.DelayedFeatureUsageDataBufferSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION2.ExperimentationClientPresent),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION2.GovernedFeatureInfoTable),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LOADER_FEATURE_CONFIGURATION_INFORMATION2.GovernedFeatureInfoTableSize),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_LOADER_FEATURE_CONFIGURATION_INFORMATION2>((mem, ptr) => new _LOADER_FEATURE_CONFIGURATION_INFORMATION2(mem, ptr), offsets);
        }
    }
}