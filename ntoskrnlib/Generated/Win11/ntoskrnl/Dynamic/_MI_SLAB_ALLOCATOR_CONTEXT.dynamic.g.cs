using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_SLAB_ALLOCATOR_CONTEXT")]
    public sealed class _MI_SLAB_ALLOCATOR_CONTEXT : DynamicStructure
    {
        public _RTL_RB_TREE SlabTree { get; }
        public int Lock { get; }
        public IntPtr Partition { get; }
        public _unnamed_tag_ Hints { get; }
        public IntPtr StandbyPageCache { get; }
        public IntPtr StandbyPageList { get; }
        public IntPtr RepurposedStandbyPageList { get; }
        public IntPtr SlabListsByIdentity { get; }
        public ulong FreePageCount { get; }
        public ulong AvailablePagesGoal { get; }
        public ulong ChargedPageCount { get; }
        public ulong SlabEntryCount { get; }
        public uint Type { get; }
        public _MI_NODE_NUMBER_ZERO_BASED NumaNodeIndex { get; }
        public _unnamed_tag_ Flags { get; }
        public int ReEvaluateAllocationHint { get; }
        public uint SlabEntriesAllocated { get; }
        public uint SlabEntriesDemoted { get; }
        public uint SlabEntriesFailedFast { get; }
        public uint SlabEntriesFailedSlow { get; }
        public uint SlabPagesFreedNonZeroed { get; }
        public uint SlabPagesCrossIdentity { get; }
        public ulong LastReplenishTime { get; }
        public ulong LastFailureTime { get; }
        public _WORK_QUEUE_ITEM ReplenishWorkItem { get; }
        public _LIST_ENTRY ReplenishWaitList { get; }

        public _MI_SLAB_ALLOCATOR_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_SLAB_ALLOCATOR_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabTree),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.Partition),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.Hints),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.StandbyPageCache),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.StandbyPageList),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.RepurposedStandbyPageList),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabListsByIdentity),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.FreePageCount),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.AvailablePagesGoal),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.ChargedPageCount),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabEntryCount),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.Type),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.NumaNodeIndex),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.Flags),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.ReEvaluateAllocationHint),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabEntriesAllocated),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabEntriesDemoted),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabEntriesFailedFast),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabEntriesFailedSlow),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabPagesFreedNonZeroed),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.SlabPagesCrossIdentity),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.LastReplenishTime),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.LastFailureTime),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.ReplenishWorkItem),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MI_SLAB_ALLOCATOR_CONTEXT.ReplenishWaitList),
                    new ulong[]
                    {
                        216UL
                    }
                }
            };
            Register<_MI_SLAB_ALLOCATOR_CONTEXT>((mem, ptr) => new _MI_SLAB_ALLOCATOR_CONTEXT(mem, ptr), offsets);
        }
    }
}