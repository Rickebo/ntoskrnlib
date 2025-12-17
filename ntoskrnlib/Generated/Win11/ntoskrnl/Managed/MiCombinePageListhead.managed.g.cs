using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_PAGE_LISTHEAD")]
    public sealed class MiCombinePageListhead : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTree Table { get => ReadStructure<RtlAvlTree>(nameof(Table)); set => WriteStructure(nameof(Table), value); }

        [Offset(8UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        public MiCombinePageListhead(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCombinePageListhead>();
        }
    }
}