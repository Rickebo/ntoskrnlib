using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_DEBUGID_TRACKING_ENTRY")]
    public sealed class EtwDebugidTrackingEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public byte ConsumersNotified { get => ReadHere<byte>(nameof(ConsumersNotified)); set => WriteHere(nameof(ConsumersNotified), value); }

        [Offset(17UL)]
        [Length(3)]
        public DynamicArray Spare { get => ReadStructure<DynamicArray>(nameof(Spare)); set => WriteStructure(nameof(Spare), value); }

        [Offset(20UL)]
        public uint DebugIdSize { get => ReadHere<uint>(nameof(DebugIdSize)); set => WriteHere(nameof(DebugIdSize), value); }

        [Offset(24UL)]
        public Cvdd DebugId { get => ReadStructure<Cvdd>(nameof(DebugId)); set => WriteStructure(nameof(DebugId), value); }

        public EtwDebugidTrackingEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwDebugidTrackingEntry>();
        }
    }
}