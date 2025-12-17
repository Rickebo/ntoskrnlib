using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPTE_ACTIVE_PAGE_TABLE_LINKS")]
    public sealed class MmpteActivePageTableLinks : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Flink { get => ReadHere<ulong>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(0UL)]
        public ulong BlinkHigh { get => ReadHere<ulong>(nameof(BlinkHigh)); set => WriteHere(nameof(BlinkHigh), value); }

        public MmpteActivePageTableLinks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmpteActivePageTableLinks>();
        }
    }
}