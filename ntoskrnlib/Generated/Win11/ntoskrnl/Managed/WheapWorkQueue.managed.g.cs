using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEAP_WORK_QUEUE")]
    public sealed class WheapWorkQueue : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListHead { get => ReadStructure<ListEntry>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(16UL)]
        public ulong ListLock { get => ReadHere<ulong>(nameof(ListLock)); set => WriteHere(nameof(ListLock), value); }

        [Offset(24UL)]
        public int ItemCount { get => ReadHere<int>(nameof(ItemCount)); set => WriteHere(nameof(ItemCount), value); }

        [Offset(32UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(96UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(128UL)]
        public IntPtr WorkRoutine { get => ReadHere<IntPtr>(nameof(WorkRoutine)); set => WriteHere(nameof(WorkRoutine), value); }

        public WheapWorkQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheapWorkQueue>();
        }
    }
}