using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SECONDARY_IC_LIST_ENTRY")]
    public sealed class SecondaryIcListEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public uint GsivBase { get => ReadHere<uint>(nameof(GsivBase)); set => WriteHere(nameof(GsivBase), value); }

        [Offset(20UL)]
        public uint GsivSize { get => ReadHere<uint>(nameof(GsivSize)); set => WriteHere(nameof(GsivSize), value); }

        [Offset(24UL)]
        public SecondaryInterruptProviderInterface Interface { get => ReadStructure<SecondaryInterruptProviderInterface>(nameof(Interface)); set => WriteStructure(nameof(Interface), value); }

        [Offset(112UL)]
        public int BusyCount { get => ReadHere<int>(nameof(BusyCount)); set => WriteHere(nameof(BusyCount), value); }

        [Offset(116UL)]
        public int ExclusiveWaiterCount { get => ReadHere<int>(nameof(ExclusiveWaiterCount)); set => WriteHere(nameof(ExclusiveWaiterCount), value); }

        [Offset(120UL)]
        public Kevent NotificationEvent { get => ReadStructure<Kevent>(nameof(NotificationEvent)); set => WriteStructure(nameof(NotificationEvent), value); }

        [Offset(144UL)]
        public ListEntry SignalListEntry { get => ReadStructure<ListEntry>(nameof(SignalListEntry)); set => WriteStructure(nameof(SignalListEntry), value); }

        [Offset(160UL)]
        [Length(1)]
        public DynamicArray State { get => ReadStructure<DynamicArray>(nameof(State)); set => WriteStructure(nameof(State), value); }

        public SecondaryIcListEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SecondaryIcListEntry>();
        }
    }
}