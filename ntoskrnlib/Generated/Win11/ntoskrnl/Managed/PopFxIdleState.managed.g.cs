using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_IDLE_STATE")]
    public sealed class PopFxIdleState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TransitionLatency { get => ReadHere<ulong>(nameof(TransitionLatency)); set => WriteHere(nameof(TransitionLatency), value); }

        [Offset(8UL)]
        public ulong ResidencyRequirement { get => ReadHere<ulong>(nameof(ResidencyRequirement)); set => WriteHere(nameof(ResidencyRequirement), value); }

        [Offset(16UL)]
        public uint NominalPower { get => ReadHere<uint>(nameof(NominalPower)); set => WriteHere(nameof(NominalPower), value); }

        public PopFxIdleState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxIdleState>();
        }
    }
}