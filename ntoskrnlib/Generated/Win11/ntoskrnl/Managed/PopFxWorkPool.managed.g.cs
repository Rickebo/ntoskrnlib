using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_WORK_POOL")]
    public sealed class PopFxWorkPool : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Plugin { get => ReadHere<IntPtr>(nameof(Plugin)); set => WriteHere(nameof(Plugin), value); }

        [Offset(8UL)]
        public ulong EmergencyWorkQueueLock { get => ReadHere<ulong>(nameof(EmergencyWorkQueueLock)); set => WriteHere(nameof(EmergencyWorkQueueLock), value); }

        [Offset(16UL)]
        public ListEntry EmergencyWorkQueue { get => ReadStructure<ListEntry>(nameof(EmergencyWorkQueue)); set => WriteStructure(nameof(EmergencyWorkQueue), value); }

        [Offset(32UL)]
        [Length(2)]
        public DynamicArray WorkPoolQueues { get => ReadStructure<DynamicArray>(nameof(WorkPoolQueues)); set => WriteStructure(nameof(WorkPoolQueues), value); }

        [Offset(96UL)]
        public int WorkItemStatus { get => ReadHere<int>(nameof(WorkItemStatus)); set => WriteHere(nameof(WorkItemStatus), value); }

        [Offset(104UL)]
        [Length(4)]
        public DynamicArray WorkItems { get => ReadStructure<DynamicArray>(nameof(WorkItems)); set => WriteStructure(nameof(WorkItems), value); }

        [Offset(264UL)]
        [Length(5)]
        public DynamicArray PoolWorkerThreads { get => ReadStructure<DynamicArray>(nameof(PoolWorkerThreads)); set => WriteStructure(nameof(PoolWorkerThreads), value); }

        public PopFxWorkPool(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxWorkPool>();
        }
    }
}