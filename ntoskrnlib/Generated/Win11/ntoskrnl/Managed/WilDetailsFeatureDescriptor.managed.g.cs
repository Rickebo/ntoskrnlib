using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureDescriptor")]
    public sealed class WilDetailsFeatureDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr featureStateCache { get => ReadHere<IntPtr>(nameof(featureStateCache)); set => WriteHere(nameof(featureStateCache), value); }

        [Offset(8UL)]
        public IntPtr featureReportingCache { get => ReadHere<IntPtr>(nameof(featureReportingCache)); set => WriteHere(nameof(featureReportingCache), value); }

        [Offset(16UL)]
        public IntPtr featureLoggedTraits { get => ReadHere<IntPtr>(nameof(featureLoggedTraits)); set => WriteHere(nameof(featureLoggedTraits), value); }

        [Offset(24UL)]
        public uint featureId { get => ReadHere<uint>(nameof(featureId)); set => WriteHere(nameof(featureId), value); }

        [Offset(28UL)]
        public byte changeTime { get => ReadHere<byte>(nameof(changeTime)); set => WriteHere(nameof(changeTime), value); }

        [Offset(29UL)]
        public byte isAlwaysDisabled { get => ReadHere<byte>(nameof(isAlwaysDisabled)); set => WriteHere(nameof(isAlwaysDisabled), value); }

        [Offset(30UL)]
        public byte isAlwaysEnabled { get => ReadHere<byte>(nameof(isAlwaysEnabled)); set => WriteHere(nameof(isAlwaysEnabled), value); }

        [Offset(31UL)]
        public byte isEnabledByDefault { get => ReadHere<byte>(nameof(isEnabledByDefault)); set => WriteHere(nameof(isEnabledByDefault), value); }

        [Offset(32UL)]
        public IntPtr requiresFeatures { get => ReadHere<IntPtr>(nameof(requiresFeatures)); set => WriteHere(nameof(requiresFeatures), value); }

        [Offset(40UL)]
        public byte variant { get => ReadHere<byte>(nameof(variant)); set => WriteHere(nameof(variant), value); }

        [Offset(44UL)]
        public uint payloadKind { get => ReadHere<uint>(nameof(payloadKind)); set => WriteHere(nameof(payloadKind), value); }

        [Offset(48UL)]
        public uint payload { get => ReadHere<uint>(nameof(payload)); set => WriteHere(nameof(payload), value); }

        public WilDetailsFeatureDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilDetailsFeatureDescriptor>();
        }
    }
}