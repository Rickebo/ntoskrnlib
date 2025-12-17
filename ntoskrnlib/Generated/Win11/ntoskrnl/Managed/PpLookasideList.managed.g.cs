using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PP_LOOKASIDE_LIST")]
    public sealed class PpLookasideList : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr P { get => ReadHere<IntPtr>(nameof(P)); set => WriteHere(nameof(P), value); }

        [Offset(8UL)]
        public IntPtr L { get => ReadHere<IntPtr>(nameof(L)); set => WriteHere(nameof(L), value); }

        public PpLookasideList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpLookasideList>();
        }
    }
}