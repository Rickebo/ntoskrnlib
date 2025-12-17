using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INBV_OFFSET")]
    public sealed class InbvOffset : DynamicStructure
    {
        [Offset(0UL)]
        public uint X { get => ReadHere<uint>(nameof(X)); set => WriteHere(nameof(X), value); }

        [Offset(4UL)]
        public uint Y { get => ReadHere<uint>(nameof(Y)); set => WriteHere(nameof(Y), value); }

        public InbvOffset(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InbvOffset>();
        }
    }
}