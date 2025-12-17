using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_HARDWARE_STATE")]
    public sealed class MiHardwareState : DynamicStructure
    {
        [Offset(0UL)]
        public uint NumaHintIndex { get => ReadHere<uint>(nameof(NumaHintIndex)); set => WriteHere(nameof(NumaHintIndex), value); }

        [Offset(4UL)]
        public uint NumaLastRangeIndexInclusive { get => ReadHere<uint>(nameof(NumaLastRangeIndexInclusive)); set => WriteHere(nameof(NumaLastRangeIndexInclusive), value); }

        [Offset(8UL)]
        public byte MemoryNodeWithNoProcessorsFound { get => ReadHere<byte>(nameof(MemoryNodeWithNoProcessorsFound)); set => WriteHere(nameof(MemoryNodeWithNoProcessorsFound), value); }

        [Offset(9UL)]
        public byte AccessBitReplacementHonored { get => ReadHere<byte>(nameof(AccessBitReplacementHonored)); set => WriteHere(nameof(AccessBitReplacementHonored), value); }

        [Offset(10UL)]
        public byte ChannelHintIndex { get => ReadHere<byte>(nameof(ChannelHintIndex)); set => WriteHere(nameof(ChannelHintIndex), value); }

        [Offset(11UL)]
        public byte ChannelLastRangeIndexInclusive { get => ReadHere<byte>(nameof(ChannelLastRangeIndexInclusive)); set => WriteHere(nameof(ChannelLastRangeIndexInclusive), value); }

        [Offset(16UL)]
        public IntPtr NodeGraph { get => ReadHere<IntPtr>(nameof(NodeGraph)); set => WriteHere(nameof(NodeGraph), value); }

        [Offset(24UL)]
        public MiSystemNodeAffinityInformation AffinityInfo { get => ReadStructure<MiSystemNodeAffinityInformation>(nameof(AffinityInfo)); set => WriteStructure(nameof(AffinityInfo), value); }

        [Offset(56UL)]
        public IntPtr SystemNodeNonPagedPool { get => ReadHere<IntPtr>(nameof(SystemNodeNonPagedPool)); set => WriteHere(nameof(SystemNodeNonPagedPool), value); }

        [Offset(64UL)]
        [Length(2)]
        public DynamicArray TemporaryNumaRanges { get => ReadStructure<DynamicArray>(nameof(TemporaryNumaRanges)); set => WriteStructure(nameof(TemporaryNumaRanges), value); }

        [Offset(96UL)]
        public IntPtr NumaMemoryRanges { get => ReadHere<IntPtr>(nameof(NumaMemoryRanges)); set => WriteHere(nameof(NumaMemoryRanges), value); }

        [Offset(104UL)]
        public IntPtr ChannelMemoryRanges { get => ReadHere<IntPtr>(nameof(ChannelMemoryRanges)); set => WriteHere(nameof(ChannelMemoryRanges), value); }

        [Offset(112UL)]
        public uint SecondLevelCacheSize { get => ReadHere<uint>(nameof(SecondLevelCacheSize)); set => WriteHere(nameof(SecondLevelCacheSize), value); }

        [Offset(116UL)]
        public uint FirstLevelCacheSize { get => ReadHere<uint>(nameof(FirstLevelCacheSize)); set => WriteHere(nameof(FirstLevelCacheSize), value); }

        [Offset(120UL)]
        public uint PhysicalAddressBits { get => ReadHere<uint>(nameof(PhysicalAddressBits)); set => WriteHere(nameof(PhysicalAddressBits), value); }

        [Offset(124UL)]
        public uint PfnDatabasePageBits { get => ReadHere<uint>(nameof(PfnDatabasePageBits)); set => WriteHere(nameof(PfnDatabasePageBits), value); }

        [Offset(128UL)]
        public byte ProcessorCachesFlushedOnPowerLoss { get => ReadHere<byte>(nameof(ProcessorCachesFlushedOnPowerLoss)); set => WriteHere(nameof(ProcessorCachesFlushedOnPowerLoss), value); }

        [Offset(129UL)]
        public byte PageTableReuseRequiresFlush { get => ReadHere<byte>(nameof(PageTableReuseRequiresFlush)); set => WriteHere(nameof(PageTableReuseRequiresFlush), value); }

        [Offset(136UL)]
        public ulong TotalPagesAllowed { get => ReadHere<ulong>(nameof(TotalPagesAllowed)); set => WriteHere(nameof(TotalPagesAllowed), value); }

        [Offset(144UL)]
        public uint FlushTbForAttributeChange { get => ReadHere<uint>(nameof(FlushTbForAttributeChange)); set => WriteHere(nameof(FlushTbForAttributeChange), value); }

        [Offset(148UL)]
        public uint FlushCacheForAttributeChange { get => ReadHere<uint>(nameof(FlushCacheForAttributeChange)); set => WriteHere(nameof(FlushCacheForAttributeChange), value); }

        [Offset(152UL)]
        public uint FlushCacheForPageAttributeChange { get => ReadHere<uint>(nameof(FlushCacheForPageAttributeChange)); set => WriteHere(nameof(FlushCacheForPageAttributeChange), value); }

        [Offset(156UL)]
        public uint CacheFlushPromoteThreshold { get => ReadHere<uint>(nameof(CacheFlushPromoteThreshold)); set => WriteHere(nameof(CacheFlushPromoteThreshold), value); }

        [Offset(192UL)]
        public ulong InvalidPteMask { get => ReadHere<ulong>(nameof(InvalidPteMask)); set => WriteHere(nameof(InvalidPteMask), value); }

        [Offset(256UL)]
        [Length(4)]
        public DynamicArray PageColors { get => ReadStructure<DynamicArray>(nameof(PageColors)); set => WriteStructure(nameof(PageColors), value); }

        [Offset(272UL)]
        public ulong FlushTbThreshold { get => ReadHere<ulong>(nameof(FlushTbThreshold)); set => WriteHere(nameof(FlushTbThreshold), value); }

        [Offset(280UL)]
        public byte AttributeChangeRequiresReZero { get => ReadHere<byte>(nameof(AttributeChangeRequiresReZero)); set => WriteHere(nameof(AttributeChangeRequiresReZero), value); }

        [Offset(288UL)]
        public ulong HighestPossiblePhysicalPage { get => ReadHere<ulong>(nameof(HighestPossiblePhysicalPage)); set => WriteHere(nameof(HighestPossiblePhysicalPage), value); }

        [Offset(296UL)]
        public ulong VsmKernelPageCount { get => ReadHere<ulong>(nameof(VsmKernelPageCount)); set => WriteHere(nameof(VsmKernelPageCount), value); }

        [Offset(304UL)]
        [Length(512)]
        public DynamicArray HugePageRemoveTracker { get => ReadStructure<DynamicArray>(nameof(HugePageRemoveTracker)); set => WriteStructure(nameof(HugePageRemoveTracker), value); }

        [Offset(4400UL)]
        public ulong HotAddSequenceNumber { get => ReadHere<ulong>(nameof(HotAddSequenceNumber)); set => WriteHere(nameof(HotAddSequenceNumber), value); }

        [Offset(4408UL)]
        public ulong HotRemoveSequenceNumber { get => ReadHere<ulong>(nameof(HotRemoveSequenceNumber)); set => WriteHere(nameof(HotRemoveSequenceNumber), value); }

        [Offset(4416UL)]
        public ListEntry HotAddsInFlight { get => ReadStructure<ListEntry>(nameof(HotAddsInFlight)); set => WriteStructure(nameof(HotAddsInFlight), value); }

        [Offset(4432UL)]
        public uint HotAddInFlightCount { get => ReadHere<uint>(nameof(HotAddInFlightCount)); set => WriteHere(nameof(HotAddInFlightCount), value); }

        [Offset(4436UL)]
        public uint HotAddInFlightNumaCount { get => ReadHere<uint>(nameof(HotAddInFlightNumaCount)); set => WriteHere(nameof(HotAddInFlightNumaCount), value); }

        [Offset(4480UL)]
        public int ParkedCoresLock { get => ReadHere<int>(nameof(ParkedCoresLock)); set => WriteHere(nameof(ParkedCoresLock), value); }

        [Offset(4488UL)]
        public KaffinityEx ParkedCores { get => ReadStructure<KaffinityEx>(nameof(ParkedCores)); set => WriteStructure(nameof(ParkedCores), value); }

        [Offset(4752UL)]
        public WorkQueueItem ParkedCoresWorkItem { get => ReadStructure<WorkQueueItem>(nameof(ParkedCoresWorkItem)); set => WriteStructure(nameof(ParkedCoresWorkItem), value); }

        [Offset(4784UL)]
        public ExPushLock ShadowPageTablesLock { get => ReadStructure<ExPushLock>(nameof(ShadowPageTablesLock)); set => WriteStructure(nameof(ShadowPageTablesLock), value); }

        [Offset(4792UL)]
        public ulong SpecialPurposeMemoryTypeId { get => ReadHere<ulong>(nameof(SpecialPurposeMemoryTypeId)); set => WriteHere(nameof(SpecialPurposeMemoryTypeId), value); }

        [Offset(4800UL)]
        public uint SpecialPurposeMemoryQueryTypeExtraSpace { get => ReadHere<uint>(nameof(SpecialPurposeMemoryQueryTypeExtraSpace)); set => WriteHere(nameof(SpecialPurposeMemoryQueryTypeExtraSpace), value); }

        [Offset(4804UL)]
        [Length(2)]
        public DynamicArray GlobalBitPolarity { get => ReadStructure<DynamicArray>(nameof(GlobalBitPolarity)); set => WriteStructure(nameof(GlobalBitPolarity), value); }

        public MiHardwareState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiHardwareState>();
        }
    }
}