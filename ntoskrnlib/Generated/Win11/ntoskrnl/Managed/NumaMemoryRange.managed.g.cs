using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NUMA_MEMORY_RANGE")]
    public sealed class NumaMemoryRange : DynamicStructure
    {
        [Offset(0UL)]
        public uint ProximityId { get => ReadHere<uint>(nameof(ProximityId)); set => WriteHere(nameof(ProximityId), value); }

        [Offset(8UL)]
        public ulong BasePage { get => ReadHere<ulong>(nameof(BasePage)); set => WriteHere(nameof(BasePage), value); }

        [Offset(16UL)]
        public ulong EndPage { get => ReadHere<ulong>(nameof(EndPage)); set => WriteHere(nameof(EndPage), value); }

        public NumaMemoryRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NumaMemoryRange>();
        }
    }
}