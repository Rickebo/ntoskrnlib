using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEAP_ERROR_SOURCE_TABLE")]
    public sealed class WheapErrorSourceTable : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public int Count { get => ReadHere<int>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        public uint NextId { get => ReadHere<uint>(nameof(NextId)); set => WriteHere(nameof(NextId), value); }

        [Offset(16UL)]
        public ListEntry Items { get => ReadStructure<ListEntry>(nameof(Items)); set => WriteStructure(nameof(Items), value); }

        [Offset(32UL)]
        public Kevent InsertLock { get => ReadStructure<Kevent>(nameof(InsertLock)); set => WriteStructure(nameof(InsertLock), value); }

        public WheapErrorSourceTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheapErrorSourceTable>();
        }
    }
}