using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SINGLE_LIST_ENTRY32")]
    public sealed class SingleListENTRY32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Next { get => ReadHere<uint>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        public SingleListENTRY32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SingleListENTRY32>();
        }
    }
}