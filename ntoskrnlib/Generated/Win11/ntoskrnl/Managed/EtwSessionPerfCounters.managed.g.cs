using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_SESSION_PERF_COUNTERS")]
    public sealed class EtwSessionPerfCounters : DynamicStructure
    {
        [Offset(0UL)]
        public int BufferMemoryPagedPool { get => ReadHere<int>(nameof(BufferMemoryPagedPool)); set => WriteHere(nameof(BufferMemoryPagedPool), value); }

        [Offset(4UL)]
        public int BufferMemoryNonPagedPool { get => ReadHere<int>(nameof(BufferMemoryNonPagedPool)); set => WriteHere(nameof(BufferMemoryNonPagedPool), value); }

        [Offset(8UL)]
        public ulong EventsLoggedCount { get => ReadHere<ulong>(nameof(EventsLoggedCount)); set => WriteHere(nameof(EventsLoggedCount), value); }

        [Offset(16UL)]
        public int EventsLost { get => ReadHere<int>(nameof(EventsLost)); set => WriteHere(nameof(EventsLost), value); }

        [Offset(20UL)]
        public int NumConsumers { get => ReadHere<int>(nameof(NumConsumers)); set => WriteHere(nameof(NumConsumers), value); }

        public EtwSessionPerfCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwSessionPerfCounters>();
        }
    }
}