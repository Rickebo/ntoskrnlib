using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_EMERGENCY_LA_QUEUE_ENTRY")]
    public sealed class HalpEmergencyLaQueueEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public uint EntryType { get => ReadHere<uint>(nameof(EntryType)); set => WriteHere(nameof(EntryType), value); }

        public HalpEmergencyLaQueueEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpEmergencyLaQueueEntry>();
        }
    }
}