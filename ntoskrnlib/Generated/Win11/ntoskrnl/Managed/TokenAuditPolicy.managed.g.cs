using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TOKEN_AUDIT_POLICY")]
    public sealed class TokenAuditPolicy : DynamicStructure
    {
        [Offset(0UL)]
        [Length(31)]
        public DynamicArray PerUserPolicy { get => ReadStructure<DynamicArray>(nameof(PerUserPolicy)); set => WriteStructure(nameof(PerUserPolicy), value); }

        public TokenAuditPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TokenAuditPolicy>();
        }
    }
}