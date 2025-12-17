using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ENERGY_STATE_DURATION")]
    public sealed class EnergyStateDuration : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint LastChangeTime { get => ReadHere<uint>(nameof(LastChangeTime)); set => WriteHere(nameof(LastChangeTime), value); }

        [Offset(4UL)]
        public uint Duration { get => ReadHere<uint>(nameof(Duration)); set => WriteHere(nameof(Duration), value); }

        [Offset(4UL)]
        public uint IsInState { get => ReadHere<uint>(nameof(IsInState)); set => WriteHere(nameof(IsInState), value); }

        public EnergyStateDuration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EnergyStateDuration>();
        }
    }
}