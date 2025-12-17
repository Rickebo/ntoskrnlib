using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_COMPLETION_QUEUE")]
    public sealed class NtIoringCompletionQueue : DynamicStructure
    {
        [Offset(0UL)]
        public uint Head { get => ReadHere<uint>(nameof(Head)); set => WriteHere(nameof(Head), value); }

        [Offset(4UL)]
        public uint Tail { get => ReadHere<uint>(nameof(Tail)); set => WriteHere(nameof(Tail), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Entries { get => ReadStructure<DynamicArray>(nameof(Entries)); set => WriteStructure(nameof(Entries), value); }

        public NtIoringCompletionQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringCompletionQueue>();
        }
    }
}