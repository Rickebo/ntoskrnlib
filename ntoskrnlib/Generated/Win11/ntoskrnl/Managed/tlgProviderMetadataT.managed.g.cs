using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_tlgProviderMetadata_t")]
    public sealed class tlgProviderMetadataT : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public Guid ProviderId { get => ReadStructure<Guid>(nameof(ProviderId)); set => WriteStructure(nameof(ProviderId), value); }

        [Offset(17UL)]
        public ushort RemainingSize { get => ReadHere<ushort>(nameof(RemainingSize)); set => WriteHere(nameof(RemainingSize), value); }

        public tlgProviderMetadataT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<tlgProviderMetadataT>();
        }
    }
}