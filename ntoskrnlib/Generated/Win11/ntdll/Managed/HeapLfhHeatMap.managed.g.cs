using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_HEAT_MAP")]
    public sealed class HeapLfhHeatMap : DynamicStructure
    {
        [Offset(0UL)]
        [Length(126)]
        public DynamicArray Counts { get => ReadStructure<DynamicArray>(nameof(Counts)); set => WriteStructure(nameof(Counts), value); }

        [Offset(252UL)]
        public uint LastDecayPeriod { get => ReadHere<uint>(nameof(LastDecayPeriod)); set => WriteHere(nameof(LastDecayPeriod), value); }

        public HeapLfhHeatMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhHeatMap>();
        }
    }
}