using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAST_OWNER_ENTRY_INTERNAL")]
    public sealed class FastOwnerEntryInternal : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr ThreadAddressAndDisowned { get => ReadHere<IntPtr>(nameof(ThreadAddressAndDisowned)); set => WriteHere(nameof(ThreadAddressAndDisowned), value); }

        [Offset(24UL)]
        public IntPtr LockAddress { get => ReadHere<IntPtr>(nameof(LockAddress)); set => WriteHere(nameof(LockAddress), value); }

        [Offset(32UL)]
        public int RecursiveReferenceCount { get => ReadHere<int>(nameof(RecursiveReferenceCount)); set => WriteHere(nameof(RecursiveReferenceCount), value); }

        [Offset(36UL)]
        public byte AbLockHandle { get => ReadHere<byte>(nameof(AbLockHandle)); set => WriteHere(nameof(AbLockHandle), value); }

        [Offset(37UL)]
        public byte DynamicallyAllocated { get => ReadHere<byte>(nameof(DynamicallyAllocated)); set => WriteHere(nameof(DynamicallyAllocated), value); }

        [Offset(37UL)]
        public byte CallerExclusive { get => ReadHere<byte>(nameof(CallerExclusive)); set => WriteHere(nameof(CallerExclusive), value); }

        [Offset(37UL)]
        public byte CurrentlyWaitingShared { get => ReadHere<byte>(nameof(CurrentlyWaitingShared)); set => WriteHere(nameof(CurrentlyWaitingShared), value); }

        [Offset(38UL)]
        [Length(2)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public FastOwnerEntryInternal(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FastOwnerEntryInternal>();
        }
    }
}