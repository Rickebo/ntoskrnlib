using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_WORK_ORDER")]
    public sealed class PopFxWorkOrder : DynamicStructure
    {
        [Offset(0UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(32UL)]
        public int WorkCount { get => ReadHere<int>(nameof(WorkCount)); set => WriteHere(nameof(WorkCount), value); }

        [Offset(40UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(48UL)]
        public IntPtr WatchdogTimerInfo { get => ReadHere<IntPtr>(nameof(WatchdogTimerInfo)); set => WriteHere(nameof(WatchdogTimerInfo), value); }

        public PopFxWorkOrder(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxWorkOrder>();
        }
    }
}