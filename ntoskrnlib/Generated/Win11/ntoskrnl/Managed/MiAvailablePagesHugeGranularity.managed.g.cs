using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_AVAILABLE_PAGES_HUGE_GRANULARITY")]
    public sealed class MiAvailablePagesHugeGranularity : DynamicStructure
    {
        [Offset(0UL)]
        public uint SmallAvailablePages { get => ReadHere<uint>(nameof(SmallAvailablePages)); set => WriteHere(nameof(SmallAvailablePages), value); }

        [Offset(0UL)]
        public uint LargeFreeZeroPages { get => ReadHere<uint>(nameof(LargeFreeZeroPages)); set => WriteHere(nameof(LargeFreeZeroPages), value); }

        [Offset(0UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public uint EntireValue { get => ReadHere<uint>(nameof(EntireValue)); set => WriteHere(nameof(EntireValue), value); }

        [Offset(0UL)]
        public int EntireValueSigned { get => ReadHere<int>(nameof(EntireValueSigned)); set => WriteHere(nameof(EntireValueSigned), value); }

        [Offset(0UL)]
        public int EntireValueVolatile { get => ReadHere<int>(nameof(EntireValueVolatile)); set => WriteHere(nameof(EntireValueVolatile), value); }

        public MiAvailablePagesHugeGranularity(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAvailablePagesHugeGranularity>();
        }
    }
}