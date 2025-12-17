using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_COMBINE_STATISTICS")]
    public sealed class _MI_PAGE_COMBINE_STATISTICS : DynamicStructure
    {
        public ulong PagesScannedActive { get; }
        public ulong PagesScannedStandby { get; }
        public ulong PagesCombined { get; }
        public uint CombineScanCount { get; }
        public int CombinedBlocksInUse { get; }
        public int SumCombinedBlocksReferenceCount { get; }
        public uint NonSlabPagesUsedForInPage { get; }

        public _MI_PAGE_COMBINE_STATISTICS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGE_COMBINE_STATISTICS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGE_COMBINE_STATISTICS.PagesScannedActive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINE_STATISTICS.PagesScannedStandby),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINE_STATISTICS.PagesCombined),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINE_STATISTICS.CombineScanCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINE_STATISTICS.CombinedBlocksInUse),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINE_STATISTICS.SumCombinedBlocksReferenceCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PAGE_COMBINE_STATISTICS.NonSlabPagesUsedForInPage),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_MI_PAGE_COMBINE_STATISTICS>((mem, ptr) => new _MI_PAGE_COMBINE_STATISTICS(mem, ptr), offsets);
        }
    }
}