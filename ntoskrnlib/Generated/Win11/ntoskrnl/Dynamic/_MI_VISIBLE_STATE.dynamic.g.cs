using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_VISIBLE_STATE")]
    public sealed class _MI_VISIBLE_STATE : DynamicStructure
    {
        public _MM_PAGED_POOL_INFO PagedPoolInfo { get; }
        public ulong MaximumNonPagedPoolInPages { get; }
        public ulong SizeOfPagedPoolInPages { get; }
        public _MI_SYSTEM_PTE_TYPE SystemPteInfo { get; }
        public ulong NonPagedPoolCommit { get; }
        public ulong SmallNonPagedPtesCommit { get; }
        public ulong BootCommit { get; }
        public ulong SystemPageTableCommit { get; }
        public ulong ProcessCommit { get; }
        public int DriverCommit { get; }
        public byte PagingLevels { get; }
        public ulong PfnDatabaseCommit { get; }
        public ulong[] TotalNodePagesInChildPartitions { get; }
        public byte[] TotalSpecialPurposeMemoryInChildPartitions { get; }
        public byte[] SystemWs { get; }
        public _MMSUPPORT_SHARED SystemCacheShared { get; }
        public byte[] AggregateSystemWs { get; }
        public uint MapCacheFailures { get; }
        public ulong PagefileHashPages { get; }
        public _SYSPTES_HEADER PteHeader { get; }
        public ulong[] SystemVaTypeCount { get; }
        public byte[] SystemVaType { get; }
        public byte[] SystemVaRegions { get; }
        public ulong SecurePtRoot { get; }

        public _MI_VISIBLE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_VISIBLE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_VISIBLE_STATE.PagedPoolInfo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.MaximumNonPagedPoolInPages),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SizeOfPagedPoolInPages),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SystemPteInfo),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.NonPagedPoolCommit),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SmallNonPagedPtesCommit),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.BootCommit),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SystemPageTableCommit),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.ProcessCommit),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.DriverCommit),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.PagingLevels),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.PfnDatabaseCommit),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.TotalNodePagesInChildPartitions),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.TotalSpecialPurposeMemoryInChildPartitions),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SystemWs),
                    new ulong[]
                    {
                        1728UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SystemCacheShared),
                    new ulong[]
                    {
                        4608UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.AggregateSystemWs),
                    new ulong[]
                    {
                        4736UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.MapCacheFailures),
                    new ulong[]
                    {
                        4768UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.PagefileHashPages),
                    new ulong[]
                    {
                        4776UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.PteHeader),
                    new ulong[]
                    {
                        4784UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SystemVaTypeCount),
                    new ulong[]
                    {
                        5064UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SystemVaType),
                    new ulong[]
                    {
                        5224UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SystemVaRegions),
                    new ulong[]
                    {
                        5480UL
                    }
                },
                {
                    nameof(_MI_VISIBLE_STATE.SecurePtRoot),
                    new ulong[]
                    {
                        5768UL
                    }
                }
            };
            Register<_MI_VISIBLE_STATE>((mem, ptr) => new _MI_VISIBLE_STATE(mem, ptr), offsets);
        }
    }
}