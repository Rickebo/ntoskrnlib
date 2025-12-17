using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VACB_LEVEL_REFERENCE")]
    public sealed class VacbLevelReference : DynamicStructure
    {
        [Offset(0UL)]
        public int Reference { get => ReadHere<int>(nameof(Reference)); set => WriteHere(nameof(Reference), value); }

        [Offset(4UL)]
        public int SpecialReference { get => ReadHere<int>(nameof(SpecialReference)); set => WriteHere(nameof(SpecialReference), value); }

        public VacbLevelReference(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VacbLevelReference>();
        }
    }
}