using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PAGED_LOOKASIDE_LIST")]
    public sealed class PagedLookasideList : DynamicStructure
    {
        [Offset(0UL)]
        public GeneralLookaside L { get => ReadStructure<GeneralLookaside>(nameof(L)); set => WriteStructure(nameof(L), value); }

        public PagedLookasideList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PagedLookasideList>();
        }
    }
}