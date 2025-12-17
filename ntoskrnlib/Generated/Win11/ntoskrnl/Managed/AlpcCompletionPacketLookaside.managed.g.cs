using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_PACKET_LOOKASIDE")]
    public sealed class AlpcCompletionPacketLookaside : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(12UL)]
        public uint ActiveCount { get => ReadHere<uint>(nameof(ActiveCount)); set => WriteHere(nameof(ActiveCount), value); }

        [Offset(16UL)]
        public uint PendingNullCount { get => ReadHere<uint>(nameof(PendingNullCount)); set => WriteHere(nameof(PendingNullCount), value); }

        [Offset(20UL)]
        public uint PendingCheckCompletionListCount { get => ReadHere<uint>(nameof(PendingCheckCompletionListCount)); set => WriteHere(nameof(PendingCheckCompletionListCount), value); }

        [Offset(24UL)]
        public uint PendingDelete { get => ReadHere<uint>(nameof(PendingDelete)); set => WriteHere(nameof(PendingDelete), value); }

        [Offset(32UL)]
        public SingleListEntry FreeListHead { get => ReadStructure<SingleListEntry>(nameof(FreeListHead)); set => WriteStructure(nameof(FreeListHead), value); }

        [Offset(40UL)]
        public IntPtr CompletionPort { get => ReadHere<IntPtr>(nameof(CompletionPort)); set => WriteHere(nameof(CompletionPort), value); }

        [Offset(48UL)]
        public IntPtr CompletionKey { get => ReadHere<IntPtr>(nameof(CompletionKey)); set => WriteHere(nameof(CompletionKey), value); }

        [Offset(56UL)]
        [Length(1)]
        public DynamicArray Entry { get => ReadStructure<DynamicArray>(nameof(Entry)); set => WriteStructure(nameof(Entry), value); }

        public AlpcCompletionPacketLookaside(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcCompletionPacketLookaside>();
        }
    }
}