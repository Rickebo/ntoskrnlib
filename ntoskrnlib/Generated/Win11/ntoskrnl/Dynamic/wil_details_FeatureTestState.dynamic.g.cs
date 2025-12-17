using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureTestState")]
    public sealed class wil_details_FeatureTestState : DynamicStructure
    {
        public uint kind { get; }
        public uint featureId { get; }
        public uint state { get; }
        public byte variant { get; }
        public uint payload { get; }
        public uint payloadKind { get; }
        public IntPtr next { get; }

        public wil_details_FeatureTestState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_details_FeatureTestState()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_details_FeatureTestState.kind),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_FeatureTestState.featureId),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(wil_details_FeatureTestState.state),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(wil_details_FeatureTestState.variant),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(wil_details_FeatureTestState.payload),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(wil_details_FeatureTestState.payloadKind),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(wil_details_FeatureTestState.next),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<wil_details_FeatureTestState>((mem, ptr) => new wil_details_FeatureTestState(mem, ptr), offsets);
        }
    }
}