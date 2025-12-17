using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_COMBINE_WORKITEM")]
    public sealed class MiCombineWorkitem : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr NextEntry { get => ReadHere<IntPtr>(nameof(NextEntry)); set => WriteHere(nameof(NextEntry), value); }

        [Offset(8UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        public MiCombineWorkitem(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiCombineWorkitem>();
        }
    }
}