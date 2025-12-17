using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NPAGED_LOOKASIDE_LIST")]
    public sealed class NpagedLookasideList : DynamicStructure
    {
        [Offset(0UL)]
        public GeneralLookaside L { get => ReadStructure<GeneralLookaside>(nameof(L)); set => WriteStructure(nameof(L), value); }

        public NpagedLookasideList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NpagedLookasideList>();
        }
    }
}