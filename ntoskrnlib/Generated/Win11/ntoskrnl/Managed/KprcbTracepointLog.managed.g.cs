using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPRCB_TRACEPOINT_LOG")]
    public sealed class KprcbTracepointLog : DynamicStructure
    {
        [Offset(0UL)]
        [Length(256)]
        public DynamicArray Entries { get => ReadStructure<DynamicArray>(nameof(Entries)); set => WriteStructure(nameof(Entries), value); }

        [Offset(8192UL)]
        public uint LogIndex { get => ReadHere<uint>(nameof(LogIndex)); set => WriteHere(nameof(LogIndex), value); }

        public KprcbTracepointLog(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprcbTracepointLog>();
        }
    }
}