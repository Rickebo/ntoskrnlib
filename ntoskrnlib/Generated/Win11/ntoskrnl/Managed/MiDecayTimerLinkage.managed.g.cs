using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_DECAY_TIMER_LINKAGE")]
    public sealed class MiDecayTimerLinkage : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Spare0 { get => ReadHere<ulong>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(0UL)]
        public ulong PreviousDecayPfn { get => ReadHere<ulong>(nameof(PreviousDecayPfn)); set => WriteHere(nameof(PreviousDecayPfn), value); }

        [Offset(0UL)]
        public ulong TimerRemoved { get => ReadHere<ulong>(nameof(TimerRemoved)); set => WriteHere(nameof(TimerRemoved), value); }

        [Offset(0UL)]
        public ulong NextDecayPfn { get => ReadHere<ulong>(nameof(NextDecayPfn)); set => WriteHere(nameof(NextDecayPfn), value); }

        public MiDecayTimerLinkage(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiDecayTimerLinkage>();
        }
    }
}