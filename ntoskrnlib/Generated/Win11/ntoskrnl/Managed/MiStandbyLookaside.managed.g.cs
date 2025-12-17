using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_STANDBY_LOOKASIDE")]
    public sealed class MiStandbyLookaside : DynamicStructure
    {
        [Offset(0UL)]
        [Length(64)]
        public DynamicArray Array { get => ReadStructure<DynamicArray>(nameof(Array)); set => WriteStructure(nameof(Array), value); }

        public MiStandbyLookaside(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiStandbyLookaside>();
        }
    }
}