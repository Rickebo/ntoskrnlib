using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_PTRREF_LIST")]
    public sealed class HeapLfhPtrrefList : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Flink { get => ReadHere<ushort>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(2UL)]
        public ushort Blink { get => ReadHere<ushort>(nameof(Blink)); set => WriteHere(nameof(Blink), value); }

        public HeapLfhPtrrefList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhPtrrefList>();
        }
    }
}