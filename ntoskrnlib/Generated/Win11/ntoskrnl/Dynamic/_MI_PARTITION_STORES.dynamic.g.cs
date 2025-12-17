using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_STORES")]
    public sealed class _MI_PARTITION_STORES : DynamicStructure
    {
        public _unnamed_tag_ WriteAllStoreSwapPages { get; }
        public uint VirtualPageFileNumber { get; }
        public uint ReadClusterSizeMax { get; }
        public uint MaximumPagefileSize { get; }
        public uint EvictFlushRequestCount { get; }
        public uint ModifiedWriteDisableCount { get; }
        public uint WriteIssueFailures { get; }
        public uint WritesOutstanding { get; }
        public uint VirtualPagefileMaximumIncreaseFailed { get; }
        public _KTIMER VirtualPagefileIncreaseRetryTimer { get; }
        public IntPtr RundownWrites { get; }
        public int EvictFlushLock { get; }
        public IntPtr EvictionThread { get; }
        public _KEVENT EvictEvent { get; }
        public _KEVENT EvictThreadExitEvent { get; }
        public _SLIST_HEADER WriteSupportSListHead { get; }
        public _KEVENT EvictFlushCompleteEvent { get; }
        public IntPtr WriteIssueFailedBitmap { get; }
        public IntPtr WritePageInformation { get; }
        public _KAFFINITY_EX AffinityEx { get; }
        public IntPtr StoreProcess { get; }
        public int MemoryConditionsLock { get; }
        public uint DeleteStoredPages { get; }
        public uint DiscardPoisonedPages { get; }
        public uint Spare { get; }
        public uint DiscardedPoisonedPages { get; }
        public ulong LastDiscardedPage { get; }

        public _MI_PARTITION_STORES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_STORES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_STORES.WriteAllStoreSwapPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.VirtualPageFileNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.ReadClusterSizeMax),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.MaximumPagefileSize),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.EvictFlushRequestCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.ModifiedWriteDisableCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.WriteIssueFailures),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.WritesOutstanding),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.VirtualPagefileMaximumIncreaseFailed),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.VirtualPagefileIncreaseRetryTimer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.RundownWrites),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.EvictFlushLock),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.EvictionThread),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.EvictEvent),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.EvictThreadExitEvent),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.WriteSupportSListHead),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.EvictFlushCompleteEvent),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.WriteIssueFailedBitmap),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.WritePageInformation),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.AffinityEx),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.StoreProcess),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.MemoryConditionsLock),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.DeleteStoredPages),
                    new ulong[]
                    {
                        508UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.DiscardPoisonedPages),
                    new ulong[]
                    {
                        508UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.Spare),
                    new ulong[]
                    {
                        508UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.DiscardedPoisonedPages),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_MI_PARTITION_STORES.LastDiscardedPage),
                    new ulong[]
                    {
                        520UL
                    }
                }
            };
            Register<_MI_PARTITION_STORES>((mem, ptr) => new _MI_PARTITION_STORES(mem, ptr), offsets);
        }
    }
}