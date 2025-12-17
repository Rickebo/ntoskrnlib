using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSTACK_COUNT")]
    public sealed class KstackCount : DynamicStructure
    {
        [Offset(0UL)]
        public int Value { get => ReadHere<int>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(0UL)]
        public uint StackCount { get => ReadHere<uint>(nameof(StackCount)); set => WriteHere(nameof(StackCount), value); }

        public KstackCount(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KstackCount>();
        }
    }
}