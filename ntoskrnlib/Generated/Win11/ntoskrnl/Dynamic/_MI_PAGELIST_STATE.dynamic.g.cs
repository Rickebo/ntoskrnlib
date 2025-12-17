using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGELIST_STATE")]
    public sealed class _MI_PAGELIST_STATE : DynamicStructure
    {
        public int ActiveSpinLock { get; }
        public _RTL_AVL_TREE ActiveThreadTree { get; }
        public int ActiveZeroSpinLock { get; }
        public _RTL_AVL_TREE ActiveZeroThreadTree { get; }
        public _MMPFN LargePfnTemplate { get; }
        public _MMPFN LargePfnBasePageTemplate { get; }
        public uint NumberOfZeroFreePageListHeads { get; }
        public _KEVENT Phase1BootComplete { get; }
        public _RTL_AVL_TREE PendingBadPageTree { get; }
        public ulong PendingBadPageCount { get; }
        public int PendingBadPageTreeLock { get; }
        public ulong PendingBadPagesWithoutNodesCount { get; }
        public _LIST_ENTRY PendingBadPageNodesAwaitingDeleteList { get; }
        public ulong PendingBadPageNodesAwaitingDeleteCount { get; }
        public byte PendingBadPageNodeDeleteActive { get; }
        public _WORK_QUEUE_ITEM PendingBadPageNodeDeleteWorkItem { get; }
        public _RTL_AVL_TREE BadHugePageTree { get; }
        public ulong BadHugePageCount { get; }

        public _MI_PAGELIST_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGELIST_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGELIST_STATE.ActiveSpinLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.ActiveThreadTree),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.ActiveZeroSpinLock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.ActiveZeroThreadTree),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.LargePfnTemplate),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.LargePfnBasePageTemplate),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.NumberOfZeroFreePageListHeads),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.Phase1BootComplete),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.PendingBadPageTree),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.PendingBadPageCount),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.PendingBadPageTreeLock),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.PendingBadPagesWithoutNodesCount),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.PendingBadPageNodesAwaitingDeleteList),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.PendingBadPageNodesAwaitingDeleteCount),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.PendingBadPageNodeDeleteActive),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.PendingBadPageNodeDeleteWorkItem),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.BadHugePageTree),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_MI_PAGELIST_STATE.BadHugePageCount),
                    new ulong[]
                    {
                        264UL
                    }
                }
            };
            Register<_MI_PAGELIST_STATE>((mem, ptr) => new _MI_PAGELIST_STATE(mem, ptr), offsets);
        }
    }
}