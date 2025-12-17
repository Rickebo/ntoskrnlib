using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_FEATURE_CONFIGURATION")]
    public sealed class _RTL_FEATURE_CONFIGURATION : DynamicStructure
    {
        public uint FeatureId { get; }
        public uint Priority { get; }
        public uint EnabledState { get; }
        public uint IsWexpConfiguration { get; }
        public uint HasSubscriptions { get; }
        public uint Variant { get; }
        public uint VariantPayloadKind { get; }
        public uint VariantPayload { get; }

        public _RTL_FEATURE_CONFIGURATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_FEATURE_CONFIGURATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_FEATURE_CONFIGURATION.FeatureId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_CONFIGURATION.Priority),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_CONFIGURATION.EnabledState),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_CONFIGURATION.IsWexpConfiguration),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_CONFIGURATION.HasSubscriptions),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_CONFIGURATION.Variant),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_CONFIGURATION.VariantPayloadKind),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_FEATURE_CONFIGURATION.VariantPayload),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_RTL_FEATURE_CONFIGURATION>((mem, ptr) => new _RTL_FEATURE_CONFIGURATION(mem, ptr), offsets);
        }
    }
}