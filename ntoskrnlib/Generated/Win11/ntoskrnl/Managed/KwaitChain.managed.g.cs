using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KWAIT_CHAIN")]
    public sealed class KwaitChain : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Head { get => ReadHere<IntPtr>(nameof(Head)); set => WriteHere(nameof(Head), value); }

        public KwaitChain(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KwaitChain>();
        }
    }
}