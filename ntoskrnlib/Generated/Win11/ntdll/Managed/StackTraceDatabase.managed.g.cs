using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_STACK_TRACE_DATABASE")]
    public sealed class StackTraceDatabase : DynamicStructure
    {
        [Offset(0UL)]
        [Length(104)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(0UL)]
        public RtlStackDatabaseLock Lock { get => ReadStructure<RtlStackDatabaseLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(104UL)]
        public IntPtr Reserved2 { get => ReadHere<IntPtr>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(112UL)]
        public ulong PeakHashCollisionListLength { get => ReadHere<ulong>(nameof(PeakHashCollisionListLength)); set => WriteHere(nameof(PeakHashCollisionListLength), value); }

        [Offset(120UL)]
        public IntPtr LowerMemoryStart { get => ReadHere<IntPtr>(nameof(LowerMemoryStart)); set => WriteHere(nameof(LowerMemoryStart), value); }

        [Offset(128UL)]
        public byte PreCommitted { get => ReadHere<byte>(nameof(PreCommitted)); set => WriteHere(nameof(PreCommitted), value); }

        [Offset(129UL)]
        public byte DumpInProgress { get => ReadHere<byte>(nameof(DumpInProgress)); set => WriteHere(nameof(DumpInProgress), value); }

        [Offset(136UL)]
        public IntPtr CommitBase { get => ReadHere<IntPtr>(nameof(CommitBase)); set => WriteHere(nameof(CommitBase), value); }

        [Offset(144UL)]
        public IntPtr CurrentLowerCommitLimit { get => ReadHere<IntPtr>(nameof(CurrentLowerCommitLimit)); set => WriteHere(nameof(CurrentLowerCommitLimit), value); }

        [Offset(152UL)]
        public IntPtr CurrentUpperCommitLimit { get => ReadHere<IntPtr>(nameof(CurrentUpperCommitLimit)); set => WriteHere(nameof(CurrentUpperCommitLimit), value); }

        [Offset(160UL)]
        public IntPtr NextFreeLowerMemory { get => ReadHere<IntPtr>(nameof(NextFreeLowerMemory)); set => WriteHere(nameof(NextFreeLowerMemory), value); }

        [Offset(168UL)]
        public IntPtr NextFreeUpperMemory { get => ReadHere<IntPtr>(nameof(NextFreeUpperMemory)); set => WriteHere(nameof(NextFreeUpperMemory), value); }

        [Offset(176UL)]
        public uint NumberOfEntriesLookedUp { get => ReadHere<uint>(nameof(NumberOfEntriesLookedUp)); set => WriteHere(nameof(NumberOfEntriesLookedUp), value); }

        [Offset(180UL)]
        public uint NumberOfEntriesAdded { get => ReadHere<uint>(nameof(NumberOfEntriesAdded)); set => WriteHere(nameof(NumberOfEntriesAdded), value); }

        [Offset(184UL)]
        public IntPtr EntryIndexArray { get => ReadHere<IntPtr>(nameof(EntryIndexArray)); set => WriteHere(nameof(EntryIndexArray), value); }

        [Offset(192UL)]
        public uint NumberOfEntriesAllocated { get => ReadHere<uint>(nameof(NumberOfEntriesAllocated)); set => WriteHere(nameof(NumberOfEntriesAllocated), value); }

        [Offset(196UL)]
        public uint NumberOfEntriesAvailable { get => ReadHere<uint>(nameof(NumberOfEntriesAvailable)); set => WriteHere(nameof(NumberOfEntriesAvailable), value); }

        [Offset(200UL)]
        public uint NumberOfAllocationFailures { get => ReadHere<uint>(nameof(NumberOfAllocationFailures)); set => WriteHere(nameof(NumberOfAllocationFailures), value); }

        [Offset(208UL)]
        [Length(32)]
        public DynamicArray FreeLists { get => ReadStructure<DynamicArray>(nameof(FreeLists)); set => WriteStructure(nameof(FreeLists), value); }

        [Offset(720UL)]
        public uint NumberOfBuckets { get => ReadHere<uint>(nameof(NumberOfBuckets)); set => WriteHere(nameof(NumberOfBuckets), value); }

        [Offset(728UL)]
        [Length(1)]
        public DynamicArray Buckets { get => ReadStructure<DynamicArray>(nameof(Buckets)); set => WriteStructure(nameof(Buckets), value); }

        public StackTraceDatabase(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<StackTraceDatabase>();
        }
    }
}