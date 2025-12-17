using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DIRTY_PAGE_THRESHOLDS")]
    public sealed class _DIRTY_PAGE_THRESHOLDS : DynamicStructure
    {
        public ulong DirtyPageThreshold { get; }
        public ulong DirtyPageThresholdTop { get; }
        public ulong DirtyPageThresholdBottom { get; }
        public uint DirtyPageTarget { get; }
        public ulong AggregateAvailablePages { get; }
        public ulong AggregateDirtyPages { get; }
        public uint AvailableHistory { get; }

        public _DIRTY_PAGE_THRESHOLDS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DIRTY_PAGE_THRESHOLDS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DIRTY_PAGE_THRESHOLDS.DirtyPageThreshold),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DIRTY_PAGE_THRESHOLDS.DirtyPageThresholdTop),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DIRTY_PAGE_THRESHOLDS.DirtyPageThresholdBottom),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DIRTY_PAGE_THRESHOLDS.DirtyPageTarget),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DIRTY_PAGE_THRESHOLDS.AggregateAvailablePages),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DIRTY_PAGE_THRESHOLDS.AggregateDirtyPages),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DIRTY_PAGE_THRESHOLDS.AvailableHistory),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_DIRTY_PAGE_THRESHOLDS>((mem, ptr) => new _DIRTY_PAGE_THRESHOLDS(mem, ptr), offsets);
        }
    }
}