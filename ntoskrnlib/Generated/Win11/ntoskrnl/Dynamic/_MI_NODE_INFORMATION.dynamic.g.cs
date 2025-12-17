using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_NODE_INFORMATION")]
    public sealed class _MI_NODE_INFORMATION : DynamicStructure
    {
        public byte[] FreePageInfo { get; }
        public byte[] HotZeroedPageCountsByColor { get; }
        public _MI_REBUILD_LARGE_PAGE_TIMER LargePageRebuildTimer { get; }
        public byte[] StandbyPageList { get; }
        public byte[] StandbyPageCachePerChannel { get; }
        public byte[] FreePageSListsBitmap { get; }
        public ulong[] FreePageSListsBitmapBuffer { get; }
        public byte[] FreeZeroPageSlists { get; }
        public ulong[] TotalPages { get; }
        public ulong TotalPagesEntireNode { get; }
        public IntPtr Partition { get; }
        public ulong TotalHugeIoPages { get; }
        public byte[] HugeIoRangeFreeCount { get; }
        public byte[] FreeHugeRangeListHeadsBitmap { get; }
        public ulong[] FreeHugeRangeListHeadsBitmapBuffer { get; }
        public _MI_HUGE_PFN_COLORHEAD BadHugeRangeListHead { get; }
        public uint Color { get; }
        public byte[] ChannelFreeCount { get; }
        public _unnamed_tag_ Flags { get; }
        public byte[] PageListMoveInProgress { get; }
        public uint CurrentHugeRangeColor { get; }
        public int NodeLock { get; }
        public int ZeroThreadHugeMapLock { get; }
        public int LargePageRebuildLock { get; }
        public byte ChannelStatus { get; }
        public byte[] ChannelOrdering { get; }
        public byte[] LockedChannelOrdering { get; }
        public byte[] PowerAttribute { get; }
        public uint RollingKernelStackAllocationIndex { get; }
        public ulong ScrubResumePage { get; }
        public ulong NumberOfPagesGoingBad { get; }
        public IntPtr BootZeroContext { get; }
        public IntPtr ZeroingContext { get; }
        public int ZeroContextLock { get; }
        public IntPtr ZeroThreadConductor { get; }
        public byte BackgroundZeroingActive { get; }
        public IntPtr ZeroingPhysicalMemoryBlock { get; }
        public byte[] CachedKernelStacks { get; }
        public byte[] SlabContexts { get; }
        public byte[] SlabStandbyListCaches { get; }
        public byte[] SlabStandbyPageLists { get; }
        public byte[] SlabRepurposedStandbyPageLists { get; }
        public _RTL_BITMAP SlabTypeStandbyExistsBitmap { get; }
        public uint[] SlabTypeStandbyExistsBitmapBuffer { get; }
        public IntPtr SlabIdentityState { get; }
        public ulong MdlSlabFragmentionLastDemoteTime { get; }
        public _MMPFNLIST EnclavePageListHead { get; }
        public _MI_LARGE_PAGE_NODE_COALESCE_STATE LargePageCoalesceState { get; }

        public _MI_NODE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_NODE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_NODE_INFORMATION.FreePageInfo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.HotZeroedPageCountsByColor),
                    new ulong[]
                    {
                        5120UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.LargePageRebuildTimer),
                    new ulong[]
                    {
                        5152UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.StandbyPageList),
                    new ulong[]
                    {
                        5192UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.StandbyPageCachePerChannel),
                    new ulong[]
                    {
                        6656UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.FreePageSListsBitmap),
                    new ulong[]
                    {
                        14848UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.FreePageSListsBitmapBuffer),
                    new ulong[]
                    {
                        14880UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.FreeZeroPageSlists),
                    new ulong[]
                    {
                        14944UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.TotalPages),
                    new ulong[]
                    {
                        14960UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.TotalPagesEntireNode),
                    new ulong[]
                    {
                        14976UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.Partition),
                    new ulong[]
                    {
                        14984UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.TotalHugeIoPages),
                    new ulong[]
                    {
                        14992UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.HugeIoRangeFreeCount),
                    new ulong[]
                    {
                        15000UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.FreeHugeRangeListHeadsBitmap),
                    new ulong[]
                    {
                        15040UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.FreeHugeRangeListHeadsBitmapBuffer),
                    new ulong[]
                    {
                        15072UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.BadHugeRangeListHead),
                    new ulong[]
                    {
                        15136UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.Color),
                    new ulong[]
                    {
                        15144UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ChannelFreeCount),
                    new ulong[]
                    {
                        15152UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.Flags),
                    new ulong[]
                    {
                        15184UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.PageListMoveInProgress),
                    new ulong[]
                    {
                        15192UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.CurrentHugeRangeColor),
                    new ulong[]
                    {
                        15216UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.NodeLock),
                    new ulong[]
                    {
                        15220UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ZeroThreadHugeMapLock),
                    new ulong[]
                    {
                        15224UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.LargePageRebuildLock),
                    new ulong[]
                    {
                        15228UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ChannelStatus),
                    new ulong[]
                    {
                        15232UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ChannelOrdering),
                    new ulong[]
                    {
                        15233UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.LockedChannelOrdering),
                    new ulong[]
                    {
                        15235UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.PowerAttribute),
                    new ulong[]
                    {
                        15237UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.RollingKernelStackAllocationIndex),
                    new ulong[]
                    {
                        15240UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ScrubResumePage),
                    new ulong[]
                    {
                        15248UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.NumberOfPagesGoingBad),
                    new ulong[]
                    {
                        15256UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.BootZeroContext),
                    new ulong[]
                    {
                        15264UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ZeroingContext),
                    new ulong[]
                    {
                        15272UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ZeroContextLock),
                    new ulong[]
                    {
                        15280UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ZeroThreadConductor),
                    new ulong[]
                    {
                        15288UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.BackgroundZeroingActive),
                    new ulong[]
                    {
                        15296UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.ZeroingPhysicalMemoryBlock),
                    new ulong[]
                    {
                        15304UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.CachedKernelStacks),
                    new ulong[]
                    {
                        15312UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.SlabContexts),
                    new ulong[]
                    {
                        15696UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.SlabStandbyListCaches),
                    new ulong[]
                    {
                        17792UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.SlabStandbyPageLists),
                    new ulong[]
                    {
                        50560UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.SlabRepurposedStandbyPageLists),
                    new ulong[]
                    {
                        56192UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.SlabTypeStandbyExistsBitmap),
                    new ulong[]
                    {
                        56984UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.SlabTypeStandbyExistsBitmapBuffer),
                    new ulong[]
                    {
                        57000UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.SlabIdentityState),
                    new ulong[]
                    {
                        57008UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.MdlSlabFragmentionLastDemoteTime),
                    new ulong[]
                    {
                        57016UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.EnclavePageListHead),
                    new ulong[]
                    {
                        57024UL
                    }
                },
                {
                    nameof(_MI_NODE_INFORMATION.LargePageCoalesceState),
                    new ulong[]
                    {
                        57112UL
                    }
                }
            };
            Register<_MI_NODE_INFORMATION>((mem, ptr) => new _MI_NODE_INFORMATION(mem, ptr), offsets);
        }
    }
}