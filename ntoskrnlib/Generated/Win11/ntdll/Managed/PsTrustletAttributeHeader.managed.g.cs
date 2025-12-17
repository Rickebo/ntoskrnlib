using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_ATTRIBUTE_HEADER")]
    public sealed class PsTrustletAttributeHeader : DynamicStructure
    {
        [Offset(0UL)]
        public PsTrustletAttributeType AttributeType { get => ReadStructure<PsTrustletAttributeType>(nameof(AttributeType)); set => WriteStructure(nameof(AttributeType), value); }

        [Offset(4UL)]
        public uint InstanceNumber { get => ReadHere<uint>(nameof(InstanceNumber)); set => WriteHere(nameof(InstanceNumber), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public PsTrustletAttributeHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsTrustletAttributeHeader>();
        }
    }
}