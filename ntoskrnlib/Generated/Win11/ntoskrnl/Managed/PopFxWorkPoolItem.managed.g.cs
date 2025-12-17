using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_WORK_POOL_ITEM")]
    public sealed class PopFxWorkPoolItem : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr WorkPool { get => ReadHere<IntPtr>(nameof(WorkPool)); set => WriteHere(nameof(WorkPool), value); }

        [Offset(8UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        public PopFxWorkPoolItem(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxWorkPoolItem>();
        }
    }
}