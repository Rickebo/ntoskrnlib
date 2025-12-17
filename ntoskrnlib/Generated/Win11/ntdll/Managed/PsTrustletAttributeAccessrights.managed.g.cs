using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS")]
    public sealed class PsTrustletAttributeAccessrights : DynamicStructure
    {
        [Offset(0UL)]
        public byte Trustlet { get => ReadHere<byte>(nameof(Trustlet)); set => WriteHere(nameof(Trustlet), value); }

        [Offset(0UL)]
        public byte Ntos { get => ReadHere<byte>(nameof(Ntos)); set => WriteHere(nameof(Ntos), value); }

        [Offset(0UL)]
        public byte WriteHandle { get => ReadHere<byte>(nameof(WriteHandle)); set => WriteHere(nameof(WriteHandle), value); }

        [Offset(0UL)]
        public byte ReadHandle { get => ReadHere<byte>(nameof(ReadHandle)); set => WriteHere(nameof(ReadHandle), value); }

        [Offset(0UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public byte AccessRights { get => ReadHere<byte>(nameof(AccessRights)); set => WriteHere(nameof(AccessRights), value); }

        public PsTrustletAttributeAccessrights(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsTrustletAttributeAccessrights>();
        }
    }
}