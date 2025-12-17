using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WORK_QUEUE_ITEM")]
    public sealed class WorkQueueItem : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry List { get => ReadStructure<ListEntry>(nameof(List)); set => WriteStructure(nameof(List), value); }

        [Offset(16UL)]
        public IntPtr WorkerRoutine { get => ReadHere<IntPtr>(nameof(WorkerRoutine)); set => WriteHere(nameof(WorkerRoutine), value); }

        [Offset(24UL)]
        public IntPtr Parameter { get => ReadHere<IntPtr>(nameof(Parameter)); set => WriteHere(nameof(Parameter), value); }

        public WorkQueueItem(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WorkQueueItem>();
        }
    }
}