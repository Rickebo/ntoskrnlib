using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_VIRTUAL_ALLOC_ENTRY")]
    public sealed class HeapVirtualAllocEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Entry { get => ReadStructure<ListEntry>(nameof(Entry)); set => WriteStructure(nameof(Entry), value); }

        [Offset(16UL)]
        public HeapEntryExtra ExtraStuff { get => ReadStructure<HeapEntryExtra>(nameof(ExtraStuff)); set => WriteStructure(nameof(ExtraStuff), value); }

        [Offset(32UL)]
        public ulong CommitSize { get => ReadHere<ulong>(nameof(CommitSize)); set => WriteHere(nameof(CommitSize), value); }

        [Offset(40UL)]
        public ulong ReserveSize { get => ReadHere<ulong>(nameof(ReserveSize)); set => WriteHere(nameof(ReserveSize), value); }

        [Offset(48UL)]
        public HeapEntry BusyBlock { get => ReadStructure<HeapEntry>(nameof(BusyBlock)); set => WriteStructure(nameof(BusyBlock), value); }

        public HeapVirtualAllocEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapVirtualAllocEntry>();
        }
    }
}