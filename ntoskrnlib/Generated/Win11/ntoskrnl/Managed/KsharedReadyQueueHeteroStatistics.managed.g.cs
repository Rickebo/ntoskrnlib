using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSHARED_READY_QUEUE_HETERO_STATISTICS")]
    public sealed class KsharedReadyQueueHeteroStatistics : DynamicStructure
    {
        [Offset(0UL)]
        [Length(7)]
        public DynamicArray ExpectedRuntimeByClass { get => ReadStructure<DynamicArray>(nameof(ExpectedRuntimeByClass)); set => WriteStructure(nameof(ExpectedRuntimeByClass), value); }

        public KsharedReadyQueueHeteroStatistics(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsharedReadyQueueHeteroStatistics>();
        }
    }
}