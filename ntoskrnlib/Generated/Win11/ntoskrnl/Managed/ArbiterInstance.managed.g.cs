using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_INSTANCE")]
    public sealed class ArbiterInstance : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(8UL)]
        public IntPtr MutexEvent { get => ReadHere<IntPtr>(nameof(MutexEvent)); set => WriteHere(nameof(MutexEvent), value); }

        [Offset(16UL)]
        public IntPtr Name { get => ReadHere<IntPtr>(nameof(Name)); set => WriteHere(nameof(Name), value); }

        [Offset(24UL)]
        public IntPtr OrderingName { get => ReadHere<IntPtr>(nameof(OrderingName)); set => WriteHere(nameof(OrderingName), value); }

        [Offset(32UL)]
        public int ResourceType { get => ReadHere<int>(nameof(ResourceType)); set => WriteHere(nameof(ResourceType), value); }

        [Offset(40UL)]
        public IntPtr Allocation { get => ReadHere<IntPtr>(nameof(Allocation)); set => WriteHere(nameof(Allocation), value); }

        [Offset(48UL)]
        public IntPtr PossibleAllocation { get => ReadHere<IntPtr>(nameof(PossibleAllocation)); set => WriteHere(nameof(PossibleAllocation), value); }

        [Offset(56UL)]
        public ArbiterOrderingList OrderingList { get => ReadStructure<ArbiterOrderingList>(nameof(OrderingList)); set => WriteStructure(nameof(OrderingList), value); }

        [Offset(72UL)]
        public ArbiterOrderingList ReservedList { get => ReadStructure<ArbiterOrderingList>(nameof(ReservedList)); set => WriteStructure(nameof(ReservedList), value); }

        [Offset(88UL)]
        public int ReferenceCount { get => ReadHere<int>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(96UL)]
        public IntPtr Interface { get => ReadHere<IntPtr>(nameof(Interface)); set => WriteHere(nameof(Interface), value); }

        [Offset(104UL)]
        public uint AllocationStackMaxSize { get => ReadHere<uint>(nameof(AllocationStackMaxSize)); set => WriteHere(nameof(AllocationStackMaxSize), value); }

        [Offset(112UL)]
        public IntPtr AllocationStack { get => ReadHere<IntPtr>(nameof(AllocationStack)); set => WriteHere(nameof(AllocationStack), value); }

        [Offset(120UL)]
        public IntPtr UnpackRequirement { get => ReadHere<IntPtr>(nameof(UnpackRequirement)); set => WriteHere(nameof(UnpackRequirement), value); }

        [Offset(128UL)]
        public IntPtr PackResource { get => ReadHere<IntPtr>(nameof(PackResource)); set => WriteHere(nameof(PackResource), value); }

        [Offset(136UL)]
        public IntPtr UnpackResource { get => ReadHere<IntPtr>(nameof(UnpackResource)); set => WriteHere(nameof(UnpackResource), value); }

        [Offset(144UL)]
        public IntPtr ScoreRequirement { get => ReadHere<IntPtr>(nameof(ScoreRequirement)); set => WriteHere(nameof(ScoreRequirement), value); }

        [Offset(152UL)]
        public IntPtr TestAllocation { get => ReadHere<IntPtr>(nameof(TestAllocation)); set => WriteHere(nameof(TestAllocation), value); }

        [Offset(160UL)]
        public IntPtr RetestAllocation { get => ReadHere<IntPtr>(nameof(RetestAllocation)); set => WriteHere(nameof(RetestAllocation), value); }

        [Offset(168UL)]
        public IntPtr CommitAllocation { get => ReadHere<IntPtr>(nameof(CommitAllocation)); set => WriteHere(nameof(CommitAllocation), value); }

        [Offset(176UL)]
        public IntPtr RollbackAllocation { get => ReadHere<IntPtr>(nameof(RollbackAllocation)); set => WriteHere(nameof(RollbackAllocation), value); }

        [Offset(184UL)]
        public IntPtr BootAllocation { get => ReadHere<IntPtr>(nameof(BootAllocation)); set => WriteHere(nameof(BootAllocation), value); }

        [Offset(192UL)]
        public IntPtr QueryArbitrate { get => ReadHere<IntPtr>(nameof(QueryArbitrate)); set => WriteHere(nameof(QueryArbitrate), value); }

        [Offset(200UL)]
        public IntPtr QueryConflict { get => ReadHere<IntPtr>(nameof(QueryConflict)); set => WriteHere(nameof(QueryConflict), value); }

        [Offset(208UL)]
        public IntPtr AddReserved { get => ReadHere<IntPtr>(nameof(AddReserved)); set => WriteHere(nameof(AddReserved), value); }

        [Offset(216UL)]
        public IntPtr StartArbiter { get => ReadHere<IntPtr>(nameof(StartArbiter)); set => WriteHere(nameof(StartArbiter), value); }

        [Offset(224UL)]
        public IntPtr PreprocessEntry { get => ReadHere<IntPtr>(nameof(PreprocessEntry)); set => WriteHere(nameof(PreprocessEntry), value); }

        [Offset(232UL)]
        public IntPtr AllocateEntry { get => ReadHere<IntPtr>(nameof(AllocateEntry)); set => WriteHere(nameof(AllocateEntry), value); }

        [Offset(240UL)]
        public IntPtr GetNextAllocationRange { get => ReadHere<IntPtr>(nameof(GetNextAllocationRange)); set => WriteHere(nameof(GetNextAllocationRange), value); }

        [Offset(248UL)]
        public IntPtr FindSuitableRange { get => ReadHere<IntPtr>(nameof(FindSuitableRange)); set => WriteHere(nameof(FindSuitableRange), value); }

        [Offset(256UL)]
        public IntPtr AddAllocation { get => ReadHere<IntPtr>(nameof(AddAllocation)); set => WriteHere(nameof(AddAllocation), value); }

        [Offset(264UL)]
        public IntPtr BacktrackAllocation { get => ReadHere<IntPtr>(nameof(BacktrackAllocation)); set => WriteHere(nameof(BacktrackAllocation), value); }

        [Offset(272UL)]
        public IntPtr OverrideConflict { get => ReadHere<IntPtr>(nameof(OverrideConflict)); set => WriteHere(nameof(OverrideConflict), value); }

        [Offset(280UL)]
        public IntPtr InitializeRangeList { get => ReadHere<IntPtr>(nameof(InitializeRangeList)); set => WriteHere(nameof(InitializeRangeList), value); }

        [Offset(288UL)]
        public IntPtr DeleteOwnerRanges { get => ReadHere<IntPtr>(nameof(DeleteOwnerRanges)); set => WriteHere(nameof(DeleteOwnerRanges), value); }

        [Offset(296UL)]
        public byte TransactionInProgress { get => ReadHere<byte>(nameof(TransactionInProgress)); set => WriteHere(nameof(TransactionInProgress), value); }

        [Offset(304UL)]
        public IntPtr TransactionEvent { get => ReadHere<IntPtr>(nameof(TransactionEvent)); set => WriteHere(nameof(TransactionEvent), value); }

        [Offset(312UL)]
        public IntPtr Extension { get => ReadHere<IntPtr>(nameof(Extension)); set => WriteHere(nameof(Extension), value); }

        [Offset(320UL)]
        public IntPtr BusDeviceObject { get => ReadHere<IntPtr>(nameof(BusDeviceObject)); set => WriteHere(nameof(BusDeviceObject), value); }

        [Offset(328UL)]
        public IntPtr ConflictCallbackContext { get => ReadHere<IntPtr>(nameof(ConflictCallbackContext)); set => WriteHere(nameof(ConflictCallbackContext), value); }

        [Offset(336UL)]
        public IntPtr ConflictCallback { get => ReadHere<IntPtr>(nameof(ConflictCallback)); set => WriteHere(nameof(ConflictCallback), value); }

        public ArbiterInstance(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterInstance>();
        }
    }
}