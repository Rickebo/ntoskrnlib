#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1152)]
    public partial struct _MI_PARTITION_SEGMENTS
    {
        [FieldOffset(0)]
        public int SegmentListLock;
        [FieldOffset(4)]
        public uint DeleteOnCloseCount;
        [FieldOffset(8)]
        public long FsControlAreaCount;
        [FieldOffset(16)]
        public long PfControlAreaCount;
        [FieldOffset(24)]
        public long CloneHeaderCount;
        [FieldOffset(32)]
        public _KEVENT DeleteSubsectionCleanup;
        [FieldOffset(56)]
        public _KEVENT UnusedSegmentCleanup;
        [FieldOffset(80)]
        public ulong SubsectionDeletePtes;
        [FieldOffset(88)]
        public _MMPAGE_FILE_EXPANSION AttemptForCantExtend;
        [FieldOffset(176)]
        public _MMDEREFERENCE_SEGMENT_HEADER DereferenceSegmentHeader;
        [FieldOffset(248)]
        public _LIST_ENTRY DeleteOnCloseList;
        [FieldOffset(264)]
        public _LIST_ENTRY DeleteOnCloseSubsectionList;
        [FieldOffset(280)]
        public _KTIMER DeleteOnCloseTimer;
        [FieldOffset(344)]
        public byte DeleteOnCloseTimerActive;
        [FieldOffset(345)]
        public byte SegmentDereferenceThreadExists;
        [FieldOffset(352)]
        public IntPtr SegmentDereferenceMailboxHeader;
        [FieldOffset(360)]
        public ulong UnusedSegmentPagedPool;
        [FieldOffset(368)]
        public _LIST_ENTRY UnusedSegmentList;
        [FieldOffset(384)]
        public _LIST_ENTRY DeleteSubsectionList;
        [FieldOffset(400)]
        public _KEVENT ControlAreaDeleteEvent;
        [FieldOffset(424)]
        public _SINGLE_LIST_ENTRY ControlAreaDeleteList;
        [FieldOffset(432)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_DEFERRED_PFNS_TO_FREE[] FreedSystemCacheViews;
        [FieldOffset(560)]
        public _MI_DEFERRED_PFNS_TO_FREE FreedSystemCacheViewsReady;
        [FieldOffset(592)]
        public _MI_DEFERRED_PFNS_TO_FREE FreedSystemCachePdesReady;
        [FieldOffset(624)]
        public _KEVENT CloneDereferenceEvent;
        [FieldOffset(656)]
        public _SLIST_HEADER CloneProtosSListHead;
        [FieldOffset(672)]
        public _EX_PUSH_LOCK SystemCacheInitLock;
        [FieldOffset(680)]
        public uint SystemCacheViewPageTables;
        [FieldOffset(688)]
        public _KEVENT FreeSystemCacheVa;
        [FieldOffset(712)]
        public uint PagefileExtensionWaiters;
        [FieldOffset(716)]
        public uint PagefileExtensionRequests;
        [FieldOffset(720)]
        public _KEVENT PagefileExtensionWaitEvent;
        [FieldOffset(744)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public _MI_CROSS_PARTITION_CHARGES[] SharedCharges;
        [FieldOffset(1032)]
        public IntPtr SharedChargesDrainEvent;
        [FieldOffset(1040)]
        public IntPtr ControlAreasDrainEvent;
        [FieldOffset(1048)]
        public IntPtr CloneHeaderDrainEvent;
        [FieldOffset(1056)]
        public IntPtr ProbeRundownReference;
        [FieldOffset(1064)]
        public ulong RemoveUnusedSegmentsCommitNeeded;
        [FieldOffset(1072)]
        public uint SegmentDereferenceCalibrationActive;
        [FieldOffset(1080)]
        public _WORK_QUEUE_ITEM SegmentDereferenceCalibration;
        [FieldOffset(1112)]
        public uint NumberSegmentDereferenceThreads;
        [FieldOffset(1116)]
        public uint OptimalNumberSegmentDereferenceThreadsComputed;
    }
}