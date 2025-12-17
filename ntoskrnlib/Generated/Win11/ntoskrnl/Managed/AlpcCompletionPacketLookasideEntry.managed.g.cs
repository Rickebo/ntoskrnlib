using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY")]
    public sealed class AlpcCompletionPacketLookasideEntry : DynamicStructure
    {
        [Offset(0UL)]
        public SingleListEntry ListEntry { get => ReadStructure<SingleListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(8UL)]
        public IntPtr Packet { get => ReadHere<IntPtr>(nameof(Packet)); set => WriteHere(nameof(Packet), value); }

        [Offset(16UL)]
        public IntPtr Lookaside { get => ReadHere<IntPtr>(nameof(Lookaside)); set => WriteHere(nameof(Lookaside), value); }

        public AlpcCompletionPacketLookasideEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcCompletionPacketLookasideEntry>();
        }
    }
}