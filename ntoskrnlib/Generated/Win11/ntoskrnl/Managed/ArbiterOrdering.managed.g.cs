using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_ORDERING")]
    public sealed class ArbiterOrdering : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Start { get => ReadHere<ulong>(nameof(Start)); set => WriteHere(nameof(Start), value); }

        [Offset(8UL)]
        public ulong End { get => ReadHere<ulong>(nameof(End)); set => WriteHere(nameof(End), value); }

        public ArbiterOrdering(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterOrdering>();
        }
    }
}