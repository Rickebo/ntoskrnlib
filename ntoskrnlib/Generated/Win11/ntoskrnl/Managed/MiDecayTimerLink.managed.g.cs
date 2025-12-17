using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_DECAY_TIMER_LINK")]
    public sealed class MiDecayTimerLink : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        public MiDecayTimerLink(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiDecayTimerLink>();
        }
    }
}