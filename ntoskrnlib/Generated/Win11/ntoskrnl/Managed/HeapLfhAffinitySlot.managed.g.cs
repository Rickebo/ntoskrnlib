using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_AFFINITY_SLOT")]
    public sealed class HeapLfhAffinitySlot : DynamicStructure
    {
        [Offset(0UL)]
        public HeapLfhSubsegmentOwner State { get => ReadStructure<HeapLfhSubsegmentOwner>(nameof(State)); set => WriteStructure(nameof(State), value); }

        [Offset(56UL)]
        public HeapLfhFastRef ActiveSubsegment { get => ReadStructure<HeapLfhFastRef>(nameof(ActiveSubsegment)); set => WriteStructure(nameof(ActiveSubsegment), value); }

        public HeapLfhAffinitySlot(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhAffinitySlot>();
        }
    }
}