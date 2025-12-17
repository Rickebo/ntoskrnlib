using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_HARDWARE_STATE")]
    public sealed class _MI_HARDWARE_STATE : DynamicStructure
    {
        public uint NumaHintIndex { get; }
        public uint NumaLastRangeIndexInclusive { get; }
        public byte MemoryNodeWithNoProcessorsFound { get; }
        public byte AccessBitReplacementHonored { get; }
        public byte ChannelHintIndex { get; }
        public byte ChannelLastRangeIndexInclusive { get; }
        public IntPtr NodeGraph { get; }
        public _MI_SYSTEM_NODE_AFFINITY_INFORMATION AffinityInfo { get; }
        public IntPtr SystemNodeNonPagedPool { get; }
        public byte[] TemporaryNumaRanges { get; }
        public IntPtr NumaMemoryRanges { get; }
        public IntPtr ChannelMemoryRanges { get; }
        public uint SecondLevelCacheSize { get; }
        public uint FirstLevelCacheSize { get; }
        public uint PhysicalAddressBits { get; }
        public uint PfnDatabasePageBits { get; }
        public byte ProcessorCachesFlushedOnPowerLoss { get; }
        public byte PageTableReuseRequiresFlush { get; }
        public ulong TotalPagesAllowed { get; }
        public uint FlushTbForAttributeChange { get; }
        public uint FlushCacheForAttributeChange { get; }
        public uint FlushCacheForPageAttributeChange { get; }
        public uint CacheFlushPromoteThreshold { get; }
        public ulong InvalidPteMask { get; }
        public uint[] PageColors { get; }
        public ulong FlushTbThreshold { get; }
        public byte AttributeChangeRequiresReZero { get; }
        public ulong HighestPossiblePhysicalPage { get; }
        public ulong VsmKernelPageCount { get; }
        public ulong[] HugePageRemoveTracker { get; }
        public ulong HotAddSequenceNumber { get; }
        public ulong HotRemoveSequenceNumber { get; }
        public _LIST_ENTRY HotAddsInFlight { get; }
        public uint HotAddInFlightCount { get; }
        public uint HotAddInFlightNumaCount { get; }
        public int ParkedCoresLock { get; }
        public _KAFFINITY_EX ParkedCores { get; }
        public _WORK_QUEUE_ITEM ParkedCoresWorkItem { get; }
        public _EX_PUSH_LOCK ShadowPageTablesLock { get; }
        public ulong SpecialPurposeMemoryTypeId { get; }
        public uint SpecialPurposeMemoryQueryTypeExtraSpace { get; }
        public byte[] GlobalBitPolarity { get; }

        public _MI_HARDWARE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_HARDWARE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_HARDWARE_STATE.NumaHintIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.NumaLastRangeIndexInclusive),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.MemoryNodeWithNoProcessorsFound),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.AccessBitReplacementHonored),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.ChannelHintIndex),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.ChannelLastRangeIndexInclusive),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.NodeGraph),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.AffinityInfo),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.SystemNodeNonPagedPool),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.TemporaryNumaRanges),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.NumaMemoryRanges),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.ChannelMemoryRanges),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.SecondLevelCacheSize),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.FirstLevelCacheSize),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.PhysicalAddressBits),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.PfnDatabasePageBits),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.ProcessorCachesFlushedOnPowerLoss),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.PageTableReuseRequiresFlush),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.TotalPagesAllowed),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.FlushTbForAttributeChange),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.FlushCacheForAttributeChange),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.FlushCacheForPageAttributeChange),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.CacheFlushPromoteThreshold),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.InvalidPteMask),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.PageColors),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.FlushTbThreshold),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.AttributeChangeRequiresReZero),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.HighestPossiblePhysicalPage),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.VsmKernelPageCount),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.HugePageRemoveTracker),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.HotAddSequenceNumber),
                    new ulong[]
                    {
                        4400UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.HotRemoveSequenceNumber),
                    new ulong[]
                    {
                        4408UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.HotAddsInFlight),
                    new ulong[]
                    {
                        4416UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.HotAddInFlightCount),
                    new ulong[]
                    {
                        4432UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.HotAddInFlightNumaCount),
                    new ulong[]
                    {
                        4436UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.ParkedCoresLock),
                    new ulong[]
                    {
                        4480UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.ParkedCores),
                    new ulong[]
                    {
                        4488UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.ParkedCoresWorkItem),
                    new ulong[]
                    {
                        4752UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.ShadowPageTablesLock),
                    new ulong[]
                    {
                        4784UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.SpecialPurposeMemoryTypeId),
                    new ulong[]
                    {
                        4792UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.SpecialPurposeMemoryQueryTypeExtraSpace),
                    new ulong[]
                    {
                        4800UL
                    }
                },
                {
                    nameof(_MI_HARDWARE_STATE.GlobalBitPolarity),
                    new ulong[]
                    {
                        4804UL
                    }
                }
            };
            Register<_MI_HARDWARE_STATE>((mem, ptr) => new _MI_HARDWARE_STATE(mem, ptr), offsets);
        }
    }
}