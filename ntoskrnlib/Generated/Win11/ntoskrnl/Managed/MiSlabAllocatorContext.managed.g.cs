using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SLAB_ALLOCATOR_CONTEXT")]
    public sealed class MiSlabAllocatorContext : DynamicStructure
    {
        [Offset(0UL)]
        public RtlRbTree SlabTree { get => ReadStructure<RtlRbTree>(nameof(SlabTree)); set => WriteStructure(nameof(SlabTree), value); }

        [Offset(16UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(24UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(32UL)]
        public UnnamedTag Hints { get => ReadStructure<UnnamedTag>(nameof(Hints)); set => WriteStructure(nameof(Hints), value); }

        [Offset(64UL)]
        public IntPtr StandbyPageCache { get => ReadHere<IntPtr>(nameof(StandbyPageCache)); set => WriteHere(nameof(StandbyPageCache), value); }

        [Offset(72UL)]
        public IntPtr StandbyPageList { get => ReadHere<IntPtr>(nameof(StandbyPageList)); set => WriteHere(nameof(StandbyPageList), value); }

        [Offset(80UL)]
        public IntPtr RepurposedStandbyPageList { get => ReadHere<IntPtr>(nameof(RepurposedStandbyPageList)); set => WriteHere(nameof(RepurposedStandbyPageList), value); }

        [Offset(88UL)]
        public IntPtr SlabListsByIdentity { get => ReadHere<IntPtr>(nameof(SlabListsByIdentity)); set => WriteHere(nameof(SlabListsByIdentity), value); }

        [Offset(96UL)]
        public ulong FreePageCount { get => ReadHere<ulong>(nameof(FreePageCount)); set => WriteHere(nameof(FreePageCount), value); }

        [Offset(104UL)]
        public ulong AvailablePagesGoal { get => ReadHere<ulong>(nameof(AvailablePagesGoal)); set => WriteHere(nameof(AvailablePagesGoal), value); }

        [Offset(112UL)]
        public ulong ChargedPageCount { get => ReadHere<ulong>(nameof(ChargedPageCount)); set => WriteHere(nameof(ChargedPageCount), value); }

        [Offset(120UL)]
        public ulong SlabEntryCount { get => ReadHere<ulong>(nameof(SlabEntryCount)); set => WriteHere(nameof(SlabEntryCount), value); }

        [Offset(128UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(132UL)]
        public MiNodeNumberZeroBased NumaNodeIndex { get => ReadStructure<MiNodeNumberZeroBased>(nameof(NumaNodeIndex)); set => WriteStructure(nameof(NumaNodeIndex), value); }

        [Offset(136UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(140UL)]
        public int ReEvaluateAllocationHint { get => ReadHere<int>(nameof(ReEvaluateAllocationHint)); set => WriteHere(nameof(ReEvaluateAllocationHint), value); }

        [Offset(144UL)]
        public uint SlabEntriesAllocated { get => ReadHere<uint>(nameof(SlabEntriesAllocated)); set => WriteHere(nameof(SlabEntriesAllocated), value); }

        [Offset(148UL)]
        public uint SlabEntriesDemoted { get => ReadHere<uint>(nameof(SlabEntriesDemoted)); set => WriteHere(nameof(SlabEntriesDemoted), value); }

        [Offset(152UL)]
        public uint SlabEntriesFailedFast { get => ReadHere<uint>(nameof(SlabEntriesFailedFast)); set => WriteHere(nameof(SlabEntriesFailedFast), value); }

        [Offset(156UL)]
        public uint SlabEntriesFailedSlow { get => ReadHere<uint>(nameof(SlabEntriesFailedSlow)); set => WriteHere(nameof(SlabEntriesFailedSlow), value); }

        [Offset(160UL)]
        public uint SlabPagesFreedNonZeroed { get => ReadHere<uint>(nameof(SlabPagesFreedNonZeroed)); set => WriteHere(nameof(SlabPagesFreedNonZeroed), value); }

        [Offset(164UL)]
        public uint SlabPagesCrossIdentity { get => ReadHere<uint>(nameof(SlabPagesCrossIdentity)); set => WriteHere(nameof(SlabPagesCrossIdentity), value); }

        [Offset(168UL)]
        public ulong LastReplenishTime { get => ReadHere<ulong>(nameof(LastReplenishTime)); set => WriteHere(nameof(LastReplenishTime), value); }

        [Offset(176UL)]
        public ulong LastFailureTime { get => ReadHere<ulong>(nameof(LastFailureTime)); set => WriteHere(nameof(LastFailureTime), value); }

        [Offset(184UL)]
        public WorkQueueItem ReplenishWorkItem { get => ReadStructure<WorkQueueItem>(nameof(ReplenishWorkItem)); set => WriteStructure(nameof(ReplenishWorkItem), value); }

        [Offset(216UL)]
        public ListEntry ReplenishWaitList { get => ReadStructure<ListEntry>(nameof(ReplenishWaitList)); set => WriteStructure(nameof(ReplenishWaitList), value); }

        public MiSlabAllocatorContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSlabAllocatorContext>();
        }
    }
}