using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PS_TRUSTLET_CREATE_ATTRIBUTES")]
    public sealed class PsTrustletCreateAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TrustletIdentity { get => ReadHere<ulong>(nameof(TrustletIdentity)); set => WriteHere(nameof(TrustletIdentity), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Attributes { get => ReadStructure<DynamicArray>(nameof(Attributes)); set => WriteStructure(nameof(Attributes), value); }

        public PsTrustletCreateAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsTrustletCreateAttributes>();
        }
    }
}