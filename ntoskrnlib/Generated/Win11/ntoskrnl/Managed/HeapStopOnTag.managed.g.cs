using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_STOP_ON_TAG")]
    public sealed class HeapStopOnTag : DynamicStructure
    {
        [Offset(0UL)]
        public uint HeapAndTagIndex { get => ReadHere<uint>(nameof(HeapAndTagIndex)); set => WriteHere(nameof(HeapAndTagIndex), value); }

        [Offset(0UL)]
        public ushort TagIndex { get => ReadHere<ushort>(nameof(TagIndex)); set => WriteHere(nameof(TagIndex), value); }

        [Offset(2UL)]
        public ushort HeapIndex { get => ReadHere<ushort>(nameof(HeapIndex)); set => WriteHere(nameof(HeapIndex), value); }

        public HeapStopOnTag(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapStopOnTag>();
        }
    }
}