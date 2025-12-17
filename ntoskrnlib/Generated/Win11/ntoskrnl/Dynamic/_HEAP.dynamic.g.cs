using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP")]
    public sealed class _HEAP : DynamicStructure
    {
        public _HEAP_SEGMENT Segment { get; }
        public _HEAP_ENTRY Entry { get; }
        public uint SegmentSignature { get; }
        public uint SegmentFlags { get; }
        public _LIST_ENTRY SegmentListEntry { get; }
        public IntPtr Heap { get; }
        public IntPtr BaseAddress { get; }
        public uint NumberOfPages { get; }
        public IntPtr FirstEntry { get; }
        public IntPtr LastValidEntry { get; }
        public uint NumberOfUnCommittedPages { get; }
        public uint NumberOfUnCommittedRanges { get; }
        public ushort SegmentAllocatorBackTraceIndex { get; }
        public ushort Reserved { get; }
        public _LIST_ENTRY UCRSegmentList { get; }
        public uint Flags { get; }
        public uint ForceFlags { get; }
        public uint CompatibilityFlags { get; }
        public uint EncodeFlagMask { get; }
        public _HEAP_ENTRY Encoding { get; }
        public uint Interceptor { get; }
        public uint VirtualMemoryThreshold { get; }
        public uint Signature { get; }
        public ulong SegmentReserve { get; }
        public ulong SegmentCommit { get; }
        public ulong DeCommitFreeBlockThreshold { get; }
        public ulong DeCommitTotalFreeThreshold { get; }
        public ulong TotalFreeSize { get; }
        public ulong MaximumAllocationSize { get; }
        public ushort ProcessHeapsListIndex { get; }
        public ushort HeaderValidateLength { get; }
        public IntPtr HeaderValidateCopy { get; }
        public ushort NextAvailableTagIndex { get; }
        public ushort MaximumTagIndex { get; }
        public IntPtr TagEntries { get; }
        public _LIST_ENTRY UCRList { get; }
        public ulong AlignRound { get; }
        public ulong AlignMask { get; }
        public _LIST_ENTRY VirtualAllocdBlocks { get; }
        public _LIST_ENTRY SegmentList { get; }
        public ushort AllocatorBackTraceIndex { get; }
        public uint NonDedicatedListLength { get; }
        public IntPtr BlocksIndex { get; }
        public IntPtr UCRIndex { get; }
        public IntPtr PseudoTagEntries { get; }
        public _LIST_ENTRY FreeLists { get; }
        public IntPtr LockVariable { get; }
        public IntPtr CommitRoutine { get; }
        public _RTL_RUN_ONCE StackTraceInitVar { get; }
        public _RTLP_HEAP_COMMIT_LIMIT_DATA CommitLimitData { get; }
        public IntPtr UserContext { get; }
        public ulong Spare { get; }
        public IntPtr FrontEndHeap { get; }
        public ushort FrontHeapLockCount { get; }
        public byte FrontEndHeapType { get; }
        public byte RequestedFrontEndHeapType { get; }
        public IntPtr FrontEndHeapUsageData { get; }
        public ushort FrontEndHeapMaximumIndex { get; }
        public byte[] FrontEndHeapStatusBitmap { get; }
        public byte ReadOnly { get; }
        public byte InternalFlags { get; }
        public _HEAP_COUNTERS Counters { get; }
        public _HEAP_TUNING_PARAMETERS TuningParameters { get; }

        public _HEAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP.Segment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP.Entry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP.SegmentSignature),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP.SegmentFlags),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_HEAP.SegmentListEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP.Heap),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HEAP.BaseAddress),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HEAP.NumberOfPages),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEAP.FirstEntry),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HEAP.LastValidEntry),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HEAP.NumberOfUnCommittedPages),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HEAP.NumberOfUnCommittedRanges),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_HEAP.SegmentAllocatorBackTraceIndex),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HEAP.Reserved),
                    new ulong[]
                    {
                        90UL
                    }
                },
                {
                    nameof(_HEAP.UCRSegmentList),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_HEAP.Flags),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_HEAP.ForceFlags),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_HEAP.CompatibilityFlags),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_HEAP.EncodeFlagMask),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_HEAP.Encoding),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_HEAP.Interceptor),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_HEAP.VirtualMemoryThreshold),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_HEAP.Signature),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_HEAP.SegmentReserve),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_HEAP.SegmentCommit),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_HEAP.DeCommitFreeBlockThreshold),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_HEAP.DeCommitTotalFreeThreshold),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_HEAP.TotalFreeSize),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_HEAP.MaximumAllocationSize),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_HEAP.ProcessHeapsListIndex),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HEAP.HeaderValidateLength),
                    new ulong[]
                    {
                        210UL
                    }
                },
                {
                    nameof(_HEAP.HeaderValidateCopy),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_HEAP.NextAvailableTagIndex),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_HEAP.MaximumTagIndex),
                    new ulong[]
                    {
                        226UL
                    }
                },
                {
                    nameof(_HEAP.TagEntries),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_HEAP.UCRList),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_HEAP.AlignRound),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_HEAP.AlignMask),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_HEAP.VirtualAllocdBlocks),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_HEAP.SegmentList),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_HEAP.AllocatorBackTraceIndex),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_HEAP.NonDedicatedListLength),
                    new ulong[]
                    {
                        308UL
                    }
                },
                {
                    nameof(_HEAP.BlocksIndex),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_HEAP.UCRIndex),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_HEAP.PseudoTagEntries),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_HEAP.FreeLists),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_HEAP.LockVariable),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_HEAP.CommitRoutine),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_HEAP.StackTraceInitVar),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_HEAP.CommitLimitData),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_HEAP.UserContext),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_HEAP.Spare),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_HEAP.FrontEndHeap),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_HEAP.FrontHeapLockCount),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_HEAP.FrontEndHeapType),
                    new ulong[]
                    {
                        418UL
                    }
                },
                {
                    nameof(_HEAP.RequestedFrontEndHeapType),
                    new ulong[]
                    {
                        419UL
                    }
                },
                {
                    nameof(_HEAP.FrontEndHeapUsageData),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_HEAP.FrontEndHeapMaximumIndex),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_HEAP.FrontEndHeapStatusBitmap),
                    new ulong[]
                    {
                        434UL
                    }
                },
                {
                    nameof(_HEAP.ReadOnly),
                    new ulong[]
                    {
                        563UL
                    }
                },
                {
                    nameof(_HEAP.InternalFlags),
                    new ulong[]
                    {
                        563UL
                    }
                },
                {
                    nameof(_HEAP.Counters),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_HEAP.TuningParameters),
                    new ulong[]
                    {
                        688UL
                    }
                }
            };
            Register<_HEAP>((mem, ptr) => new _HEAP(mem, ptr), offsets);
        }
    }
}