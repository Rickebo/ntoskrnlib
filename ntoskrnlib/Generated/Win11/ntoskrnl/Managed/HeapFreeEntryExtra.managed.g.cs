using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_FREE_ENTRY_EXTRA")]
    public sealed class HeapFreeEntryExtra : DynamicStructure
    {
        [Offset(0UL)]
        public ushort TagIndex { get => ReadHere<ushort>(nameof(TagIndex)); set => WriteHere(nameof(TagIndex), value); }

        [Offset(2UL)]
        public ushort FreeBackTraceIndex { get => ReadHere<ushort>(nameof(FreeBackTraceIndex)); set => WriteHere(nameof(FreeBackTraceIndex), value); }

        public HeapFreeEntryExtra(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapFreeEntryExtra>();
        }
    }
}