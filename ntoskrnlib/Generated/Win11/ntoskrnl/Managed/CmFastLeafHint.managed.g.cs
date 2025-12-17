using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_FAST_LEAF_HINT")]
    public sealed class CmFastLeafHint : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray Characters { get => ReadStructure<DynamicArray>(nameof(Characters)); set => WriteStructure(nameof(Characters), value); }

        [Offset(0UL)]
        public uint FullHint { get => ReadHere<uint>(nameof(FullHint)); set => WriteHere(nameof(FullHint), value); }

        public CmFastLeafHint(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmFastLeafHint>();
        }
    }
}