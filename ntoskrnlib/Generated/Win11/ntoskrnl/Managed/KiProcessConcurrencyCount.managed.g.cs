using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_PROCESS_CONCURRENCY_COUNT")]
    public sealed class KiProcessConcurrencyCount : DynamicStructure
    {
        [Offset(0UL)]
        public uint Fraction { get => ReadHere<uint>(nameof(Fraction)); set => WriteHere(nameof(Fraction), value); }

        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(0UL)]
        public uint AllFields { get => ReadHere<uint>(nameof(AllFields)); set => WriteHere(nameof(AllFields), value); }

        public KiProcessConcurrencyCount(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiProcessConcurrencyCount>();
        }
    }
}