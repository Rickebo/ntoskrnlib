using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KQUEUE")]
    public sealed class Kqueue : DynamicStructure
    {
        [Offset(0UL)]
        public DispatcherHeader Header { get => ReadStructure<DispatcherHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(24UL)]
        public ListEntry EntryListHead { get => ReadStructure<ListEntry>(nameof(EntryListHead)); set => WriteStructure(nameof(EntryListHead), value); }

        [Offset(40UL)]
        public uint CurrentCount { get => ReadHere<uint>(nameof(CurrentCount)); set => WriteHere(nameof(CurrentCount), value); }

        [Offset(44UL)]
        public uint MaximumCount { get => ReadHere<uint>(nameof(MaximumCount)); set => WriteHere(nameof(MaximumCount), value); }

        [Offset(48UL)]
        public ListEntry ThreadListHead { get => ReadStructure<ListEntry>(nameof(ThreadListHead)); set => WriteStructure(nameof(ThreadListHead), value); }

        public Kqueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kqueue>();
        }
    }
}