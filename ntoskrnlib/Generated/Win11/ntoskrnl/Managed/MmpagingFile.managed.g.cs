using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPAGING_FILE")]
    public sealed class MmpagingFile : DynamicStructure
    {
        [Offset(0UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public uint MaximumSize { get => ReadHere<uint>(nameof(MaximumSize)); set => WriteHere(nameof(MaximumSize), value); }

        [Offset(8UL)]
        public uint MinimumSize { get => ReadHere<uint>(nameof(MinimumSize)); set => WriteHere(nameof(MinimumSize), value); }

        [Offset(12UL)]
        public uint FreeSpace { get => ReadHere<uint>(nameof(FreeSpace)); set => WriteHere(nameof(FreeSpace), value); }

        [Offset(16UL)]
        public uint PeakUsage { get => ReadHere<uint>(nameof(PeakUsage)); set => WriteHere(nameof(PeakUsage), value); }

        [Offset(20UL)]
        public uint FreeReservationSpace { get => ReadHere<uint>(nameof(FreeReservationSpace)); set => WriteHere(nameof(FreeReservationSpace), value); }

        [Offset(24UL)]
        public IntPtr File { get => ReadHere<IntPtr>(nameof(File)); set => WriteHere(nameof(File), value); }

        [Offset(32UL)]
        public IntPtr Entry { get => ReadHere<IntPtr>(nameof(Entry)); set => WriteHere(nameof(Entry), value); }

        [Offset(40UL)]
        public uint NumberOfModWriterEntries { get => ReadHere<uint>(nameof(NumberOfModWriterEntries)); set => WriteHere(nameof(NumberOfModWriterEntries), value); }

        [Offset(48UL)]
        public SlistHeader PfnsToFree { get => ReadStructure<SlistHeader>(nameof(PfnsToFree)); set => WriteStructure(nameof(PfnsToFree), value); }

        [Offset(64UL)]
        public UnicodeString PageFileName { get => ReadStructure<UnicodeString>(nameof(PageFileName)); set => WriteStructure(nameof(PageFileName), value); }

        [Offset(80UL)]
        public IntPtr Bitmaps { get => ReadHere<IntPtr>(nameof(Bitmaps)); set => WriteHere(nameof(Bitmaps), value); }

        [Offset(88UL)]
        public uint AllocationBitmapHint { get => ReadHere<uint>(nameof(AllocationBitmapHint)); set => WriteHere(nameof(AllocationBitmapHint), value); }

        [Offset(92UL)]
        public uint LargestAllocationCluster { get => ReadHere<uint>(nameof(LargestAllocationCluster)); set => WriteHere(nameof(LargestAllocationCluster), value); }

        [Offset(96UL)]
        public uint RefreshAllocationCluster { get => ReadHere<uint>(nameof(RefreshAllocationCluster)); set => WriteHere(nameof(RefreshAllocationCluster), value); }

        [Offset(100UL)]
        public uint LastRefreshAllocationCluster { get => ReadHere<uint>(nameof(LastRefreshAllocationCluster)); set => WriteHere(nameof(LastRefreshAllocationCluster), value); }

        [Offset(104UL)]
        public uint ReservedClusterSizeAggregate { get => ReadHere<uint>(nameof(ReservedClusterSizeAggregate)); set => WriteHere(nameof(ReservedClusterSizeAggregate), value); }

        [Offset(104UL)]
        public uint ToBeEvictedHint { get => ReadHere<uint>(nameof(ToBeEvictedHint)); set => WriteHere(nameof(ToBeEvictedHint), value); }

        [Offset(108UL)]
        public uint MaximumRunLengthInBitmaps { get => ReadHere<uint>(nameof(MaximumRunLengthInBitmaps)); set => WriteHere(nameof(MaximumRunLengthInBitmaps), value); }

        [Offset(112UL)]
        public RtlRbTree BitmapsCacheLengthTree { get => ReadStructure<RtlRbTree>(nameof(BitmapsCacheLengthTree)); set => WriteStructure(nameof(BitmapsCacheLengthTree), value); }

        [Offset(128UL)]
        public RtlRbTree BitmapsCacheLocationTree { get => ReadStructure<RtlRbTree>(nameof(BitmapsCacheLocationTree)); set => WriteStructure(nameof(BitmapsCacheLocationTree), value); }

        [Offset(144UL)]
        public ListEntry BitmapsCacheFreeList { get => ReadStructure<ListEntry>(nameof(BitmapsCacheFreeList)); set => WriteStructure(nameof(BitmapsCacheFreeList), value); }

        [Offset(160UL)]
        public IntPtr BitmapsCacheEntries { get => ReadHere<IntPtr>(nameof(BitmapsCacheEntries)); set => WriteHere(nameof(BitmapsCacheEntries), value); }

        [Offset(168UL)]
        public uint ToBeEvictedCount { get => ReadHere<uint>(nameof(ToBeEvictedCount)); set => WriteHere(nameof(ToBeEvictedCount), value); }

        [Offset(168UL)]
        public uint HybridPriority { get => ReadHere<uint>(nameof(HybridPriority)); set => WriteHere(nameof(HybridPriority), value); }

        [Offset(172UL)]
        public ushort PageFileNumber { get => ReadHere<ushort>(nameof(PageFileNumber)); set => WriteHere(nameof(PageFileNumber), value); }

        [Offset(172UL)]
        public ushort WsSwapPagefile { get => ReadHere<ushort>(nameof(WsSwapPagefile)); set => WriteHere(nameof(WsSwapPagefile), value); }

        [Offset(172UL)]
        public ushort NoReservations { get => ReadHere<ushort>(nameof(NoReservations)); set => WriteHere(nameof(NoReservations), value); }

        [Offset(172UL)]
        public ushort VirtualStorePagefile { get => ReadHere<ushort>(nameof(VirtualStorePagefile)); set => WriteHere(nameof(VirtualStorePagefile), value); }

        [Offset(172UL)]
        public ushort SwapSupported { get => ReadHere<ushort>(nameof(SwapSupported)); set => WriteHere(nameof(SwapSupported), value); }

        [Offset(172UL)]
        public ushort NodeInserted { get => ReadHere<ushort>(nameof(NodeInserted)); set => WriteHere(nameof(NodeInserted), value); }

        [Offset(172UL)]
        public ushort StackNotified { get => ReadHere<ushort>(nameof(StackNotified)); set => WriteHere(nameof(StackNotified), value); }

        [Offset(172UL)]
        public ushort BackedBySCM { get => ReadHere<ushort>(nameof(BackedBySCM)); set => WriteHere(nameof(BackedBySCM), value); }

        [Offset(172UL)]
        public ushort SpecialPurposeMemory { get => ReadHere<ushort>(nameof(SpecialPurposeMemory)); set => WriteHere(nameof(SpecialPurposeMemory), value); }

        [Offset(172UL)]
        public ushort Spare0 { get => ReadHere<ushort>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(174UL)]
        public byte AdriftMdls { get => ReadHere<byte>(nameof(AdriftMdls)); set => WriteHere(nameof(AdriftMdls), value); }

        [Offset(174UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(175UL)]
        public byte IgnoreReservations { get => ReadHere<byte>(nameof(IgnoreReservations)); set => WriteHere(nameof(IgnoreReservations), value); }

        [Offset(175UL)]
        public byte Spare2 { get => ReadHere<byte>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        [Offset(176UL)]
        public uint PageHashPages { get => ReadHere<uint>(nameof(PageHashPages)); set => WriteHere(nameof(PageHashPages), value); }

        [Offset(180UL)]
        public uint PageHashPagesPeak { get => ReadHere<uint>(nameof(PageHashPagesPeak)); set => WriteHere(nameof(PageHashPagesPeak), value); }

        [Offset(184UL)]
        public IntPtr PageHash { get => ReadHere<IntPtr>(nameof(PageHash)); set => WriteHere(nameof(PageHash), value); }

        [Offset(192UL)]
        public IntPtr FileHandle { get => ReadHere<IntPtr>(nameof(FileHandle)); set => WriteHere(nameof(FileHandle), value); }

        [Offset(200UL)]
        public int SpinLock { get => ReadHere<int>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        [Offset(208UL)]
        public RtlAvlTree FlowThroughReadRoot { get => ReadStructure<RtlAvlTree>(nameof(FlowThroughReadRoot)); set => WriteStructure(nameof(FlowThroughReadRoot), value); }

        [Offset(216UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(224UL)]
        public RtlBalancedNode FileObjectNode { get => ReadStructure<RtlBalancedNode>(nameof(FileObjectNode)); set => WriteStructure(nameof(FileObjectNode), value); }

        [Offset(224UL)]
        public RtlRbTree ExtentsTree { get => ReadStructure<RtlRbTree>(nameof(ExtentsTree)); set => WriteStructure(nameof(ExtentsTree), value); }

        public MmpagingFile(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpagingFile>();
        }
    }
}