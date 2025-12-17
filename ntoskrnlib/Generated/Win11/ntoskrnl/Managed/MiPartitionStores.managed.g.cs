using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_STORES")]
    public sealed class MiPartitionStores : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag WriteAllStoreSwapPages { get => ReadStructure<UnnamedTag>(nameof(WriteAllStoreSwapPages)); set => WriteStructure(nameof(WriteAllStoreSwapPages), value); }

        [Offset(4UL)]
        public uint VirtualPageFileNumber { get => ReadHere<uint>(nameof(VirtualPageFileNumber)); set => WriteHere(nameof(VirtualPageFileNumber), value); }

        [Offset(8UL)]
        public uint ReadClusterSizeMax { get => ReadHere<uint>(nameof(ReadClusterSizeMax)); set => WriteHere(nameof(ReadClusterSizeMax), value); }

        [Offset(12UL)]
        public uint MaximumPagefileSize { get => ReadHere<uint>(nameof(MaximumPagefileSize)); set => WriteHere(nameof(MaximumPagefileSize), value); }

        [Offset(16UL)]
        public uint EvictFlushRequestCount { get => ReadHere<uint>(nameof(EvictFlushRequestCount)); set => WriteHere(nameof(EvictFlushRequestCount), value); }

        [Offset(20UL)]
        public uint ModifiedWriteDisableCount { get => ReadHere<uint>(nameof(ModifiedWriteDisableCount)); set => WriteHere(nameof(ModifiedWriteDisableCount), value); }

        [Offset(24UL)]
        public uint WriteIssueFailures { get => ReadHere<uint>(nameof(WriteIssueFailures)); set => WriteHere(nameof(WriteIssueFailures), value); }

        [Offset(28UL)]
        public uint WritesOutstanding { get => ReadHere<uint>(nameof(WritesOutstanding)); set => WriteHere(nameof(WritesOutstanding), value); }

        [Offset(32UL)]
        public uint VirtualPagefileMaximumIncreaseFailed { get => ReadHere<uint>(nameof(VirtualPagefileMaximumIncreaseFailed)); set => WriteHere(nameof(VirtualPagefileMaximumIncreaseFailed), value); }

        [Offset(40UL)]
        public Ktimer VirtualPagefileIncreaseRetryTimer { get => ReadStructure<Ktimer>(nameof(VirtualPagefileIncreaseRetryTimer)); set => WriteStructure(nameof(VirtualPagefileIncreaseRetryTimer), value); }

        [Offset(104UL)]
        public IntPtr RundownWrites { get => ReadHere<IntPtr>(nameof(RundownWrites)); set => WriteHere(nameof(RundownWrites), value); }

        [Offset(112UL)]
        public int EvictFlushLock { get => ReadHere<int>(nameof(EvictFlushLock)); set => WriteHere(nameof(EvictFlushLock), value); }

        [Offset(120UL)]
        public IntPtr EvictionThread { get => ReadHere<IntPtr>(nameof(EvictionThread)); set => WriteHere(nameof(EvictionThread), value); }

        [Offset(128UL)]
        public Kevent EvictEvent { get => ReadStructure<Kevent>(nameof(EvictEvent)); set => WriteStructure(nameof(EvictEvent), value); }

        [Offset(152UL)]
        public Kevent EvictThreadExitEvent { get => ReadStructure<Kevent>(nameof(EvictThreadExitEvent)); set => WriteStructure(nameof(EvictThreadExitEvent), value); }

        [Offset(176UL)]
        public SlistHeader WriteSupportSListHead { get => ReadStructure<SlistHeader>(nameof(WriteSupportSListHead)); set => WriteStructure(nameof(WriteSupportSListHead), value); }

        [Offset(192UL)]
        public Kevent EvictFlushCompleteEvent { get => ReadStructure<Kevent>(nameof(EvictFlushCompleteEvent)); set => WriteStructure(nameof(EvictFlushCompleteEvent), value); }

        [Offset(216UL)]
        public IntPtr WriteIssueFailedBitmap { get => ReadHere<IntPtr>(nameof(WriteIssueFailedBitmap)); set => WriteHere(nameof(WriteIssueFailedBitmap), value); }

        [Offset(224UL)]
        public IntPtr WritePageInformation { get => ReadHere<IntPtr>(nameof(WritePageInformation)); set => WriteHere(nameof(WritePageInformation), value); }

        [Offset(232UL)]
        public KaffinityEx AffinityEx { get => ReadStructure<KaffinityEx>(nameof(AffinityEx)); set => WriteStructure(nameof(AffinityEx), value); }

        [Offset(496UL)]
        public IntPtr StoreProcess { get => ReadHere<IntPtr>(nameof(StoreProcess)); set => WriteHere(nameof(StoreProcess), value); }

        [Offset(504UL)]
        public int MemoryConditionsLock { get => ReadHere<int>(nameof(MemoryConditionsLock)); set => WriteHere(nameof(MemoryConditionsLock), value); }

        [Offset(508UL)]
        public uint DeleteStoredPages { get => ReadHere<uint>(nameof(DeleteStoredPages)); set => WriteHere(nameof(DeleteStoredPages), value); }

        [Offset(508UL)]
        public uint DiscardPoisonedPages { get => ReadHere<uint>(nameof(DiscardPoisonedPages)); set => WriteHere(nameof(DiscardPoisonedPages), value); }

        [Offset(508UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(512UL)]
        public uint DiscardedPoisonedPages { get => ReadHere<uint>(nameof(DiscardedPoisonedPages)); set => WriteHere(nameof(DiscardedPoisonedPages), value); }

        [Offset(520UL)]
        public ulong LastDiscardedPage { get => ReadHere<ulong>(nameof(LastDiscardedPage)); set => WriteHere(nameof(LastDiscardedPage), value); }

        public MiPartitionStores(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPartitionStores>();
        }
    }
}