using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_SEGMENTS")]
    public sealed class _MI_PARTITION_SEGMENTS : DynamicStructure
    {
        public int SegmentListLock { get; }
        public uint DeleteOnCloseCount { get; }
        public long FsControlAreaCount { get; }
        public long PfControlAreaCount { get; }
        public long CloneHeaderCount { get; }
        public _KEVENT DeleteSubsectionCleanup { get; }
        public _KEVENT UnusedSegmentCleanup { get; }
        public ulong SubsectionDeletePtes { get; }
        public _MMPAGE_FILE_EXPANSION AttemptForCantExtend { get; }
        public _MMDEREFERENCE_SEGMENT_HEADER DereferenceSegmentHeader { get; }
        public _LIST_ENTRY DeleteOnCloseList { get; }
        public _LIST_ENTRY DeleteOnCloseSubsectionList { get; }
        public _KTIMER DeleteOnCloseTimer { get; }
        public byte DeleteOnCloseTimerActive { get; }
        public byte SegmentDereferenceThreadExists { get; }
        public IntPtr SegmentDereferenceMailboxHeader { get; }
        public ulong UnusedSegmentPagedPool { get; }
        public _LIST_ENTRY UnusedSegmentList { get; }
        public _LIST_ENTRY DeleteSubsectionList { get; }
        public _KEVENT ControlAreaDeleteEvent { get; }
        public _SINGLE_LIST_ENTRY ControlAreaDeleteList { get; }
        public byte[] FreedSystemCacheViews { get; }
        public _MI_DEFERRED_PFNS_TO_FREE FreedSystemCacheViewsReady { get; }
        public _MI_DEFERRED_PFNS_TO_FREE FreedSystemCachePdesReady { get; }
        public _KEVENT CloneDereferenceEvent { get; }
        public _SLIST_HEADER CloneProtosSListHead { get; }
        public _EX_PUSH_LOCK SystemCacheInitLock { get; }
        public uint SystemCacheViewPageTables { get; }
        public _KEVENT FreeSystemCacheVa { get; }
        public uint PagefileExtensionWaiters { get; }
        public uint PagefileExtensionRequests { get; }
        public _KEVENT PagefileExtensionWaitEvent { get; }
        public byte[] SharedCharges { get; }
        public IntPtr SharedChargesDrainEvent { get; }
        public IntPtr ControlAreasDrainEvent { get; }
        public IntPtr CloneHeaderDrainEvent { get; }
        public IntPtr ProbeRundownReference { get; }
        public ulong RemoveUnusedSegmentsCommitNeeded { get; }
        public uint SegmentDereferenceCalibrationActive { get; }
        public _WORK_QUEUE_ITEM SegmentDereferenceCalibration { get; }
        public uint NumberSegmentDereferenceThreads { get; }
        public uint OptimalNumberSegmentDereferenceThreadsComputed { get; }

        public _MI_PARTITION_SEGMENTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_SEGMENTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_SEGMENTS.SegmentListLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.DeleteOnCloseCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.FsControlAreaCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.PfControlAreaCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.CloneHeaderCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.DeleteSubsectionCleanup),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.UnusedSegmentCleanup),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SubsectionDeletePtes),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.AttemptForCantExtend),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.DereferenceSegmentHeader),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.DeleteOnCloseList),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.DeleteOnCloseSubsectionList),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.DeleteOnCloseTimer),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.DeleteOnCloseTimerActive),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SegmentDereferenceThreadExists),
                    new ulong[]
                    {
                        345UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SegmentDereferenceMailboxHeader),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.UnusedSegmentPagedPool),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.UnusedSegmentList),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.DeleteSubsectionList),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.ControlAreaDeleteEvent),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.ControlAreaDeleteList),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.FreedSystemCacheViews),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.FreedSystemCacheViewsReady),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.FreedSystemCachePdesReady),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.CloneDereferenceEvent),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.CloneProtosSListHead),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SystemCacheInitLock),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SystemCacheViewPageTables),
                    new ulong[]
                    {
                        680UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.FreeSystemCacheVa),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.PagefileExtensionWaiters),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.PagefileExtensionRequests),
                    new ulong[]
                    {
                        716UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.PagefileExtensionWaitEvent),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SharedCharges),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SharedChargesDrainEvent),
                    new ulong[]
                    {
                        1032UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.ControlAreasDrainEvent),
                    new ulong[]
                    {
                        1040UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.CloneHeaderDrainEvent),
                    new ulong[]
                    {
                        1048UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.ProbeRundownReference),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.RemoveUnusedSegmentsCommitNeeded),
                    new ulong[]
                    {
                        1064UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SegmentDereferenceCalibrationActive),
                    new ulong[]
                    {
                        1072UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.SegmentDereferenceCalibration),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.NumberSegmentDereferenceThreads),
                    new ulong[]
                    {
                        1112UL
                    }
                },
                {
                    nameof(_MI_PARTITION_SEGMENTS.OptimalNumberSegmentDereferenceThreadsComputed),
                    new ulong[]
                    {
                        1116UL
                    }
                }
            };
            Register<_MI_PARTITION_SEGMENTS>((mem, ptr) => new _MI_PARTITION_SEGMENTS(mem, ptr), offsets);
        }
    }
}