using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_PROVIDER_TRAITS")]
    public sealed class EtwProviderTraits : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode Node { get => ReadStructure<RtlBalancedNode>(nameof(Node)); set => WriteStructure(nameof(Node), value); }

        [Offset(24UL)]
        public uint ReferenceCount { get => ReadHere<uint>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(28UL)]
        [Length(1)]
        public DynamicArray Traits { get => ReadStructure<DynamicArray>(nameof(Traits)); set => WriteStructure(nameof(Traits), value); }

        public EtwProviderTraits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwProviderTraits>();
        }
    }
}