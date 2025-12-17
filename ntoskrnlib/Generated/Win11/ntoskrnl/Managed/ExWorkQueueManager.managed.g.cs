using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_WORK_QUEUE_MANAGER")]
    public sealed class ExWorkQueueManager : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(8UL)]
        public IntPtr Node { get => ReadHere<IntPtr>(nameof(Node)); set => WriteHere(nameof(Node), value); }

        [Offset(16UL)]
        public Kevent Event { get => ReadStructure<Kevent>(nameof(Event)); set => WriteStructure(nameof(Event), value); }

        [Offset(40UL)]
        public Ktimer DeadlockTimer { get => ReadStructure<Ktimer>(nameof(DeadlockTimer)); set => WriteStructure(nameof(DeadlockTimer), value); }

        [Offset(104UL)]
        public Kevent ReaperEvent { get => ReadStructure<Kevent>(nameof(ReaperEvent)); set => WriteStructure(nameof(ReaperEvent), value); }

        [Offset(128UL)]
        public KTIMER2 ReaperTimer { get => ReadStructure<KTIMER2>(nameof(ReaperTimer)); set => WriteStructure(nameof(ReaperTimer), value); }

        [Offset(264UL)]
        public IntPtr ThreadHandle { get => ReadHere<IntPtr>(nameof(ThreadHandle)); set => WriteHere(nameof(ThreadHandle), value); }

        [Offset(272UL)]
        public uint ExitThread { get => ReadHere<uint>(nameof(ExitThread)); set => WriteHere(nameof(ExitThread), value); }

        [Offset(276UL)]
        public ushort ThreadSeed { get => ReadHere<ushort>(nameof(ThreadSeed)); set => WriteHere(nameof(ThreadSeed), value); }

        public ExWorkQueueManager(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExWorkQueueManager>();
        }
    }
}