using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_PERF_COUNTERS")]
    public sealed class EtwPerfCounters : DynamicStructure
    {
        [Offset(0UL)]
        public int TotalActiveSessions { get => ReadHere<int>(nameof(TotalActiveSessions)); set => WriteHere(nameof(TotalActiveSessions), value); }

        [Offset(4UL)]
        public int TotalBufferMemoryNonPagedPool { get => ReadHere<int>(nameof(TotalBufferMemoryNonPagedPool)); set => WriteHere(nameof(TotalBufferMemoryNonPagedPool), value); }

        [Offset(8UL)]
        public int TotalBufferMemoryPagedPool { get => ReadHere<int>(nameof(TotalBufferMemoryPagedPool)); set => WriteHere(nameof(TotalBufferMemoryPagedPool), value); }

        [Offset(12UL)]
        public int TotalGuidsEnabled { get => ReadHere<int>(nameof(TotalGuidsEnabled)); set => WriteHere(nameof(TotalGuidsEnabled), value); }

        [Offset(16UL)]
        public int TotalGuidsNotEnabled { get => ReadHere<int>(nameof(TotalGuidsNotEnabled)); set => WriteHere(nameof(TotalGuidsNotEnabled), value); }

        [Offset(20UL)]
        public int TotalGuidsPreEnabled { get => ReadHere<int>(nameof(TotalGuidsPreEnabled)); set => WriteHere(nameof(TotalGuidsPreEnabled), value); }

        public EtwPerfCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwPerfCounters>();
        }
    }
}