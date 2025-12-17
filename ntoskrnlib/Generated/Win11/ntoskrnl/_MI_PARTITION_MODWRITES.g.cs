#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 712)]
    public partial struct _MI_PARTITION_MODWRITES
    {
        [FieldOffset(0)]
        public _MMPAGE_FILE_EXPANSION AttemptForCantExtend;
        [FieldOffset(88)]
        public _MMPAGE_FILE_EXPANSION PageFileContract;
        [FieldOffset(176)]
        public _EX_PUSH_LOCK MappedWriterChargesLock;
        [FieldOffset(184)]
        public uint NumberOfMappedMdls;
        [FieldOffset(188)]
        public uint NumberOfForwardProgressMappedMdls;
        [FieldOffset(192)]
        public int NumberOfMappedMdlsInUse;
        [FieldOffset(196)]
        public uint NumberOfMappedMdlsInUsePeak;
        [FieldOffset(200)]
        public _MMMOD_WRITER_LISTHEAD MappedFileHeader;
        [FieldOffset(240)]
        public byte NeedMappedMdl;
        [FieldOffset(241)]
        public byte NeedPageFileMdl;
        [FieldOffset(242)]
        public byte ModwriterActive;
        [FieldOffset(243)]
        public byte TransitionInserted;
        [FieldOffset(244)]
        public int LastModifiedWriteError;
        [FieldOffset(248)]
        public int LastMappedWriteError;
        [FieldOffset(252)]
        public uint MappedFileWriteSucceeded;
        [FieldOffset(256)]
        public uint MappedWriteBurstCount;
        [FieldOffset(260)]
        public uint LowPriorityModWritesOutstanding;
        [FieldOffset(264)]
        public _KEVENT BoostModWriteIoPriorityEvent;
        [FieldOffset(288)]
        public int ModifiedWriterThreadPriority;
        [FieldOffset(296)]
        public ulong ModifiedPagesLowPriorityGoal;
        [FieldOffset(304)]
        public _KEVENT ModifiedPageWriterEvent;
        [FieldOffset(328)]
        public _KEVENT ModifiedWriterExitedEvent;
        [FieldOffset(352)]
        public int WriteAllPagefilePages;
        [FieldOffset(356)]
        public int WriteAllMappedPages;
        [FieldOffset(360)]
        public _KEVENT MappedPageWriterEvent;
        [FieldOffset(384)]
        public _MI_MODWRITE_DATA ModWriteData;
        [FieldOffset(448)]
        public _KEVENT RescanPageFilesEvent;
        [FieldOffset(472)]
        public _MMMOD_WRITER_LISTHEAD PagingFileHeader;
        [FieldOffset(512)]
        public IntPtr ModifiedPageWriterThread;
        [FieldOffset(520)]
        public _EX_RUNDOWN_REF ModifiedPageWriterRundown;
        [FieldOffset(528)]
        public _WORK_QUEUE_ITEM PagefileScanWorkItem;
        [FieldOffset(560)]
        public uint PagefileScanCount;
        [FieldOffset(564)]
        public int ClusterRestrictionLock;
        [FieldOffset(568)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _MI_RESTRICTED_MODWRITES[] ClusterRestrictions;
        [FieldOffset(576)]
        public _KEVENT NotifyStoreMemoryConditions;
        [FieldOffset(600)]
        public byte DelayMappedWrite;
        [FieldOffset(604)]
        public uint PagefileReservationsEnabled;
        [FieldOffset(608)]
        public _EX_PUSH_LOCK PageFileCreationLock;
        [FieldOffset(616)]
        public _WORK_QUEUE_ITEM TrimPagefileWorkItem;
        [FieldOffset(648)]
        public ulong LastTrimPagefileTime;
        [FieldOffset(656)]
        public _WORK_QUEUE_ITEM WsSwapPagefileContractWorkItem;
        [FieldOffset(688)]
        public int WsSwapPageFileContractionInProgress;
        [FieldOffset(696)]
        public _EX_PUSH_LOCK WorkingSetSwapLock;
        [FieldOffset(704)]
        public int WorkingSetInswapLock;
    }
}