using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGELIST_STATE")]
    public sealed class MiPagelistState : DynamicStructure
    {
        [Offset(0UL)]
        public int ActiveSpinLock { get => ReadHere<int>(nameof(ActiveSpinLock)); set => WriteHere(nameof(ActiveSpinLock), value); }

        [Offset(8UL)]
        public RtlAvlTree ActiveThreadTree { get => ReadStructure<RtlAvlTree>(nameof(ActiveThreadTree)); set => WriteStructure(nameof(ActiveThreadTree), value); }

        [Offset(16UL)]
        public int ActiveZeroSpinLock { get => ReadHere<int>(nameof(ActiveZeroSpinLock)); set => WriteHere(nameof(ActiveZeroSpinLock), value); }

        [Offset(24UL)]
        public RtlAvlTree ActiveZeroThreadTree { get => ReadStructure<RtlAvlTree>(nameof(ActiveZeroThreadTree)); set => WriteStructure(nameof(ActiveZeroThreadTree), value); }

        [Offset(32UL)]
        public Mmpfn LargePfnTemplate { get => ReadStructure<Mmpfn>(nameof(LargePfnTemplate)); set => WriteStructure(nameof(LargePfnTemplate), value); }

        [Offset(80UL)]
        public Mmpfn LargePfnBasePageTemplate { get => ReadStructure<Mmpfn>(nameof(LargePfnBasePageTemplate)); set => WriteStructure(nameof(LargePfnBasePageTemplate), value); }

        [Offset(128UL)]
        public uint NumberOfZeroFreePageListHeads { get => ReadHere<uint>(nameof(NumberOfZeroFreePageListHeads)); set => WriteHere(nameof(NumberOfZeroFreePageListHeads), value); }

        [Offset(136UL)]
        public Kevent Phase1BootComplete { get => ReadStructure<Kevent>(nameof(Phase1BootComplete)); set => WriteStructure(nameof(Phase1BootComplete), value); }

        [Offset(160UL)]
        public RtlAvlTree PendingBadPageTree { get => ReadStructure<RtlAvlTree>(nameof(PendingBadPageTree)); set => WriteStructure(nameof(PendingBadPageTree), value); }

        [Offset(168UL)]
        public ulong PendingBadPageCount { get => ReadHere<ulong>(nameof(PendingBadPageCount)); set => WriteHere(nameof(PendingBadPageCount), value); }

        [Offset(176UL)]
        public int PendingBadPageTreeLock { get => ReadHere<int>(nameof(PendingBadPageTreeLock)); set => WriteHere(nameof(PendingBadPageTreeLock), value); }

        [Offset(184UL)]
        public ulong PendingBadPagesWithoutNodesCount { get => ReadHere<ulong>(nameof(PendingBadPagesWithoutNodesCount)); set => WriteHere(nameof(PendingBadPagesWithoutNodesCount), value); }

        [Offset(192UL)]
        public ListEntry PendingBadPageNodesAwaitingDeleteList { get => ReadStructure<ListEntry>(nameof(PendingBadPageNodesAwaitingDeleteList)); set => WriteStructure(nameof(PendingBadPageNodesAwaitingDeleteList), value); }

        [Offset(208UL)]
        public ulong PendingBadPageNodesAwaitingDeleteCount { get => ReadHere<ulong>(nameof(PendingBadPageNodesAwaitingDeleteCount)); set => WriteHere(nameof(PendingBadPageNodesAwaitingDeleteCount), value); }

        [Offset(216UL)]
        public byte PendingBadPageNodeDeleteActive { get => ReadHere<byte>(nameof(PendingBadPageNodeDeleteActive)); set => WriteHere(nameof(PendingBadPageNodeDeleteActive), value); }

        [Offset(224UL)]
        public WorkQueueItem PendingBadPageNodeDeleteWorkItem { get => ReadStructure<WorkQueueItem>(nameof(PendingBadPageNodeDeleteWorkItem)); set => WriteStructure(nameof(PendingBadPageNodeDeleteWorkItem), value); }

        [Offset(256UL)]
        public RtlAvlTree BadHugePageTree { get => ReadStructure<RtlAvlTree>(nameof(BadHugePageTree)); set => WriteStructure(nameof(BadHugePageTree), value); }

        [Offset(264UL)]
        public ulong BadHugePageCount { get => ReadHere<ulong>(nameof(BadHugePageCount)); set => WriteHere(nameof(BadHugePageCount), value); }

        public MiPagelistState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPagelistState>();
        }
    }
}