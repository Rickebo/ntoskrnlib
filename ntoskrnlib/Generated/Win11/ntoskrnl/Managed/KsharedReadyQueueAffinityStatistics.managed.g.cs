using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSHARED_READY_QUEUE_AFFINITY_STATISTICS")]
    public sealed class KsharedReadyQueueAffinityStatistics : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AffinitySummary { get => ReadHere<ulong>(nameof(AffinitySummary)); set => WriteHere(nameof(AffinitySummary), value); }

        public KsharedReadyQueueAffinityStatistics(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsharedReadyQueueAffinityStatistics>();
        }
    }
}