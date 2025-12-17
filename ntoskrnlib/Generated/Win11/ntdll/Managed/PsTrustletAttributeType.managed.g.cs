using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_ATTRIBUTE_TYPE")]
    public sealed class PsTrustletAttributeType : DynamicStructure
    {
        [Offset(0UL)]
        public byte Version { get => ReadHere<byte>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(1UL)]
        public byte DataCount { get => ReadHere<byte>(nameof(DataCount)); set => WriteHere(nameof(DataCount), value); }

        [Offset(2UL)]
        public byte SemanticType { get => ReadHere<byte>(nameof(SemanticType)); set => WriteHere(nameof(SemanticType), value); }

        [Offset(3UL)]
        public PsTrustletAttributeAccessrights AccessRights { get => ReadStructure<PsTrustletAttributeAccessrights>(nameof(AccessRights)); set => WriteStructure(nameof(AccessRights), value); }

        [Offset(0UL)]
        public uint AttributeType { get => ReadHere<uint>(nameof(AttributeType)); set => WriteHere(nameof(AttributeType), value); }

        public PsTrustletAttributeType(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsTrustletAttributeType>();
        }
    }
}