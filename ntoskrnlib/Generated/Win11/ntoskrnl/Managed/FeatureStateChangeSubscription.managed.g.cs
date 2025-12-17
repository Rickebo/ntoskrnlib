using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!FEATURE_STATE_CHANGE_SUBSCRIPTION__")]
    public sealed class FeatureStateChangeSubscription : DynamicStructure
    {
        [Offset(0UL)]
        public int unused { get => ReadHere<int>(nameof(unused)); set => WriteHere(nameof(unused), value); }

        public FeatureStateChangeSubscription(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FeatureStateChangeSubscription>();
        }
    }
}