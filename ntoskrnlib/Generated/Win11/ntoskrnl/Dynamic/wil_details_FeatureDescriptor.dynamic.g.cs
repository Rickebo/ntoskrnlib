using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureDescriptor")]
    public sealed class wil_details_FeatureDescriptor : DynamicStructure
    {
        public IntPtr featureStateCache { get; }
        public IntPtr featureReportingCache { get; }
        public IntPtr featureLoggedTraits { get; }
        public uint featureId { get; }
        public byte changeTime { get; }
        public byte isAlwaysDisabled { get; }
        public byte isAlwaysEnabled { get; }
        public byte isEnabledByDefault { get; }
        public IntPtr requiresFeatures { get; }
        public byte variant { get; }
        public uint payloadKind { get; }
        public uint payload { get; }

        public wil_details_FeatureDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_details_FeatureDescriptor()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_details_FeatureDescriptor.featureStateCache),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.featureReportingCache),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.featureLoggedTraits),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.featureId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.changeTime),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.isAlwaysDisabled),
                    new ulong[]
                    {
                        29UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.isAlwaysEnabled),
                    new ulong[]
                    {
                        30UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.isEnabledByDefault),
                    new ulong[]
                    {
                        31UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.requiresFeatures),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.variant),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.payloadKind),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(wil_details_FeatureDescriptor.payload),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<wil_details_FeatureDescriptor>((mem, ptr) => new wil_details_FeatureDescriptor(mem, ptr), offsets);
        }
    }
}