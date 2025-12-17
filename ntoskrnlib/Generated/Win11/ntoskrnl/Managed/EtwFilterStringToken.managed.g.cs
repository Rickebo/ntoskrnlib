using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_STRING_TOKEN")]
    public sealed class EtwFilterStringToken : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Count { get => ReadHere<ushort>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Tokens { get => ReadStructure<DynamicArray>(nameof(Tokens)); set => WriteStructure(nameof(Tokens), value); }

        public EtwFilterStringToken(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwFilterStringToken>();
        }
    }
}