using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_MODWRITES")]
    public sealed class _MI_PARTITION_MODWRITES : DynamicStructure
    {
        public _MMPAGE_FILE_EXPANSION AttemptForCantExtend { get; }
        public _MMPAGE_FILE_EXPANSION PageFileContract { get; }
        public _EX_PUSH_LOCK MappedWriterChargesLock { get; }
        public uint NumberOfMappedMdls { get; }
        public uint NumberOfForwardProgressMappedMdls { get; }
        public int NumberOfMappedMdlsInUse { get; }
        public uint NumberOfMappedMdlsInUsePeak { get; }
        public _MMMOD_WRITER_LISTHEAD MappedFileHeader { get; }
        public byte NeedMappedMdl { get; }
        public byte NeedPageFileMdl { get; }
        public byte ModwriterActive { get; }
        public byte TransitionInserted { get; }
        public int LastModifiedWriteError { get; }
        public int LastMappedWriteError { get; }
        public uint MappedFileWriteSucceeded { get; }
        public uint MappedWriteBurstCount { get; }
        public uint LowPriorityModWritesOutstanding { get; }
        public _KEVENT BoostModWriteIoPriorityEvent { get; }
        public int ModifiedWriterThreadPriority { get; }
        public ulong ModifiedPagesLowPriorityGoal { get; }
        public _KEVENT ModifiedPageWriterEvent { get; }
        public _KEVENT ModifiedWriterExitedEvent { get; }
        public int WriteAllPagefilePages { get; }
        public int WriteAllMappedPages { get; }
        public _KEVENT MappedPageWriterEvent { get; }
        public _MI_MODWRITE_DATA ModWriteData { get; }
        public _KEVENT RescanPageFilesEvent { get; }
        public _MMMOD_WRITER_LISTHEAD PagingFileHeader { get; }
        public IntPtr ModifiedPageWriterThread { get; }
        public _EX_RUNDOWN_REF ModifiedPageWriterRundown { get; }
        public _WORK_QUEUE_ITEM PagefileScanWorkItem { get; }
        public uint PagefileScanCount { get; }
        public int ClusterRestrictionLock { get; }
        public byte[] ClusterRestrictions { get; }
        public _KEVENT NotifyStoreMemoryConditions { get; }
        public byte DelayMappedWrite { get; }
        public uint PagefileReservationsEnabled { get; }
        public _EX_PUSH_LOCK PageFileCreationLock { get; }
        public _WORK_QUEUE_ITEM TrimPagefileWorkItem { get; }
        public ulong LastTrimPagefileTime { get; }
        public _WORK_QUEUE_ITEM WsSwapPagefileContractWorkItem { get; }
        public int WsSwapPageFileContractionInProgress { get; }
        public _EX_PUSH_LOCK WorkingSetSwapLock { get; }
        public int WorkingSetInswapLock { get; }

        public _MI_PARTITION_MODWRITES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_MODWRITES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_MODWRITES.AttemptForCantExtend),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.PageFileContract),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.MappedWriterChargesLock),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.NumberOfMappedMdls),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.NumberOfForwardProgressMappedMdls),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.NumberOfMappedMdlsInUse),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.NumberOfMappedMdlsInUsePeak),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.MappedFileHeader),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.NeedMappedMdl),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.NeedPageFileMdl),
                    new ulong[]
                    {
                        241UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ModwriterActive),
                    new ulong[]
                    {
                        242UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.TransitionInserted),
                    new ulong[]
                    {
                        243UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.LastModifiedWriteError),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.LastMappedWriteError),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.MappedFileWriteSucceeded),
                    new ulong[]
                    {
                        252UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.MappedWriteBurstCount),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.LowPriorityModWritesOutstanding),
                    new ulong[]
                    {
                        260UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.BoostModWriteIoPriorityEvent),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ModifiedWriterThreadPriority),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ModifiedPagesLowPriorityGoal),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ModifiedPageWriterEvent),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ModifiedWriterExitedEvent),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.WriteAllPagefilePages),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.WriteAllMappedPages),
                    new ulong[]
                    {
                        356UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.MappedPageWriterEvent),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ModWriteData),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.RescanPageFilesEvent),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.PagingFileHeader),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ModifiedPageWriterThread),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ModifiedPageWriterRundown),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.PagefileScanWorkItem),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.PagefileScanCount),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ClusterRestrictionLock),
                    new ulong[]
                    {
                        564UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.ClusterRestrictions),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.NotifyStoreMemoryConditions),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.DelayMappedWrite),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.PagefileReservationsEnabled),
                    new ulong[]
                    {
                        604UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.PageFileCreationLock),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.TrimPagefileWorkItem),
                    new ulong[]
                    {
                        616UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.LastTrimPagefileTime),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.WsSwapPagefileContractWorkItem),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.WsSwapPageFileContractionInProgress),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.WorkingSetSwapLock),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_MI_PARTITION_MODWRITES.WorkingSetInswapLock),
                    new ulong[]
                    {
                        704UL
                    }
                }
            };
            Register<_MI_PARTITION_MODWRITES>((mem, ptr) => new _MI_PARTITION_MODWRITES(mem, ptr), offsets);
        }
    }
}