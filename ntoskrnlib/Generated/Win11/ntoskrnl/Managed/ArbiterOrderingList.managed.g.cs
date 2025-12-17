using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_ORDERING_LIST")]
    public sealed class ArbiterOrderingList : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Count { get => ReadHere<ushort>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(2UL)]
        public ushort Maximum { get => ReadHere<ushort>(nameof(Maximum)); set => WriteHere(nameof(Maximum), value); }

        [Offset(8UL)]
        public IntPtr Orderings { get => ReadHere<IntPtr>(nameof(Orderings)); set => WriteHere(nameof(Orderings), value); }

        public ArbiterOrderingList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterOrderingList>();
        }
    }
}