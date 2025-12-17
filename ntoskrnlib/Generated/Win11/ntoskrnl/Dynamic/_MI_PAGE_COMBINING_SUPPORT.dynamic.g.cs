using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_COMBINING_SUPPORT")]
    public sealed class _MI_PAGE_COMBINING_SUPPORT : DynamicStructure
    {
        public IntPtr Partition { get; }
        public _LIST_ENTRY ArbitraryPfnMapList { get; }
        public _MI_COMBINE_WORKITEM FreeCombinePoolItem { get; }
        public uint CombiningThreadCount { get; }
        public _LIST_ENTRY CombinePageFreeList { get; }
        public int CombineFreeListLock { get; }
        public byte[] CombinePageListHeads { get; }
        public ulong CommonPageCombineDomain { get; }
        public _MI_PAGE_COMBINE_STATISTICS PageCombineStats { get; }

        public _MI_PAGE_COMBINING_SUPPORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGE_COMBINING_SUPPORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.Partition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.ArbitraryPfnMapList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.FreeCombinePoolItem),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.CombiningThreadCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.CombinePageFreeList),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.CombineFreeListLock),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.CombinePageListHeads),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.CommonPageCombineDomain),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINING_SUPPORT.PageCombineStats),
                    new ulong[]
                    {
                        360UL
                    }
                }
            };
            Register<_MI_PAGE_COMBINING_SUPPORT>((mem, ptr) => new _MI_PAGE_COMBINING_SUPPORT(mem, ptr), offsets);
        }
    }
}