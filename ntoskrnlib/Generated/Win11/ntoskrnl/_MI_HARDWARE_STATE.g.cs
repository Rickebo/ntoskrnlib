#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4864)]
    public partial struct _MI_HARDWARE_STATE
    {
        [FieldOffset(0)]
        public uint NumaHintIndex;
        [FieldOffset(4)]
        public uint NumaLastRangeIndexInclusive;
        [FieldOffset(8)]
        public byte MemoryNodeWithNoProcessorsFound;
        [FieldOffset(9)]
        public byte AccessBitReplacementHonored;
        [FieldOffset(10)]
        public byte ChannelHintIndex;
        [FieldOffset(11)]
        public byte ChannelLastRangeIndexInclusive;
        [FieldOffset(16)]
        public IntPtr NodeGraph;
        [FieldOffset(24)]
        public _MI_SYSTEM_NODE_AFFINITY_INFORMATION AffinityInfo;
        [FieldOffset(56)]
        public IntPtr SystemNodeNonPagedPool;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _HAL_NODE_RANGE[] TemporaryNumaRanges;
        [FieldOffset(96)]
        public IntPtr NumaMemoryRanges;
        [FieldOffset(104)]
        public IntPtr ChannelMemoryRanges;
        [FieldOffset(112)]
        public uint SecondLevelCacheSize;
        [FieldOffset(116)]
        public uint FirstLevelCacheSize;
        [FieldOffset(120)]
        public uint PhysicalAddressBits;
        [FieldOffset(124)]
        public uint PfnDatabasePageBits;
        [FieldOffset(128)]
        public byte ProcessorCachesFlushedOnPowerLoss;
        [FieldOffset(129)]
        public byte PageTableReuseRequiresFlush;
        [FieldOffset(136)]
        public ulong TotalPagesAllowed;
        [FieldOffset(144)]
        public uint FlushTbForAttributeChange;
        [FieldOffset(148)]
        public uint FlushCacheForAttributeChange;
        [FieldOffset(152)]
        public uint FlushCacheForPageAttributeChange;
        [FieldOffset(156)]
        public uint CacheFlushPromoteThreshold;
        [FieldOffset(192)]
        public ulong InvalidPteMask;
        [FieldOffset(256)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] PageColors;
        [FieldOffset(272)]
        public ulong FlushTbThreshold;
        [FieldOffset(280)]
        public byte AttributeChangeRequiresReZero;
        [FieldOffset(288)]
        public ulong HighestPossiblePhysicalPage;
        [FieldOffset(296)]
        public ulong VsmKernelPageCount;
        [FieldOffset(304)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public ulong[] HugePageRemoveTracker;
        [FieldOffset(4400)]
        public ulong HotAddSequenceNumber;
        [FieldOffset(4408)]
        public ulong HotRemoveSequenceNumber;
        [FieldOffset(4416)]
        public _LIST_ENTRY HotAddsInFlight;
        [FieldOffset(4432)]
        public uint HotAddInFlightCount;
        [FieldOffset(4436)]
        public uint HotAddInFlightNumaCount;
        [FieldOffset(4480)]
        public int ParkedCoresLock;
        [FieldOffset(4488)]
        public _KAFFINITY_EX ParkedCores;
        [FieldOffset(4752)]
        public _WORK_QUEUE_ITEM ParkedCoresWorkItem;
        [FieldOffset(4784)]
        public _EX_PUSH_LOCK ShadowPageTablesLock;
        [FieldOffset(4792)]
        public ulong SpecialPurposeMemoryTypeId;
        [FieldOffset(4800)]
        public uint SpecialPurposeMemoryQueryTypeExtraSpace;
        [FieldOffset(4804)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] GlobalBitPolarity;
    }
}