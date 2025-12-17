using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_PTE_STATE")]
    public sealed class _MI_SYSTEM_PTE_STATE : DynamicStructure
    {
        public _NPAGED_LOOKASIDE_LIST MdlTrackerLookaside { get; }
        public _SLIST_HEADER DeadPteTrackerSListHead { get; }
        public int PteTrackerLock { get; }
        public IntPtr CachedPteHeads { get; }
        public _MI_SYSTEM_PTE_TYPE SystemViewPteInfo { get; }
        public _MI_SYSTEM_PTE_TYPE NonCachedMappingsPteInfo { get; }
        public byte[] KernelStackPteInfo { get; }
        public uint StackGrowthFailures { get; }
        public byte KernelStackPages { get; }
        public byte TrackPtesAborted { get; }
        public byte AdjustCounter { get; }
        public int ReservedMappingLock { get; }
        public _RTL_AVL_TREE ReservedMappingTree { get; }
        public _MI_PAGE_CHAIN_HEAD ReservedMappingPageTablePfns { get; }
        public _RTL_AVL_TREE OutswappedKernelStackRoot { get; }
        public int OutswappedKernelStackLock { get; }
        public _MI_ULTRA_VA_CONTEXT UltraSpaceContext { get; }
        public uint NumberOfUltraMdlMaps { get; }
        public IntPtr UltraMdlNodeMappings { get; }
        public IntPtr UltraSpaceLowPpe { get; }
        public IntPtr UltraSpaceHighPpe { get; }
        public _EX_PUSH_LOCK SystemSpaceViewLock { get; }
        public _RTL_AVL_TREE ViewRoot { get; }
        public uint ViewCount { get; }
        public byte[] WorkingSetLockArray { get; }
        public byte[] SystemDataViewsWorkingSetLockArray { get; }
        public byte[] SystemViewBuckets { get; }

        public _MI_SYSTEM_PTE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SYSTEM_PTE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SYSTEM_PTE_STATE.MdlTrackerLookaside),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.DeadPteTrackerSListHead),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.PteTrackerLock),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.CachedPteHeads),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.SystemViewPteInfo),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.NonCachedMappingsPteInfo),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.KernelStackPteInfo),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.StackGrowthFailures),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.KernelStackPages),
                    new ulong[]
                    {
                        548UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.TrackPtesAborted),
                    new ulong[]
                    {
                        549UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.AdjustCounter),
                    new ulong[]
                    {
                        550UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.ReservedMappingLock),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.ReservedMappingTree),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.ReservedMappingPageTablePfns),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.OutswappedKernelStackRoot),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.OutswappedKernelStackLock),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.UltraSpaceContext),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.NumberOfUltraMdlMaps),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.UltraMdlNodeMappings),
                    new ulong[]
                    {
                        680UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.UltraSpaceLowPpe),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.UltraSpaceHighPpe),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.SystemSpaceViewLock),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.ViewRoot),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.ViewCount),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.WorkingSetLockArray),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.SystemDataViewsWorkingSetLockArray),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(_MI_SYSTEM_PTE_STATE.SystemViewBuckets),
                    new ulong[]
                    {
                        1280UL
                    }
                }
            };
            Register<_MI_SYSTEM_PTE_STATE>((mem, ptr) => new _MI_SYSTEM_PTE_STATE(mem, ptr), offsets);
        }
    }
}