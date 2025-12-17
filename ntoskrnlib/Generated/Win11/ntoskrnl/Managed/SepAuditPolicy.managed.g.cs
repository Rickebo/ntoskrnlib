using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_AUDIT_POLICY")]
    public sealed class SepAuditPolicy : DynamicStructure
    {
        [Offset(0UL)]
        public TokenAuditPolicy AdtTokenPolicy { get => ReadStructure<TokenAuditPolicy>(nameof(AdtTokenPolicy)); set => WriteStructure(nameof(AdtTokenPolicy), value); }

        [Offset(31UL)]
        public byte PolicySetStatus { get => ReadHere<byte>(nameof(PolicySetStatus)); set => WriteHere(nameof(PolicySetStatus), value); }

        public SepAuditPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepAuditPolicy>();
        }
    }
}