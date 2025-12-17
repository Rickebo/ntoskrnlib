using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_FeatureState")]
    public sealed class WilFeatureState : DynamicStructure
    {
        [Offset(0UL)]
        public uint enabledState { get => ReadHere<uint>(nameof(enabledState)); set => WriteHere(nameof(enabledState), value); }

        [Offset(4UL)]
        public byte variant { get => ReadHere<byte>(nameof(variant)); set => WriteHere(nameof(variant), value); }

        [Offset(8UL)]
        public uint payloadKind { get => ReadHere<uint>(nameof(payloadKind)); set => WriteHere(nameof(payloadKind), value); }

        [Offset(12UL)]
        public uint payload { get => ReadHere<uint>(nameof(payload)); set => WriteHere(nameof(payload), value); }

        [Offset(16UL)]
        public int hasNotification { get => ReadHere<int>(nameof(hasNotification)); set => WriteHere(nameof(hasNotification), value); }

        [Offset(20UL)]
        public int isWexpConfiguration { get => ReadHere<int>(nameof(isWexpConfiguration)); set => WriteHere(nameof(isWexpConfiguration), value); }

        public WilFeatureState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilFeatureState>();
        }
    }
}