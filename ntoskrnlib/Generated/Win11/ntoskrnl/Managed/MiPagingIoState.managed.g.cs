using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGING_IO_STATE")]
    public sealed class MiPagingIoState : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTree PageFileHead { get => ReadStructure<RtlAvlTree>(nameof(PageFileHead)); set => WriteStructure(nameof(PageFileHead), value); }

        [Offset(8UL)]
        public int PageFileHeadSpinLock { get => ReadHere<int>(nameof(PageFileHeadSpinLock)); set => WriteHere(nameof(PageFileHeadSpinLock), value); }

        [Offset(12UL)]
        public MiPagefileMetadataLayout PageFileMetadata { get => ReadStructure<MiPagefileMetadataLayout>(nameof(PageFileMetadata)); set => WriteStructure(nameof(PageFileMetadata), value); }

        [Offset(20UL)]
        public int PrefetchSeekThreshold { get => ReadHere<int>(nameof(PrefetchSeekThreshold)); set => WriteHere(nameof(PrefetchSeekThreshold), value); }

        [Offset(24UL)]
        public uint InPageSinglePages { get => ReadHere<uint>(nameof(InPageSinglePages)); set => WriteHere(nameof(InPageSinglePages), value); }

        [Offset(32UL)]
        [Length(2)]
        public DynamicArray InPageSupportSListHead { get => ReadStructure<DynamicArray>(nameof(InPageSupportSListHead)); set => WriteStructure(nameof(InPageSupportSListHead), value); }

        [Offset(64UL)]
        [Length(2)]
        public DynamicArray ReservedInPageSupportSListHead { get => ReadStructure<DynamicArray>(nameof(ReservedInPageSupportSListHead)); set => WriteStructure(nameof(ReservedInPageSupportSListHead), value); }

        [Offset(96UL)]
        [Length(2)]
        public DynamicArray InPageSupportSListMinimum { get => ReadStructure<DynamicArray>(nameof(InPageSupportSListMinimum)); set => WriteStructure(nameof(InPageSupportSListMinimum), value); }

        [Offset(104UL)]
        [Length(2)]
        public DynamicArray FirstReservedInPageBlock { get => ReadStructure<DynamicArray>(nameof(FirstReservedInPageBlock)); set => WriteStructure(nameof(FirstReservedInPageBlock), value); }

        [Offset(120UL)]
        [Length(2)]
        public DynamicArray LastReservedInPageBlock { get => ReadStructure<DynamicArray>(nameof(LastReservedInPageBlock)); set => WriteStructure(nameof(LastReservedInPageBlock), value); }

        [Offset(136UL)]
        public IntPtr ReservedPtes { get => ReadHere<IntPtr>(nameof(ReservedPtes)); set => WriteHere(nameof(ReservedPtes), value); }

        [Offset(144UL)]
        public int ReservedPtesLock { get => ReadHere<int>(nameof(ReservedPtesLock)); set => WriteHere(nameof(ReservedPtesLock), value); }

        [Offset(148UL)]
        public uint ReservedPtesBitBuffer { get => ReadHere<uint>(nameof(ReservedPtesBitBuffer)); set => WriteHere(nameof(ReservedPtesBitBuffer), value); }

        [Offset(152UL)]
        public int DelayPageFaults { get => ReadHere<int>(nameof(DelayPageFaults)); set => WriteHere(nameof(DelayPageFaults), value); }

        [Offset(156UL)]
        public byte MdlsAdjusted { get => ReadHere<byte>(nameof(MdlsAdjusted)); set => WriteHere(nameof(MdlsAdjusted), value); }

        [Offset(160UL)]
        public int NumberOfFailedStoreReads { get => ReadHere<int>(nameof(NumberOfFailedStoreReads)); set => WriteHere(nameof(NumberOfFailedStoreReads), value); }

        public MiPagingIoState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPagingIoState>();
        }
    }
}