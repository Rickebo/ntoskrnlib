using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_AVAILABLE_PAGES_MEDIUM_GRANULARITY")]
    public sealed class MiAvailablePagesMediumGranularity : DynamicStructure
    {
        [Offset(0UL)]
        public ushort SmallFreeZeroPages { get => ReadHere<ushort>(nameof(SmallFreeZeroPages)); set => WriteHere(nameof(SmallFreeZeroPages), value); }

        [Offset(0UL)]
        public ushort SmallAvailablePages { get => ReadHere<ushort>(nameof(SmallAvailablePages)); set => WriteHere(nameof(SmallAvailablePages), value); }

        [Offset(0UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public ushort EntireValue { get => ReadHere<ushort>(nameof(EntireValue)); set => WriteHere(nameof(EntireValue), value); }

        [Offset(0UL)]
        public short EntireValueSigned { get => ReadHere<short>(nameof(EntireValueSigned)); set => WriteHere(nameof(EntireValueSigned), value); }

        [Offset(0UL)]
        public short EntireValueVolatile { get => ReadHere<short>(nameof(EntireValueVolatile)); set => WriteHere(nameof(EntireValueVolatile), value); }

        public MiAvailablePagesMediumGranularity(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAvailablePagesMediumGranularity>();
        }
    }
}