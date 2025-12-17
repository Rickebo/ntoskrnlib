using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_TARGET_VERIFIED_DRIVER_DATA")]
    public sealed class VfTargetVerifiedDriverData : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SuspectDriverEntry { get => ReadHere<IntPtr>(nameof(SuspectDriverEntry)); set => WriteHere(nameof(SuspectDriverEntry), value); }

        [Offset(8UL)]
        public IntPtr WMICallback { get => ReadHere<IntPtr>(nameof(WMICallback)); set => WriteHere(nameof(WMICallback), value); }

        [Offset(16UL)]
        public ListEntry EtwHandlesListHead { get => ReadStructure<ListEntry>(nameof(EtwHandlesListHead)); set => WriteStructure(nameof(EtwHandlesListHead), value); }

        [Offset(32UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(40UL)]
        public ulong Signature { get => ReadHere<ulong>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(48UL)]
        public byte SeSigningLevel { get => ReadHere<byte>(nameof(SeSigningLevel)); set => WriteHere(nameof(SeSigningLevel), value); }

        [Offset(64UL)]
        public SlistHeader PoolPageHeaders { get => ReadStructure<SlistHeader>(nameof(PoolPageHeaders)); set => WriteStructure(nameof(PoolPageHeaders), value); }

        [Offset(80UL)]
        public SlistHeader PoolTrackers { get => ReadStructure<SlistHeader>(nameof(PoolTrackers)); set => WriteStructure(nameof(PoolTrackers), value); }

        [Offset(96UL)]
        public ListEntry DifPluginPerDriverDataContextHead { get => ReadStructure<ListEntry>(nameof(DifPluginPerDriverDataContextHead)); set => WriteStructure(nameof(DifPluginPerDriverDataContextHead), value); }

        [Offset(112UL)]
        public uint CurrentPagedPoolAllocations { get => ReadHere<uint>(nameof(CurrentPagedPoolAllocations)); set => WriteHere(nameof(CurrentPagedPoolAllocations), value); }

        [Offset(116UL)]
        public uint CurrentNonPagedPoolAllocations { get => ReadHere<uint>(nameof(CurrentNonPagedPoolAllocations)); set => WriteHere(nameof(CurrentNonPagedPoolAllocations), value); }

        [Offset(120UL)]
        public uint PeakPagedPoolAllocations { get => ReadHere<uint>(nameof(PeakPagedPoolAllocations)); set => WriteHere(nameof(PeakPagedPoolAllocations), value); }

        [Offset(124UL)]
        public uint PeakNonPagedPoolAllocations { get => ReadHere<uint>(nameof(PeakNonPagedPoolAllocations)); set => WriteHere(nameof(PeakNonPagedPoolAllocations), value); }

        [Offset(128UL)]
        public ulong PagedBytes { get => ReadHere<ulong>(nameof(PagedBytes)); set => WriteHere(nameof(PagedBytes), value); }

        [Offset(136UL)]
        public ulong NonPagedBytes { get => ReadHere<ulong>(nameof(NonPagedBytes)); set => WriteHere(nameof(NonPagedBytes), value); }

        [Offset(144UL)]
        public ulong PeakPagedBytes { get => ReadHere<ulong>(nameof(PeakPagedBytes)); set => WriteHere(nameof(PeakPagedBytes), value); }

        [Offset(152UL)]
        public ulong PeakNonPagedBytes { get => ReadHere<ulong>(nameof(PeakNonPagedBytes)); set => WriteHere(nameof(PeakNonPagedBytes), value); }

        [Offset(160UL)]
        public uint RaiseIrqls { get => ReadHere<uint>(nameof(RaiseIrqls)); set => WriteHere(nameof(RaiseIrqls), value); }

        [Offset(164UL)]
        public uint AcquireSpinLocks { get => ReadHere<uint>(nameof(AcquireSpinLocks)); set => WriteHere(nameof(AcquireSpinLocks), value); }

        [Offset(168UL)]
        public uint SynchronizeExecutions { get => ReadHere<uint>(nameof(SynchronizeExecutions)); set => WriteHere(nameof(SynchronizeExecutions), value); }

        [Offset(172UL)]
        public uint AllocationsWithNoTag { get => ReadHere<uint>(nameof(AllocationsWithNoTag)); set => WriteHere(nameof(AllocationsWithNoTag), value); }

        [Offset(176UL)]
        public uint AllocationsFailed { get => ReadHere<uint>(nameof(AllocationsFailed)); set => WriteHere(nameof(AllocationsFailed), value); }

        [Offset(180UL)]
        public uint AllocationsFailedDeliberately { get => ReadHere<uint>(nameof(AllocationsFailedDeliberately)); set => WriteHere(nameof(AllocationsFailedDeliberately), value); }

        [Offset(184UL)]
        public ulong LockedBytes { get => ReadHere<ulong>(nameof(LockedBytes)); set => WriteHere(nameof(LockedBytes), value); }

        [Offset(192UL)]
        public ulong PeakLockedBytes { get => ReadHere<ulong>(nameof(PeakLockedBytes)); set => WriteHere(nameof(PeakLockedBytes), value); }

        [Offset(200UL)]
        public ulong MappedLockedBytes { get => ReadHere<ulong>(nameof(MappedLockedBytes)); set => WriteHere(nameof(MappedLockedBytes), value); }

        [Offset(208UL)]
        public ulong PeakMappedLockedBytes { get => ReadHere<ulong>(nameof(PeakMappedLockedBytes)); set => WriteHere(nameof(PeakMappedLockedBytes), value); }

        [Offset(216UL)]
        public ulong MappedIoSpaceBytes { get => ReadHere<ulong>(nameof(MappedIoSpaceBytes)); set => WriteHere(nameof(MappedIoSpaceBytes), value); }

        [Offset(224UL)]
        public ulong PeakMappedIoSpaceBytes { get => ReadHere<ulong>(nameof(PeakMappedIoSpaceBytes)); set => WriteHere(nameof(PeakMappedIoSpaceBytes), value); }

        [Offset(232UL)]
        public ulong PagesForMdlBytes { get => ReadHere<ulong>(nameof(PagesForMdlBytes)); set => WriteHere(nameof(PagesForMdlBytes), value); }

        [Offset(240UL)]
        public ulong PeakPagesForMdlBytes { get => ReadHere<ulong>(nameof(PeakPagesForMdlBytes)); set => WriteHere(nameof(PeakPagesForMdlBytes), value); }

        [Offset(248UL)]
        public ulong ContiguousMemoryBytes { get => ReadHere<ulong>(nameof(ContiguousMemoryBytes)); set => WriteHere(nameof(ContiguousMemoryBytes), value); }

        [Offset(256UL)]
        public ulong PeakContiguousMemoryBytes { get => ReadHere<ulong>(nameof(PeakContiguousMemoryBytes)); set => WriteHere(nameof(PeakContiguousMemoryBytes), value); }

        [Offset(264UL)]
        public ListEntry ContiguousMemoryListHead { get => ReadStructure<ListEntry>(nameof(ContiguousMemoryListHead)); set => WriteStructure(nameof(ContiguousMemoryListHead), value); }

        public VfTargetVerifiedDriverData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfTargetVerifiedDriverData>();
        }
    }
}