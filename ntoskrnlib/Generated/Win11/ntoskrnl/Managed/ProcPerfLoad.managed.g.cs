using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_PERF_LOAD")]
    public sealed class ProcPerfLoad : DynamicStructure
    {
        [Offset(0UL)]
        public byte BusyPercentage { get => ReadHere<byte>(nameof(BusyPercentage)); set => WriteHere(nameof(BusyPercentage), value); }

        [Offset(1UL)]
        public byte FrequencyPercentage { get => ReadHere<byte>(nameof(FrequencyPercentage)); set => WriteHere(nameof(FrequencyPercentage), value); }

        public ProcPerfLoad(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcPerfLoad>();
        }
    }
}