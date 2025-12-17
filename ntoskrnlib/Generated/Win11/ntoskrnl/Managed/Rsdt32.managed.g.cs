using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RSDT_32")]
    public sealed class Rsdt32 : DynamicStructure
    {
        [Offset(0UL)]
        public DescriptionHeader Header { get => ReadStructure<DescriptionHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(36UL)]
        [Length(1)]
        public DynamicArray Tables { get => ReadStructure<DynamicArray>(nameof(Tables)); set => WriteStructure(nameof(Tables), value); }

        public Rsdt32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Rsdt32>();
        }
    }
}