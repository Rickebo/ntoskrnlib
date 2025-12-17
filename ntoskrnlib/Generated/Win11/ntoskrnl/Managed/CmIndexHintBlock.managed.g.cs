using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_INDEX_HINT_BLOCK")]
    public sealed class CmIndexHintBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(4UL)]
        [Length(1)]
        public DynamicArray HashKey { get => ReadStructure<DynamicArray>(nameof(HashKey)); set => WriteStructure(nameof(HashKey), value); }

        public CmIndexHintBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmIndexHintBlock>();
        }
    }
}