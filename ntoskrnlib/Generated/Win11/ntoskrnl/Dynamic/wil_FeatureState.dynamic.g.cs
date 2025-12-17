using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_FeatureState")]
    public sealed class wil_FeatureState : DynamicStructure
    {
        public uint enabledState { get; }
        public byte variant { get; }
        public uint payloadKind { get; }
        public uint payload { get; }
        public int hasNotification { get; }
        public int isWexpConfiguration { get; }

        public wil_FeatureState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_FeatureState()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_FeatureState.enabledState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_FeatureState.variant),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(wil_FeatureState.payloadKind),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(wil_FeatureState.payload),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(wil_FeatureState.hasNotification),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(wil_FeatureState.isWexpConfiguration),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<wil_FeatureState>((mem, ptr) => new wil_FeatureState(mem, ptr), offsets);
        }
    }
}