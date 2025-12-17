using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION")]
    public sealed class _MI_PARTITION : DynamicStructure
    {
        public _MI_PARTITION_CORE Core { get; }
        public _MI_PARTITION_MODWRITES Modwriter { get; }
        public _MI_PARTITION_STORES Store { get; }
        public _MI_PARTITION_SEGMENTS Segments { get; }
        public _MI_PARTITION_PAGE_LISTS PageLists { get; }
        public _MI_PARTITION_COMMIT Commit { get; }
        public _MI_PARTITION_ZEROING Zeroing { get; }
        public _MI_PAGE_COMBINING_SUPPORT PageCombine { get; }
        public _MI_ACCESS_LOG_STATE AccessLog { get; }
        public IntPtr WorkingSetControl { get; }
        public _MMWORKING_SET_EXPANSION_HEAD WorkingSetExpansionHead { get; }
        public _MI_SPECIAL_PURPOSE_MEMORY_STATE SpecialPurposeMemory { get; }
        public _MI_PARTITION_SLABS Slabs { get; }
        public ulong LastPeriodicTelemetryLogTime { get; }
        public _MI_VISIBLE_PARTITION Vp { get; }

        public _MI_PARTITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION.Core),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION.Modwriter),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_MI_PARTITION.Store),
                    new ulong[]
                    {
                        1200UL
                    }
                },
                {
                    nameof(_MI_PARTITION.Segments),
                    new ulong[]
                    {
                        1728UL
                    }
                },
                {
                    nameof(_MI_PARTITION.PageLists),
                    new ulong[]
                    {
                        2880UL
                    }
                },
                {
                    nameof(_MI_PARTITION.Commit),
                    new ulong[]
                    {
                        16832UL
                    }
                },
                {
                    nameof(_MI_PARTITION.Zeroing),
                    new ulong[]
                    {
                        16912UL
                    }
                },
                {
                    nameof(_MI_PARTITION.PageCombine),
                    new ulong[]
                    {
                        16984UL
                    }
                },
                {
                    nameof(_MI_PARTITION.AccessLog),
                    new ulong[]
                    {
                        17408UL
                    }
                },
                {
                    nameof(_MI_PARTITION.WorkingSetControl),
                    new ulong[]
                    {
                        17600UL
                    }
                },
                {
                    nameof(_MI_PARTITION.WorkingSetExpansionHead),
                    new ulong[]
                    {
                        17608UL
                    }
                },
                {
                    nameof(_MI_PARTITION.SpecialPurposeMemory),
                    new ulong[]
                    {
                        17624UL
                    }
                },
                {
                    nameof(_MI_PARTITION.Slabs),
                    new ulong[]
                    {
                        17728UL
                    }
                },
                {
                    nameof(_MI_PARTITION.LastPeriodicTelemetryLogTime),
                    new ulong[]
                    {
                        18432UL
                    }
                },
                {
                    nameof(_MI_PARTITION.Vp),
                    new ulong[]
                    {
                        18496UL
                    }
                }
            };
            Register<_MI_PARTITION>((mem, ptr) => new _MI_PARTITION(mem, ptr), offsets);
        }
    }
}