using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_COUNTERS")]
    public sealed class EtwCounters : DynamicStructure
    {
        [Offset(0UL)]
        public int GuidCount { get => ReadHere<int>(nameof(GuidCount)); set => WriteHere(nameof(GuidCount), value); }

        [Offset(4UL)]
        [Length(2)]
        public DynamicArray PoolUsage { get => ReadStructure<DynamicArray>(nameof(PoolUsage)); set => WriteStructure(nameof(PoolUsage), value); }

        [Offset(12UL)]
        public int SessionCount { get => ReadHere<int>(nameof(SessionCount)); set => WriteHere(nameof(SessionCount), value); }

        public EtwCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwCounters>();
        }
    }
}