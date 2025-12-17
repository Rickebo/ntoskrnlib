using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_WORK_QUEUE")]
    public sealed class ExWorkQueue : DynamicStructure
    {
        [Offset(0UL)]
        public Kpriqueue WorkPriQueue { get => ReadStructure<Kpriqueue>(nameof(WorkPriQueue)); set => WriteStructure(nameof(WorkPriQueue), value); }

        [Offset(688UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(696UL)]
        public IntPtr Node { get => ReadHere<IntPtr>(nameof(Node)); set => WriteHere(nameof(Node), value); }

        [Offset(704UL)]
        public uint WorkItemsProcessed { get => ReadHere<uint>(nameof(WorkItemsProcessed)); set => WriteHere(nameof(WorkItemsProcessed), value); }

        [Offset(708UL)]
        public uint WorkItemsProcessedLastPass { get => ReadHere<uint>(nameof(WorkItemsProcessedLastPass)); set => WriteHere(nameof(WorkItemsProcessedLastPass), value); }

        [Offset(712UL)]
        public int ThreadCount { get => ReadHere<int>(nameof(ThreadCount)); set => WriteHere(nameof(ThreadCount), value); }

        [Offset(716UL)]
        public int MinThreads { get => ReadHere<int>(nameof(MinThreads)); set => WriteHere(nameof(MinThreads), value); }

        [Offset(716UL)]
        public uint TryFailed { get => ReadHere<uint>(nameof(TryFailed)); set => WriteHere(nameof(TryFailed), value); }

        [Offset(720UL)]
        public int MaxThreads { get => ReadHere<int>(nameof(MaxThreads)); set => WriteHere(nameof(MaxThreads), value); }

        [Offset(724UL)]
        public uint QueueIndex { get => ReadHere<uint>(nameof(QueueIndex)); set => WriteHere(nameof(QueueIndex), value); }

        [Offset(728UL)]
        public IntPtr AllThreadsExitedEvent { get => ReadHere<IntPtr>(nameof(AllThreadsExitedEvent)); set => WriteHere(nameof(AllThreadsExitedEvent), value); }

        public ExWorkQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExWorkQueue>();
        }
    }
}