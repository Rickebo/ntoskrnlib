using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_DRIVER_VERIFIER_DATA")]
    public sealed class MmDriverVerifierData : DynamicStructure
    {
        [Offset(0UL)]
        public uint Level { get => ReadHere<uint>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(4UL)]
        public uint RaiseIrqls { get => ReadHere<uint>(nameof(RaiseIrqls)); set => WriteHere(nameof(RaiseIrqls), value); }

        [Offset(8UL)]
        public uint AcquireSpinLocks { get => ReadHere<uint>(nameof(AcquireSpinLocks)); set => WriteHere(nameof(AcquireSpinLocks), value); }

        [Offset(12UL)]
        public uint SynchronizeExecutions { get => ReadHere<uint>(nameof(SynchronizeExecutions)); set => WriteHere(nameof(SynchronizeExecutions), value); }

        [Offset(16UL)]
        public uint AllocationsAttempted { get => ReadHere<uint>(nameof(AllocationsAttempted)); set => WriteHere(nameof(AllocationsAttempted), value); }

        [Offset(20UL)]
        public uint AllocationsSucceeded { get => ReadHere<uint>(nameof(AllocationsSucceeded)); set => WriteHere(nameof(AllocationsSucceeded), value); }

        [Offset(24UL)]
        public uint AllocationsSucceededSpecialPool { get => ReadHere<uint>(nameof(AllocationsSucceededSpecialPool)); set => WriteHere(nameof(AllocationsSucceededSpecialPool), value); }

        [Offset(28UL)]
        public uint AllocationsWithNoTag { get => ReadHere<uint>(nameof(AllocationsWithNoTag)); set => WriteHere(nameof(AllocationsWithNoTag), value); }

        [Offset(32UL)]
        public uint TrimRequests { get => ReadHere<uint>(nameof(TrimRequests)); set => WriteHere(nameof(TrimRequests), value); }

        [Offset(36UL)]
        public uint Trims { get => ReadHere<uint>(nameof(Trims)); set => WriteHere(nameof(Trims), value); }

        [Offset(40UL)]
        public uint AllocationsFailed { get => ReadHere<uint>(nameof(AllocationsFailed)); set => WriteHere(nameof(AllocationsFailed), value); }

        [Offset(44UL)]
        public uint AllocationsFailedDeliberately { get => ReadHere<uint>(nameof(AllocationsFailedDeliberately)); set => WriteHere(nameof(AllocationsFailedDeliberately), value); }

        [Offset(48UL)]
        public uint AllocationFreed { get => ReadHere<uint>(nameof(AllocationFreed)); set => WriteHere(nameof(AllocationFreed), value); }

        [Offset(52UL)]
        public uint Loads { get => ReadHere<uint>(nameof(Loads)); set => WriteHere(nameof(Loads), value); }

        [Offset(56UL)]
        public uint Unloads { get => ReadHere<uint>(nameof(Unloads)); set => WriteHere(nameof(Unloads), value); }

        [Offset(60UL)]
        public uint UnTrackedPool { get => ReadHere<uint>(nameof(UnTrackedPool)); set => WriteHere(nameof(UnTrackedPool), value); }

        [Offset(64UL)]
        public uint UserTrims { get => ReadHere<uint>(nameof(UserTrims)); set => WriteHere(nameof(UserTrims), value); }

        [Offset(68UL)]
        public uint CurrentPagedPoolAllocations { get => ReadHere<uint>(nameof(CurrentPagedPoolAllocations)); set => WriteHere(nameof(CurrentPagedPoolAllocations), value); }

        [Offset(72UL)]
        public uint CurrentNonPagedPoolAllocations { get => ReadHere<uint>(nameof(CurrentNonPagedPoolAllocations)); set => WriteHere(nameof(CurrentNonPagedPoolAllocations), value); }

        [Offset(76UL)]
        public uint PeakPagedPoolAllocations { get => ReadHere<uint>(nameof(PeakPagedPoolAllocations)); set => WriteHere(nameof(PeakPagedPoolAllocations), value); }

        [Offset(80UL)]
        public uint PeakNonPagedPoolAllocations { get => ReadHere<uint>(nameof(PeakNonPagedPoolAllocations)); set => WriteHere(nameof(PeakNonPagedPoolAllocations), value); }

        [Offset(88UL)]
        public ulong PagedBytes { get => ReadHere<ulong>(nameof(PagedBytes)); set => WriteHere(nameof(PagedBytes), value); }

        [Offset(96UL)]
        public ulong NonPagedBytes { get => ReadHere<ulong>(nameof(NonPagedBytes)); set => WriteHere(nameof(NonPagedBytes), value); }

        [Offset(104UL)]
        public ulong PeakPagedBytes { get => ReadHere<ulong>(nameof(PeakPagedBytes)); set => WriteHere(nameof(PeakPagedBytes), value); }

        [Offset(112UL)]
        public ulong PeakNonPagedBytes { get => ReadHere<ulong>(nameof(PeakNonPagedBytes)); set => WriteHere(nameof(PeakNonPagedBytes), value); }

        [Offset(120UL)]
        public uint BurstAllocationsFailedDeliberately { get => ReadHere<uint>(nameof(BurstAllocationsFailedDeliberately)); set => WriteHere(nameof(BurstAllocationsFailedDeliberately), value); }

        [Offset(124UL)]
        public uint SessionTrims { get => ReadHere<uint>(nameof(SessionTrims)); set => WriteHere(nameof(SessionTrims), value); }

        [Offset(128UL)]
        public uint OptionChanges { get => ReadHere<uint>(nameof(OptionChanges)); set => WriteHere(nameof(OptionChanges), value); }

        [Offset(132UL)]
        public uint VerifyMode { get => ReadHere<uint>(nameof(VerifyMode)); set => WriteHere(nameof(VerifyMode), value); }

        [Offset(136UL)]
        public UnicodeString PreviousBucketName { get => ReadStructure<UnicodeString>(nameof(PreviousBucketName)); set => WriteStructure(nameof(PreviousBucketName), value); }

        public MmDriverVerifierData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmDriverVerifierData>();
        }
    }
}