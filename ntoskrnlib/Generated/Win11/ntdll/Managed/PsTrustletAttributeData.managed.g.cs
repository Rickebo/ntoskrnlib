using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_TRUSTLET_ATTRIBUTE_DATA")]
    public sealed class PsTrustletAttributeData : DynamicStructure
    {
        [Offset(0UL)]
        public PsTrustletAttributeHeader Header { get => ReadStructure<PsTrustletAttributeHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Data { get => ReadStructure<DynamicArray>(nameof(Data)); set => WriteStructure(nameof(Data), value); }

        public PsTrustletAttributeData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsTrustletAttributeData>();
        }
    }
}