using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOOKASIDE_LIST_EX")]
    public sealed class LookasideListEx : DynamicStructure
    {
        [Offset(0UL)]
        public GeneralLookasidePool L { get => ReadStructure<GeneralLookasidePool>(nameof(L)); set => WriteStructure(nameof(L), value); }

        public LookasideListEx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LookasideListEx>();
        }
    }
}