using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_AVAILABLE_PAGES_LARGE_GRANULARITY")]
    public sealed class MiAvailablePagesLargeGranularity : DynamicStructure
    {
        [Offset(0UL)]
        public ushort SmallAvailablePages { get => ReadHere<ushort>(nameof(SmallAvailablePages)); set => WriteHere(nameof(SmallAvailablePages), value); }

        [Offset(0UL)]
        public ushort MediumFreeZeroPages { get => ReadHere<ushort>(nameof(MediumFreeZeroPages)); set => WriteHere(nameof(MediumFreeZeroPages), value); }

        [Offset(0UL)]
        public ushort EntireValue { get => ReadHere<ushort>(nameof(EntireValue)); set => WriteHere(nameof(EntireValue), value); }

        [Offset(0UL)]
        public short EntireValueSigned { get => ReadHere<short>(nameof(EntireValueSigned)); set => WriteHere(nameof(EntireValueSigned), value); }

        [Offset(0UL)]
        public short EntireValueVolatile { get => ReadHere<short>(nameof(EntireValueVolatile)); set => WriteHere(nameof(EntireValueVolatile), value); }

        public MiAvailablePagesLargeGranularity(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAvailablePagesLargeGranularity>();
        }
    }
}