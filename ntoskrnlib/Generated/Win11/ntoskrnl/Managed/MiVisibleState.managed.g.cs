using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_VISIBLE_STATE")]
    public sealed class MiVisibleState : DynamicStructure
    {
        [Offset(0UL)]
        public MmPagedPoolInfo PagedPoolInfo { get => ReadStructure<MmPagedPoolInfo>(nameof(PagedPoolInfo)); set => WriteStructure(nameof(PagedPoolInfo), value); }

        [Offset(24UL)]
        public ulong MaximumNonPagedPoolInPages { get => ReadHere<ulong>(nameof(MaximumNonPagedPoolInPages)); set => WriteHere(nameof(MaximumNonPagedPoolInPages), value); }

        [Offset(32UL)]
        public ulong SizeOfPagedPoolInPages { get => ReadHere<ulong>(nameof(SizeOfPagedPoolInPages)); set => WriteHere(nameof(SizeOfPagedPoolInPages), value); }

        [Offset(40UL)]
        public MiSystemPteType SystemPteInfo { get => ReadStructure<MiSystemPteType>(nameof(SystemPteInfo)); set => WriteStructure(nameof(SystemPteInfo), value); }

        [Offset(136UL)]
        public ulong NonPagedPoolCommit { get => ReadHere<ulong>(nameof(NonPagedPoolCommit)); set => WriteHere(nameof(NonPagedPoolCommit), value); }

        [Offset(144UL)]
        public ulong SmallNonPagedPtesCommit { get => ReadHere<ulong>(nameof(SmallNonPagedPtesCommit)); set => WriteHere(nameof(SmallNonPagedPtesCommit), value); }

        [Offset(152UL)]
        public ulong BootCommit { get => ReadHere<ulong>(nameof(BootCommit)); set => WriteHere(nameof(BootCommit), value); }

        [Offset(160UL)]
        public ulong SystemPageTableCommit { get => ReadHere<ulong>(nameof(SystemPageTableCommit)); set => WriteHere(nameof(SystemPageTableCommit), value); }

        [Offset(168UL)]
        public ulong ProcessCommit { get => ReadHere<ulong>(nameof(ProcessCommit)); set => WriteHere(nameof(ProcessCommit), value); }

        [Offset(176UL)]
        public int DriverCommit { get => ReadHere<int>(nameof(DriverCommit)); set => WriteHere(nameof(DriverCommit), value); }

        [Offset(180UL)]
        public byte PagingLevels { get => ReadHere<byte>(nameof(PagingLevels)); set => WriteHere(nameof(PagingLevels), value); }

        [Offset(184UL)]
        public ulong PfnDatabaseCommit { get => ReadHere<ulong>(nameof(PfnDatabaseCommit)); set => WriteHere(nameof(PfnDatabaseCommit), value); }

        [Offset(192UL)]
        [Length(64)]
        public DynamicArray TotalNodePagesInChildPartitions { get => ReadStructure<DynamicArray>(nameof(TotalNodePagesInChildPartitions)); set => WriteStructure(nameof(TotalNodePagesInChildPartitions), value); }

        [Offset(704UL)]
        [Length(64)]
        public DynamicArray TotalSpecialPurposeMemoryInChildPartitions { get => ReadStructure<DynamicArray>(nameof(TotalSpecialPurposeMemoryInChildPartitions)); set => WriteStructure(nameof(TotalSpecialPurposeMemoryInChildPartitions), value); }

        [Offset(1728UL)]
        [Length(9)]
        public DynamicArray SystemWs { get => ReadStructure<DynamicArray>(nameof(SystemWs)); set => WriteStructure(nameof(SystemWs), value); }

        [Offset(4608UL)]
        public MmsupportShared SystemCacheShared { get => ReadStructure<MmsupportShared>(nameof(SystemCacheShared)); set => WriteStructure(nameof(SystemCacheShared), value); }

        [Offset(4736UL)]
        [Length(1)]
        public DynamicArray AggregateSystemWs { get => ReadStructure<DynamicArray>(nameof(AggregateSystemWs)); set => WriteStructure(nameof(AggregateSystemWs), value); }

        [Offset(4768UL)]
        public uint MapCacheFailures { get => ReadHere<uint>(nameof(MapCacheFailures)); set => WriteHere(nameof(MapCacheFailures), value); }

        [Offset(4776UL)]
        public ulong PagefileHashPages { get => ReadHere<ulong>(nameof(PagefileHashPages)); set => WriteHere(nameof(PagefileHashPages), value); }

        [Offset(4784UL)]
        public SysptesHeader PteHeader { get => ReadStructure<SysptesHeader>(nameof(PteHeader)); set => WriteStructure(nameof(PteHeader), value); }

        [Offset(5064UL)]
        [Length(20)]
        public DynamicArray SystemVaTypeCount { get => ReadStructure<DynamicArray>(nameof(SystemVaTypeCount)); set => WriteStructure(nameof(SystemVaTypeCount), value); }

        [Offset(5224UL)]
        [Length(256)]
        public DynamicArray SystemVaType { get => ReadStructure<DynamicArray>(nameof(SystemVaType)); set => WriteStructure(nameof(SystemVaType), value); }

        [Offset(5480UL)]
        [Length(18)]
        public DynamicArray SystemVaRegions { get => ReadStructure<DynamicArray>(nameof(SystemVaRegions)); set => WriteStructure(nameof(SystemVaRegions), value); }

        [Offset(5768UL)]
        public ulong SecurePtRoot { get => ReadHere<ulong>(nameof(SecurePtRoot)); set => WriteHere(nameof(SecurePtRoot), value); }

        public MiVisibleState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiVisibleState>();
        }
    }
}