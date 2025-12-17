using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!wil_details_FeatureTestState")]
    public sealed class WilDetailsFeatureTestState : DynamicStructure
    {
        [Offset(0UL)]
        public uint kind { get => ReadHere<uint>(nameof(kind)); set => WriteHere(nameof(kind), value); }

        [Offset(4UL)]
        public uint featureId { get => ReadHere<uint>(nameof(featureId)); set => WriteHere(nameof(featureId), value); }

        [Offset(8UL)]
        public uint state { get => ReadHere<uint>(nameof(state)); set => WriteHere(nameof(state), value); }

        [Offset(12UL)]
        public byte variant { get => ReadHere<byte>(nameof(variant)); set => WriteHere(nameof(variant), value); }

        [Offset(16UL)]
        public uint payload { get => ReadHere<uint>(nameof(payload)); set => WriteHere(nameof(payload), value); }

        [Offset(20UL)]
        public uint payloadKind { get => ReadHere<uint>(nameof(payloadKind)); set => WriteHere(nameof(payloadKind), value); }

        [Offset(24UL)]
        public IntPtr next { get => ReadHere<IntPtr>(nameof(next)); set => WriteHere(nameof(next), value); }

        public WilDetailsFeatureTestState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WilDetailsFeatureTestState>();
        }
    }
}