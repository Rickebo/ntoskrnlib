using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPRIQUEUE")]
    public sealed class Kpriqueue : DynamicStructure
    {
        [Offset(0UL)]
        public DispatcherHeader Header { get => ReadStructure<DispatcherHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(24UL)]
        [Length(32)]
        public DynamicArray EntryListHead { get => ReadStructure<DynamicArray>(nameof(EntryListHead)); set => WriteStructure(nameof(EntryListHead), value); }

        [Offset(536UL)]
        [Length(32)]
        public DynamicArray CurrentCount { get => ReadStructure<DynamicArray>(nameof(CurrentCount)); set => WriteStructure(nameof(CurrentCount), value); }

        [Offset(664UL)]
        public uint MaximumCount { get => ReadHere<uint>(nameof(MaximumCount)); set => WriteHere(nameof(MaximumCount), value); }

        [Offset(672UL)]
        public ListEntry ThreadListHead { get => ReadStructure<ListEntry>(nameof(ThreadListHead)); set => WriteStructure(nameof(ThreadListHead), value); }

        public Kpriqueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kpriqueue>();
        }
    }
}