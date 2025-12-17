using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_M128A")]
    public sealed class M128A : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Low { get => ReadHere<ulong>(nameof(Low)); set => WriteHere(nameof(Low), value); }

        [Offset(8UL)]
        public long High { get => ReadHere<long>(nameof(High)); set => WriteHere(nameof(High), value); }

        public M128A(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<M128A>();
        }
    }
}