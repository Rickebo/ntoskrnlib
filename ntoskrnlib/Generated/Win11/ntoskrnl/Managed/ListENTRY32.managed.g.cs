using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!LIST_ENTRY32")]
    public sealed class ListENTRY32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Flink { get => ReadHere<uint>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(4UL)]
        public uint Blink { get => ReadHere<uint>(nameof(Blink)); set => WriteHere(nameof(Blink), value); }

        public ListENTRY32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ListENTRY32>();
        }
    }
}