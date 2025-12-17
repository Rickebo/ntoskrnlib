using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_RESUME_WORKITEM")]
    public sealed class MiResumeWorkitem : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent ResumeCompleteEvent { get => ReadStructure<Kevent>(nameof(ResumeCompleteEvent)); set => WriteStructure(nameof(ResumeCompleteEvent), value); }

        [Offset(24UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        public MiResumeWorkitem(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiResumeWorkitem>();
        }
    }
}