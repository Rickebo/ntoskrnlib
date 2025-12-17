using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_PERF_SET")]
    public sealed class PopFxPerfSet : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PerfSet { get => ReadHere<IntPtr>(nameof(PerfSet)); set => WriteHere(nameof(PerfSet), value); }

        [Offset(8UL)]
        public ulong CurrentPerf { get => ReadHere<ulong>(nameof(CurrentPerf)); set => WriteHere(nameof(CurrentPerf), value); }

        [Offset(16UL)]
        public ulong CurrentPerfStamp { get => ReadHere<ulong>(nameof(CurrentPerfStamp)); set => WriteHere(nameof(CurrentPerfStamp), value); }

        [Offset(24UL)]
        public byte CurrentPerfNominal { get => ReadHere<byte>(nameof(CurrentPerfNominal)); set => WriteHere(nameof(CurrentPerfNominal), value); }

        public PopFxPerfSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxPerfSet>();
        }
    }
}