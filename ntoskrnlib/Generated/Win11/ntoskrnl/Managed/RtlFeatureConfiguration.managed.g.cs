using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_FEATURE_CONFIGURATION")]
    public sealed class RtlFeatureConfiguration : DynamicStructure
    {
        [Offset(0UL)]
        public uint FeatureId { get => ReadHere<uint>(nameof(FeatureId)); set => WriteHere(nameof(FeatureId), value); }

        [Offset(4UL)]
        public uint Priority { get => ReadHere<uint>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(4UL)]
        public uint EnabledState { get => ReadHere<uint>(nameof(EnabledState)); set => WriteHere(nameof(EnabledState), value); }

        [Offset(4UL)]
        public uint IsWexpConfiguration { get => ReadHere<uint>(nameof(IsWexpConfiguration)); set => WriteHere(nameof(IsWexpConfiguration), value); }

        [Offset(4UL)]
        public uint HasSubscriptions { get => ReadHere<uint>(nameof(HasSubscriptions)); set => WriteHere(nameof(HasSubscriptions), value); }

        [Offset(4UL)]
        public uint Variant { get => ReadHere<uint>(nameof(Variant)); set => WriteHere(nameof(Variant), value); }

        [Offset(4UL)]
        public uint VariantPayloadKind { get => ReadHere<uint>(nameof(VariantPayloadKind)); set => WriteHere(nameof(VariantPayloadKind), value); }

        [Offset(8UL)]
        public uint VariantPayload { get => ReadHere<uint>(nameof(VariantPayload)); set => WriteHere(nameof(VariantPayload), value); }

        public RtlFeatureConfiguration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlFeatureConfiguration>();
        }
    }
}