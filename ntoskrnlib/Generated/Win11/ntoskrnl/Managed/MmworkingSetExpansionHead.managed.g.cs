using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMWORKING_SET_EXPANSION_HEAD")]
    public sealed class MmworkingSetExpansionHead : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListHead { get => ReadStructure<ListEntry>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        public MmworkingSetExpansionHead(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmworkingSetExpansionHead>();
        }
    }
}