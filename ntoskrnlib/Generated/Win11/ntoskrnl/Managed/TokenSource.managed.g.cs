using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TOKEN_SOURCE")]
    public sealed class TokenSource : DynamicStructure
    {
        [Offset(0UL)]
        [Length(8)]
        public DynamicArray SourceName { get => ReadStructure<DynamicArray>(nameof(SourceName)); set => WriteStructure(nameof(SourceName), value); }

        [Offset(8UL)]
        public Luid SourceIdentifier { get => ReadStructure<Luid>(nameof(SourceIdentifier)); set => WriteStructure(nameof(SourceIdentifier), value); }

        public TokenSource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TokenSource>();
        }
    }
}