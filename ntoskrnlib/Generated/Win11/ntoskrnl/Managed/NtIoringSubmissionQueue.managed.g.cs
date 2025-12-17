using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_SUBMISSION_QUEUE")]
    public sealed class NtIoringSubmissionQueue : DynamicStructure
    {
        [Offset(0UL)]
        public uint Head { get => ReadHere<uint>(nameof(Head)); set => WriteHere(nameof(Head), value); }

        [Offset(4UL)]
        public uint Tail { get => ReadHere<uint>(nameof(Tail)); set => WriteHere(nameof(Tail), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        [Length(1)]
        public DynamicArray Entries { get => ReadStructure<DynamicArray>(nameof(Entries)); set => WriteStructure(nameof(Entries), value); }

        public NtIoringSubmissionQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringSubmissionQueue>();
        }
    }
}