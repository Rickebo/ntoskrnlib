using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRUSTLET_MAILBOX_KEY")]
    public sealed class TrustletMailboxKey : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray SecretValue { get => ReadStructure<DynamicArray>(nameof(SecretValue)); set => WriteStructure(nameof(SecretValue), value); }

        public TrustletMailboxKey(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TrustletMailboxKey>();
        }
    }
}