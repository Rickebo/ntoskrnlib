using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_NODE_INFORMATION")]
    public sealed class MiNodeInformation : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray FreePageInfo { get => ReadStructure<DynamicArray>(nameof(FreePageInfo)); set => WriteStructure(nameof(FreePageInfo), value); }

        [Offset(5120UL)]
        [Length(4)]
        public DynamicArray HotZeroedPageCountsByColor { get => ReadStructure<DynamicArray>(nameof(HotZeroedPageCountsByColor)); set => WriteStructure(nameof(HotZeroedPageCountsByColor), value); }

        [Offset(5152UL)]
        public MiRebuildLargePageTimer LargePageRebuildTimer { get => ReadStructure<MiRebuildLargePageTimer>(nameof(LargePageRebuildTimer)); set => WriteStructure(nameof(LargePageRebuildTimer), value); }

        [Offset(5192UL)]
        [Length(2)]
        public DynamicArray StandbyPageList { get => ReadStructure<DynamicArray>(nameof(StandbyPageList)); set => WriteStructure(nameof(StandbyPageList), value); }

        [Offset(6656UL)]
        [Length(2)]
        public DynamicArray StandbyPageCachePerChannel { get => ReadStructure<DynamicArray>(nameof(StandbyPageCachePerChannel)); set => WriteStructure(nameof(StandbyPageCachePerChannel), value); }

        [Offset(14848UL)]
        [Length(2)]
        public DynamicArray FreePageSListsBitmap { get => ReadStructure<DynamicArray>(nameof(FreePageSListsBitmap)); set => WriteStructure(nameof(FreePageSListsBitmap), value); }

        [Offset(14880UL)]
        [Length(8)]
        public DynamicArray FreePageSListsBitmapBuffer { get => ReadStructure<DynamicArray>(nameof(FreePageSListsBitmapBuffer)); set => WriteStructure(nameof(FreePageSListsBitmapBuffer), value); }

        [Offset(14944UL)]
        [Length(2)]
        public DynamicArray FreeZeroPageSlists { get => ReadStructure<DynamicArray>(nameof(FreeZeroPageSlists)); set => WriteStructure(nameof(FreeZeroPageSlists), value); }

        [Offset(14960UL)]
        [Length(2)]
        public DynamicArray TotalPages { get => ReadStructure<DynamicArray>(nameof(TotalPages)); set => WriteStructure(nameof(TotalPages), value); }

        [Offset(14976UL)]
        public ulong TotalPagesEntireNode { get => ReadHere<ulong>(nameof(TotalPagesEntireNode)); set => WriteHere(nameof(TotalPagesEntireNode), value); }

        [Offset(14984UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(14992UL)]
        public ulong TotalHugeIoPages { get => ReadHere<ulong>(nameof(TotalHugeIoPages)); set => WriteHere(nameof(TotalHugeIoPages), value); }

        [Offset(15000UL)]
        [Length(2)]
        public DynamicArray HugeIoRangeFreeCount { get => ReadStructure<DynamicArray>(nameof(HugeIoRangeFreeCount)); set => WriteStructure(nameof(HugeIoRangeFreeCount), value); }

        [Offset(15040UL)]
        [Length(2)]
        public DynamicArray FreeHugeRangeListHeadsBitmap { get => ReadStructure<DynamicArray>(nameof(FreeHugeRangeListHeadsBitmap)); set => WriteStructure(nameof(FreeHugeRangeListHeadsBitmap), value); }

        [Offset(15072UL)]
        [Length(8)]
        public DynamicArray FreeHugeRangeListHeadsBitmapBuffer { get => ReadStructure<DynamicArray>(nameof(FreeHugeRangeListHeadsBitmapBuffer)); set => WriteStructure(nameof(FreeHugeRangeListHeadsBitmapBuffer), value); }

        [Offset(15136UL)]
        public MiHugePfnColorhead BadHugeRangeListHead { get => ReadStructure<MiHugePfnColorhead>(nameof(BadHugeRangeListHead)); set => WriteStructure(nameof(BadHugeRangeListHead), value); }

        [Offset(15144UL)]
        public uint Color { get => ReadHere<uint>(nameof(Color)); set => WriteHere(nameof(Color), value); }

        [Offset(15152UL)]
        [Length(2)]
        public DynamicArray ChannelFreeCount { get => ReadStructure<DynamicArray>(nameof(ChannelFreeCount)); set => WriteStructure(nameof(ChannelFreeCount), value); }

        [Offset(15184UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(15192UL)]
        [Length(3)]
        public DynamicArray PageListMoveInProgress { get => ReadStructure<DynamicArray>(nameof(PageListMoveInProgress)); set => WriteStructure(nameof(PageListMoveInProgress), value); }

        [Offset(15216UL)]
        public uint CurrentHugeRangeColor { get => ReadHere<uint>(nameof(CurrentHugeRangeColor)); set => WriteHere(nameof(CurrentHugeRangeColor), value); }

        [Offset(15220UL)]
        public int NodeLock { get => ReadHere<int>(nameof(NodeLock)); set => WriteHere(nameof(NodeLock), value); }

        [Offset(15224UL)]
        public int ZeroThreadHugeMapLock { get => ReadHere<int>(nameof(ZeroThreadHugeMapLock)); set => WriteHere(nameof(ZeroThreadHugeMapLock), value); }

        [Offset(15228UL)]
        public int LargePageRebuildLock { get => ReadHere<int>(nameof(LargePageRebuildLock)); set => WriteHere(nameof(LargePageRebuildLock), value); }

        [Offset(15232UL)]
        public byte ChannelStatus { get => ReadHere<byte>(nameof(ChannelStatus)); set => WriteHere(nameof(ChannelStatus), value); }

        [Offset(15233UL)]
        [Length(2)]
        public DynamicArray ChannelOrdering { get => ReadStructure<DynamicArray>(nameof(ChannelOrdering)); set => WriteStructure(nameof(ChannelOrdering), value); }

        [Offset(15235UL)]
        [Length(2)]
        public DynamicArray LockedChannelOrdering { get => ReadStructure<DynamicArray>(nameof(LockedChannelOrdering)); set => WriteStructure(nameof(LockedChannelOrdering), value); }

        [Offset(15237UL)]
        [Length(2)]
        public DynamicArray PowerAttribute { get => ReadStructure<DynamicArray>(nameof(PowerAttribute)); set => WriteStructure(nameof(PowerAttribute), value); }

        [Offset(15240UL)]
        public uint RollingKernelStackAllocationIndex { get => ReadHere<uint>(nameof(RollingKernelStackAllocationIndex)); set => WriteHere(nameof(RollingKernelStackAllocationIndex), value); }

        [Offset(15248UL)]
        public ulong ScrubResumePage { get => ReadHere<ulong>(nameof(ScrubResumePage)); set => WriteHere(nameof(ScrubResumePage), value); }

        [Offset(15256UL)]
        public ulong NumberOfPagesGoingBad { get => ReadHere<ulong>(nameof(NumberOfPagesGoingBad)); set => WriteHere(nameof(NumberOfPagesGoingBad), value); }

        [Offset(15264UL)]
        public IntPtr BootZeroContext { get => ReadHere<IntPtr>(nameof(BootZeroContext)); set => WriteHere(nameof(BootZeroContext), value); }

        [Offset(15272UL)]
        public IntPtr ZeroingContext { get => ReadHere<IntPtr>(nameof(ZeroingContext)); set => WriteHere(nameof(ZeroingContext), value); }

        [Offset(15280UL)]
        public int ZeroContextLock { get => ReadHere<int>(nameof(ZeroContextLock)); set => WriteHere(nameof(ZeroContextLock), value); }

        [Offset(15288UL)]
        public IntPtr ZeroThreadConductor { get => ReadHere<IntPtr>(nameof(ZeroThreadConductor)); set => WriteHere(nameof(ZeroThreadConductor), value); }

        [Offset(15296UL)]
        public byte BackgroundZeroingActive { get => ReadHere<byte>(nameof(BackgroundZeroingActive)); set => WriteHere(nameof(BackgroundZeroingActive), value); }

        [Offset(15304UL)]
        public IntPtr ZeroingPhysicalMemoryBlock { get => ReadHere<IntPtr>(nameof(ZeroingPhysicalMemoryBlock)); set => WriteHere(nameof(ZeroingPhysicalMemoryBlock), value); }

        [Offset(15312UL)]
        [Length(8)]
        public DynamicArray CachedKernelStacks { get => ReadStructure<DynamicArray>(nameof(CachedKernelStacks)); set => WriteStructure(nameof(CachedKernelStacks), value); }

        [Offset(15696UL)]
        [Length(9)]
        public DynamicArray SlabContexts { get => ReadStructure<DynamicArray>(nameof(SlabContexts)); set => WriteStructure(nameof(SlabContexts), value); }

        [Offset(17792UL)]
        [Length(8)]
        public DynamicArray SlabStandbyListCaches { get => ReadStructure<DynamicArray>(nameof(SlabStandbyListCaches)); set => WriteStructure(nameof(SlabStandbyListCaches), value); }

        [Offset(50560UL)]
        [Length(8)]
        public DynamicArray SlabStandbyPageLists { get => ReadStructure<DynamicArray>(nameof(SlabStandbyPageLists)); set => WriteStructure(nameof(SlabStandbyPageLists), value); }

        [Offset(56192UL)]
        [Length(9)]
        public DynamicArray SlabRepurposedStandbyPageLists { get => ReadStructure<DynamicArray>(nameof(SlabRepurposedStandbyPageLists)); set => WriteStructure(nameof(SlabRepurposedStandbyPageLists), value); }

        [Offset(56984UL)]
        public RtlBitmap SlabTypeStandbyExistsBitmap { get => ReadStructure<RtlBitmap>(nameof(SlabTypeStandbyExistsBitmap)); set => WriteStructure(nameof(SlabTypeStandbyExistsBitmap), value); }

        [Offset(57000UL)]
        [Length(1)]
        public DynamicArray SlabTypeStandbyExistsBitmapBuffer { get => ReadStructure<DynamicArray>(nameof(SlabTypeStandbyExistsBitmapBuffer)); set => WriteStructure(nameof(SlabTypeStandbyExistsBitmapBuffer), value); }

        [Offset(57008UL)]
        public IntPtr SlabIdentityState { get => ReadHere<IntPtr>(nameof(SlabIdentityState)); set => WriteHere(nameof(SlabIdentityState), value); }

        [Offset(57016UL)]
        public ulong MdlSlabFragmentionLastDemoteTime { get => ReadHere<ulong>(nameof(MdlSlabFragmentionLastDemoteTime)); set => WriteHere(nameof(MdlSlabFragmentionLastDemoteTime), value); }

        [Offset(57024UL)]
        public Mmpfnlist EnclavePageListHead { get => ReadStructure<Mmpfnlist>(nameof(EnclavePageListHead)); set => WriteStructure(nameof(EnclavePageListHead), value); }

        [Offset(57112UL)]
        public MiLargePageNodeCoalesceState LargePageCoalesceState { get => ReadStructure<MiLargePageNodeCoalesceState>(nameof(LargePageCoalesceState)); set => WriteStructure(nameof(LargePageCoalesceState), value); }

        public MiNodeInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiNodeInformation>();
        }
    }
}