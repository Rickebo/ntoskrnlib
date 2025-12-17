using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_VISIBLE_PARTITION")]
    public sealed class MiVisiblePartition : DynamicStructure
    {
        [Offset(0UL)]
        public ulong LowestPhysicalPage { get => ReadHere<ulong>(nameof(LowestPhysicalPage)); set => WriteHere(nameof(LowestPhysicalPage), value); }

        [Offset(8UL)]
        public ulong HighestPhysicalPage { get => ReadHere<ulong>(nameof(HighestPhysicalPage)); set => WriteHere(nameof(HighestPhysicalPage), value); }

        [Offset(16UL)]
        public ulong NumberOfPhysicalPages { get => ReadHere<ulong>(nameof(NumberOfPhysicalPages)); set => WriteHere(nameof(NumberOfPhysicalPages), value); }

        [Offset(24UL)]
        public uint NumberOfPagingFiles { get => ReadHere<uint>(nameof(NumberOfPagingFiles)); set => WriteHere(nameof(NumberOfPagingFiles), value); }

        [Offset(28UL)]
        public byte SystemCacheInitialized { get => ReadHere<byte>(nameof(SystemCacheInitialized)); set => WriteHere(nameof(SystemCacheInitialized), value); }

        [Offset(32UL)]
        [Length(16)]
        public DynamicArray PagingFile { get => ReadStructure<DynamicArray>(nameof(PagingFile)); set => WriteStructure(nameof(PagingFile), value); }

        [Offset(192UL)]
        public ulong AvailablePages { get => ReadHere<ulong>(nameof(AvailablePages)); set => WriteHere(nameof(AvailablePages), value); }

        [Offset(256UL)]
        public ulong ResidentAvailablePages { get => ReadHere<ulong>(nameof(ResidentAvailablePages)); set => WriteHere(nameof(ResidentAvailablePages), value); }

        [Offset(320UL)]
        [Length(1)]
        public DynamicArray PartitionWs { get => ReadStructure<DynamicArray>(nameof(PartitionWs)); set => WriteStructure(nameof(PartitionWs), value); }

        [Offset(768UL)]
        public ulong TotalCommittedPages { get => ReadHere<ulong>(nameof(TotalCommittedPages)); set => WriteHere(nameof(TotalCommittedPages), value); }

        [Offset(832UL)]
        public ulong TotalCommittedPagesExposed { get => ReadHere<ulong>(nameof(TotalCommittedPagesExposed)); set => WriteHere(nameof(TotalCommittedPagesExposed), value); }

        [Offset(896UL)]
        public Mmpfnlist ModifiedPageListHead { get => ReadStructure<Mmpfnlist>(nameof(ModifiedPageListHead)); set => WriteStructure(nameof(ModifiedPageListHead), value); }

        [Offset(1024UL)]
        public Mmpfnlist ModifiedNoWritePageListHead { get => ReadStructure<Mmpfnlist>(nameof(ModifiedNoWritePageListHead)); set => WriteStructure(nameof(ModifiedNoWritePageListHead), value); }

        [Offset(1112UL)]
        public ulong TotalCommitLimit { get => ReadHere<ulong>(nameof(TotalCommitLimit)); set => WriteHere(nameof(TotalCommitLimit), value); }

        [Offset(1120UL)]
        public ulong TotalPagesForPagingFile { get => ReadHere<ulong>(nameof(TotalPagesForPagingFile)); set => WriteHere(nameof(TotalPagesForPagingFile), value); }

        [Offset(1128UL)]
        public ulong VadPhysicalPages { get => ReadHere<ulong>(nameof(VadPhysicalPages)); set => WriteHere(nameof(VadPhysicalPages), value); }

        [Offset(1136UL)]
        public ulong ProcessLockedFilePages { get => ReadHere<ulong>(nameof(ProcessLockedFilePages)); set => WriteHere(nameof(ProcessLockedFilePages), value); }

        [Offset(1144UL)]
        public ulong SharedCommit { get => ReadHere<ulong>(nameof(SharedCommit)); set => WriteHere(nameof(SharedCommit), value); }

        [Offset(1152UL)]
        public ulong MdlPagesAllocated { get => ReadHere<ulong>(nameof(MdlPagesAllocated)); set => WriteHere(nameof(MdlPagesAllocated), value); }

        [Offset(1160UL)]
        public ulong ContiguousPagesAllocated { get => ReadHere<ulong>(nameof(ContiguousPagesAllocated)); set => WriteHere(nameof(ContiguousPagesAllocated), value); }

        [Offset(1168UL)]
        public ulong SlabAllocatorPages { get => ReadHere<ulong>(nameof(SlabAllocatorPages)); set => WriteHere(nameof(SlabAllocatorPages), value); }

        [Offset(1176UL)]
        public ulong SlabAllocatorPagesUncharged { get => ReadHere<ulong>(nameof(SlabAllocatorPagesUncharged)); set => WriteHere(nameof(SlabAllocatorPagesUncharged), value); }

        [Offset(1184UL)]
        public ulong BootSlabPages { get => ReadHere<ulong>(nameof(BootSlabPages)); set => WriteHere(nameof(BootSlabPages), value); }

        [Offset(1192UL)]
        public ulong SecureKernelPagesFromNonChargedSlabs { get => ReadHere<ulong>(nameof(SecureKernelPagesFromNonChargedSlabs)); set => WriteHere(nameof(SecureKernelPagesFromNonChargedSlabs), value); }

        [Offset(1200UL)]
        [Length(4)]
        public DynamicArray ChargeCommitmentFailures { get => ReadStructure<DynamicArray>(nameof(ChargeCommitmentFailures)); set => WriteStructure(nameof(ChargeCommitmentFailures), value); }

        [Offset(1216UL)]
        public int PageFileTraceIndex { get => ReadHere<int>(nameof(PageFileTraceIndex)); set => WriteHere(nameof(PageFileTraceIndex), value); }

        [Offset(1224UL)]
        [Length(32)]
        public DynamicArray PageFileTraces { get => ReadStructure<DynamicArray>(nameof(PageFileTraces)); set => WriteStructure(nameof(PageFileTraces), value); }

        public MiVisiblePartition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiVisiblePartition>();
        }
    }
}