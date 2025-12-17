using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CVDD")]
    public sealed class Cvdd : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(0UL)]
        public NB10 NB10 { get => ReadStructure<NB10>(nameof(NB10)); set => WriteStructure(nameof(NB10), value); }

        [Offset(0UL)]
        public Rsds RsDs { get => ReadStructure<Rsds>(nameof(RsDs)); set => WriteStructure(nameof(RsDs), value); }

        public Cvdd(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Cvdd>();
        }
    }
}