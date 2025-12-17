using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!LIST_ENTRY64")]
    public sealed class ListENTRY64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Flink { get => ReadHere<ulong>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(8UL)]
        public ulong Blink { get => ReadHere<ulong>(nameof(Blink)); set => WriteHere(nameof(Blink), value); }

        public ListENTRY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ListENTRY64>();
        }
    }
}