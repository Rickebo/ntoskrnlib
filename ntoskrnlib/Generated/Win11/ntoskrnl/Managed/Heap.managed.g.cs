using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP")]
    public sealed class Heap : DynamicStructure
    {
        [Offset(0UL)]
        public HeapSegment Segment { get => ReadStructure<HeapSegment>(nameof(Segment)); set => WriteStructure(nameof(Segment), value); }

        [Offset(0UL)]
        public HeapEntry Entry { get => ReadStructure<HeapEntry>(nameof(Entry)); set => WriteStructure(nameof(Entry), value); }

        [Offset(16UL)]
        public uint SegmentSignature { get => ReadHere<uint>(nameof(SegmentSignature)); set => WriteHere(nameof(SegmentSignature), value); }

        [Offset(20UL)]
        public uint SegmentFlags { get => ReadHere<uint>(nameof(SegmentFlags)); set => WriteHere(nameof(SegmentFlags), value); }

        [Offset(24UL)]
        public ListEntry SegmentListEntry { get => ReadStructure<ListEntry>(nameof(SegmentListEntry)); set => WriteStructure(nameof(SegmentListEntry), value); }

        [Offset(40UL)]
        public IntPtr BaseHeap { get => ReadHere<IntPtr>(nameof(BaseHeap)); set => WriteHere(nameof(BaseHeap), value); }

        [Offset(48UL)]
        public IntPtr BaseAddress { get => ReadHere<IntPtr>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(56UL)]
        public uint NumberOfPages { get => ReadHere<uint>(nameof(NumberOfPages)); set => WriteHere(nameof(NumberOfPages), value); }

        [Offset(64UL)]
        public IntPtr FirstEntry { get => ReadHere<IntPtr>(nameof(FirstEntry)); set => WriteHere(nameof(FirstEntry), value); }

        [Offset(72UL)]
        public IntPtr LastValidEntry { get => ReadHere<IntPtr>(nameof(LastValidEntry)); set => WriteHere(nameof(LastValidEntry), value); }

        [Offset(80UL)]
        public uint NumberOfUnCommittedPages { get => ReadHere<uint>(nameof(NumberOfUnCommittedPages)); set => WriteHere(nameof(NumberOfUnCommittedPages), value); }

        [Offset(84UL)]
        public uint NumberOfUnCommittedRanges { get => ReadHere<uint>(nameof(NumberOfUnCommittedRanges)); set => WriteHere(nameof(NumberOfUnCommittedRanges), value); }

        [Offset(88UL)]
        public ushort SegmentAllocatorBackTraceIndex { get => ReadHere<ushort>(nameof(SegmentAllocatorBackTraceIndex)); set => WriteHere(nameof(SegmentAllocatorBackTraceIndex), value); }

        [Offset(90UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(96UL)]
        public ListEntry UCRSegmentList { get => ReadStructure<ListEntry>(nameof(UCRSegmentList)); set => WriteStructure(nameof(UCRSegmentList), value); }

        [Offset(112UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(116UL)]
        public uint ForceFlags { get => ReadHere<uint>(nameof(ForceFlags)); set => WriteHere(nameof(ForceFlags), value); }

        [Offset(120UL)]
        public uint CompatibilityFlags { get => ReadHere<uint>(nameof(CompatibilityFlags)); set => WriteHere(nameof(CompatibilityFlags), value); }

        [Offset(124UL)]
        public uint EncodeFlagMask { get => ReadHere<uint>(nameof(EncodeFlagMask)); set => WriteHere(nameof(EncodeFlagMask), value); }

        [Offset(128UL)]
        public HeapEntry Encoding { get => ReadStructure<HeapEntry>(nameof(Encoding)); set => WriteStructure(nameof(Encoding), value); }

        [Offset(144UL)]
        public uint Interceptor { get => ReadHere<uint>(nameof(Interceptor)); set => WriteHere(nameof(Interceptor), value); }

        [Offset(148UL)]
        public uint VirtualMemoryThreshold { get => ReadHere<uint>(nameof(VirtualMemoryThreshold)); set => WriteHere(nameof(VirtualMemoryThreshold), value); }

        [Offset(152UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(160UL)]
        public ulong SegmentReserve { get => ReadHere<ulong>(nameof(SegmentReserve)); set => WriteHere(nameof(SegmentReserve), value); }

        [Offset(168UL)]
        public ulong SegmentCommit { get => ReadHere<ulong>(nameof(SegmentCommit)); set => WriteHere(nameof(SegmentCommit), value); }

        [Offset(176UL)]
        public ulong DeCommitFreeBlockThreshold { get => ReadHere<ulong>(nameof(DeCommitFreeBlockThreshold)); set => WriteHere(nameof(DeCommitFreeBlockThreshold), value); }

        [Offset(184UL)]
        public ulong DeCommitTotalFreeThreshold { get => ReadHere<ulong>(nameof(DeCommitTotalFreeThreshold)); set => WriteHere(nameof(DeCommitTotalFreeThreshold), value); }

        [Offset(192UL)]
        public ulong TotalFreeSize { get => ReadHere<ulong>(nameof(TotalFreeSize)); set => WriteHere(nameof(TotalFreeSize), value); }

        [Offset(200UL)]
        public ulong MaximumAllocationSize { get => ReadHere<ulong>(nameof(MaximumAllocationSize)); set => WriteHere(nameof(MaximumAllocationSize), value); }

        [Offset(208UL)]
        public ushort ProcessHeapsListIndex { get => ReadHere<ushort>(nameof(ProcessHeapsListIndex)); set => WriteHere(nameof(ProcessHeapsListIndex), value); }

        [Offset(210UL)]
        public ushort HeaderValidateLength { get => ReadHere<ushort>(nameof(HeaderValidateLength)); set => WriteHere(nameof(HeaderValidateLength), value); }

        [Offset(216UL)]
        public IntPtr HeaderValidateCopy { get => ReadHere<IntPtr>(nameof(HeaderValidateCopy)); set => WriteHere(nameof(HeaderValidateCopy), value); }

        [Offset(224UL)]
        public ushort NextAvailableTagIndex { get => ReadHere<ushort>(nameof(NextAvailableTagIndex)); set => WriteHere(nameof(NextAvailableTagIndex), value); }

        [Offset(226UL)]
        public ushort MaximumTagIndex { get => ReadHere<ushort>(nameof(MaximumTagIndex)); set => WriteHere(nameof(MaximumTagIndex), value); }

        [Offset(232UL)]
        public IntPtr TagEntries { get => ReadHere<IntPtr>(nameof(TagEntries)); set => WriteHere(nameof(TagEntries), value); }

        [Offset(240UL)]
        public ListEntry UCRList { get => ReadStructure<ListEntry>(nameof(UCRList)); set => WriteStructure(nameof(UCRList), value); }

        [Offset(256UL)]
        public ulong AlignRound { get => ReadHere<ulong>(nameof(AlignRound)); set => WriteHere(nameof(AlignRound), value); }

        [Offset(264UL)]
        public ulong AlignMask { get => ReadHere<ulong>(nameof(AlignMask)); set => WriteHere(nameof(AlignMask), value); }

        [Offset(272UL)]
        public ListEntry VirtualAllocdBlocks { get => ReadStructure<ListEntry>(nameof(VirtualAllocdBlocks)); set => WriteStructure(nameof(VirtualAllocdBlocks), value); }

        [Offset(288UL)]
        public ListEntry SegmentList { get => ReadStructure<ListEntry>(nameof(SegmentList)); set => WriteStructure(nameof(SegmentList), value); }

        [Offset(304UL)]
        public ushort AllocatorBackTraceIndex { get => ReadHere<ushort>(nameof(AllocatorBackTraceIndex)); set => WriteHere(nameof(AllocatorBackTraceIndex), value); }

        [Offset(308UL)]
        public uint NonDedicatedListLength { get => ReadHere<uint>(nameof(NonDedicatedListLength)); set => WriteHere(nameof(NonDedicatedListLength), value); }

        [Offset(312UL)]
        public IntPtr BlocksIndex { get => ReadHere<IntPtr>(nameof(BlocksIndex)); set => WriteHere(nameof(BlocksIndex), value); }

        [Offset(320UL)]
        public IntPtr UCRIndex { get => ReadHere<IntPtr>(nameof(UCRIndex)); set => WriteHere(nameof(UCRIndex), value); }

        [Offset(328UL)]
        public IntPtr PseudoTagEntries { get => ReadHere<IntPtr>(nameof(PseudoTagEntries)); set => WriteHere(nameof(PseudoTagEntries), value); }

        [Offset(336UL)]
        public ListEntry FreeLists { get => ReadStructure<ListEntry>(nameof(FreeLists)); set => WriteStructure(nameof(FreeLists), value); }

        [Offset(352UL)]
        public IntPtr LockVariable { get => ReadHere<IntPtr>(nameof(LockVariable)); set => WriteHere(nameof(LockVariable), value); }

        [Offset(360UL)]
        public IntPtr CommitRoutine { get => ReadHere<IntPtr>(nameof(CommitRoutine)); set => WriteHere(nameof(CommitRoutine), value); }

        [Offset(368UL)]
        public RtlRunOnce StackTraceInitVar { get => ReadStructure<RtlRunOnce>(nameof(StackTraceInitVar)); set => WriteStructure(nameof(StackTraceInitVar), value); }

        [Offset(376UL)]
        public RtlpHeapCommitLimitData CommitLimitData { get => ReadStructure<RtlpHeapCommitLimitData>(nameof(CommitLimitData)); set => WriteStructure(nameof(CommitLimitData), value); }

        [Offset(392UL)]
        public IntPtr UserContext { get => ReadHere<IntPtr>(nameof(UserContext)); set => WriteHere(nameof(UserContext), value); }

        [Offset(400UL)]
        public ulong Spare { get => ReadHere<ulong>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(408UL)]
        public IntPtr FrontEndHeap { get => ReadHere<IntPtr>(nameof(FrontEndHeap)); set => WriteHere(nameof(FrontEndHeap), value); }

        [Offset(416UL)]
        public ushort FrontHeapLockCount { get => ReadHere<ushort>(nameof(FrontHeapLockCount)); set => WriteHere(nameof(FrontHeapLockCount), value); }

        [Offset(418UL)]
        public byte FrontEndHeapType { get => ReadHere<byte>(nameof(FrontEndHeapType)); set => WriteHere(nameof(FrontEndHeapType), value); }

        [Offset(419UL)]
        public byte RequestedFrontEndHeapType { get => ReadHere<byte>(nameof(RequestedFrontEndHeapType)); set => WriteHere(nameof(RequestedFrontEndHeapType), value); }

        [Offset(424UL)]
        public IntPtr FrontEndHeapUsageData { get => ReadHere<IntPtr>(nameof(FrontEndHeapUsageData)); set => WriteHere(nameof(FrontEndHeapUsageData), value); }

        [Offset(432UL)]
        public ushort FrontEndHeapMaximumIndex { get => ReadHere<ushort>(nameof(FrontEndHeapMaximumIndex)); set => WriteHere(nameof(FrontEndHeapMaximumIndex), value); }

        [Offset(434UL)]
        [Length(129)]
        public DynamicArray FrontEndHeapStatusBitmap { get => ReadStructure<DynamicArray>(nameof(FrontEndHeapStatusBitmap)); set => WriteStructure(nameof(FrontEndHeapStatusBitmap), value); }

        [Offset(563UL)]
        public byte ReadOnly { get => ReadHere<byte>(nameof(ReadOnly)); set => WriteHere(nameof(ReadOnly), value); }

        [Offset(563UL)]
        public byte InternalFlags { get => ReadHere<byte>(nameof(InternalFlags)); set => WriteHere(nameof(InternalFlags), value); }

        [Offset(568UL)]
        public HeapCounters Counters { get => ReadStructure<HeapCounters>(nameof(Counters)); set => WriteStructure(nameof(Counters), value); }

        [Offset(688UL)]
        public HeapTuningParameters TuningParameters { get => ReadStructure<HeapTuningParameters>(nameof(TuningParameters)); set => WriteStructure(nameof(TuningParameters), value); }

        public Heap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Heap>();
        }
    }
}