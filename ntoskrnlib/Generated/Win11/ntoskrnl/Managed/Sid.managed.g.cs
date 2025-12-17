using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SID")]
    public sealed class Sid : DynamicStructure
    {
        [Offset(0UL)]
        public byte Revision { get => ReadHere<byte>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(1UL)]
        public byte SubAuthorityCount { get => ReadHere<byte>(nameof(SubAuthorityCount)); set => WriteHere(nameof(SubAuthorityCount), value); }

        [Offset(2UL)]
        public SidIdentifierAuthority IdentifierAuthority { get => ReadStructure<SidIdentifierAuthority>(nameof(IdentifierAuthority)); set => WriteStructure(nameof(IdentifierAuthority), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray SubAuthority { get => ReadStructure<DynamicArray>(nameof(SubAuthority)); set => WriteStructure(nameof(SubAuthority), value); }

        public Sid(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Sid>();
        }
    }
}