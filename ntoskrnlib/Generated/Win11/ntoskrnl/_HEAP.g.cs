#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 704)]
    public partial struct _HEAP
    {
        [FieldOffset(0)]
        public _HEAP_SEGMENT Segment;
        [FieldOffset(0)]
        public _HEAP_ENTRY Entry;
        [FieldOffset(16)]
        public uint SegmentSignature;
        [FieldOffset(20)]
        public uint SegmentFlags;
        [FieldOffset(24)]
        public _LIST_ENTRY SegmentListEntry;
        [FieldOffset(40)]
        public IntPtr Heap;
        [FieldOffset(48)]
        public IntPtr BaseAddress;
        [FieldOffset(56)]
        public uint NumberOfPages;
        [FieldOffset(64)]
        public IntPtr FirstEntry;
        [FieldOffset(72)]
        public IntPtr LastValidEntry;
        [FieldOffset(80)]
        public uint NumberOfUnCommittedPages;
        [FieldOffset(84)]
        public uint NumberOfUnCommittedRanges;
        [FieldOffset(88)]
        public ushort SegmentAllocatorBackTraceIndex;
        [FieldOffset(90)]
        public ushort Reserved;
        [FieldOffset(96)]
        public _LIST_ENTRY UCRSegmentList;
        [FieldOffset(112)]
        public uint Flags;
        [FieldOffset(116)]
        public uint ForceFlags;
        [FieldOffset(120)]
        public uint CompatibilityFlags;
        [FieldOffset(124)]
        public uint EncodeFlagMask;
        [FieldOffset(128)]
        public _HEAP_ENTRY Encoding;
        [FieldOffset(144)]
        public uint Interceptor;
        [FieldOffset(148)]
        public uint VirtualMemoryThreshold;
        [FieldOffset(152)]
        public uint Signature;
        [FieldOffset(160)]
        public ulong SegmentReserve;
        [FieldOffset(168)]
        public ulong SegmentCommit;
        [FieldOffset(176)]
        public ulong DeCommitFreeBlockThreshold;
        [FieldOffset(184)]
        public ulong DeCommitTotalFreeThreshold;
        [FieldOffset(192)]
        public ulong TotalFreeSize;
        [FieldOffset(200)]
        public ulong MaximumAllocationSize;
        [FieldOffset(208)]
        public ushort ProcessHeapsListIndex;
        [FieldOffset(210)]
        public ushort HeaderValidateLength;
        [FieldOffset(216)]
        public IntPtr HeaderValidateCopy;
        [FieldOffset(224)]
        public ushort NextAvailableTagIndex;
        [FieldOffset(226)]
        public ushort MaximumTagIndex;
        [FieldOffset(232)]
        public IntPtr TagEntries;
        [FieldOffset(240)]
        public _LIST_ENTRY UCRList;
        [FieldOffset(256)]
        public ulong AlignRound;
        [FieldOffset(264)]
        public ulong AlignMask;
        [FieldOffset(272)]
        public _LIST_ENTRY VirtualAllocdBlocks;
        [FieldOffset(288)]
        public _LIST_ENTRY SegmentList;
        [FieldOffset(304)]
        public ushort AllocatorBackTraceIndex;
        [FieldOffset(308)]
        public uint NonDedicatedListLength;
        [FieldOffset(312)]
        public IntPtr BlocksIndex;
        [FieldOffset(320)]
        public IntPtr UCRIndex;
        [FieldOffset(328)]
        public IntPtr PseudoTagEntries;
        [FieldOffset(336)]
        public _LIST_ENTRY FreeLists;
        [FieldOffset(352)]
        public IntPtr LockVariable;
        [FieldOffset(360)]
        public IntPtr CommitRoutine;
        [FieldOffset(368)]
        public _RTL_RUN_ONCE StackTraceInitVar;
        [FieldOffset(376)]
        public _RTLP_HEAP_COMMIT_LIMIT_DATA CommitLimitData;
        [FieldOffset(392)]
        public IntPtr UserContext;
        [FieldOffset(400)]
        public ulong Spare;
        [FieldOffset(408)]
        public IntPtr FrontEndHeap;
        [FieldOffset(416)]
        public ushort FrontHeapLockCount;
        [FieldOffset(418)]
        public byte FrontEndHeapType;
        [FieldOffset(419)]
        public byte RequestedFrontEndHeapType;
        [FieldOffset(424)]
        public IntPtr FrontEndHeapUsageData;
        [FieldOffset(432)]
        public ushort FrontEndHeapMaximumIndex;
        [FieldOffset(434)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 129)]
        public byte[] FrontEndHeapStatusBitmap;
        [FieldOffset(563)]
        public byte ReadOnly;
        [FieldOffset(563)]
        public byte InternalFlags;
        [FieldOffset(568)]
        public _HEAP_COUNTERS Counters;
        [FieldOffset(688)]
        public _HEAP_TUNING_PARAMETERS TuningParameters;
    }
}