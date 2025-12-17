using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAKE_HEAP_ENTRY")]
    public sealed class FakeHeapEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public ulong PreviousSize { get => ReadHere<ulong>(nameof(PreviousSize)); set => WriteHere(nameof(PreviousSize), value); }

        public FakeHeapEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FakeHeapEntry>();
        }
    }
}