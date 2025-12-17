using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TOKEN_MANDATORY_POLICY")]
    public sealed class TokenMandatoryPolicy : DynamicStructure
    {
        [Offset(0UL)]
        public uint Policy { get => ReadHere<uint>(nameof(Policy)); set => WriteHere(nameof(Policy), value); }

        public TokenMandatoryPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TokenMandatoryPolicy>();
        }
    }
}