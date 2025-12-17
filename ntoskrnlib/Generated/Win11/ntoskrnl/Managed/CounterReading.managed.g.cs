using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_COUNTER_READING")]
    public sealed class CounterReading : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint Index { get => ReadHere<uint>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(8UL)]
        public ulong Start { get => ReadHere<ulong>(nameof(Start)); set => WriteHere(nameof(Start), value); }

        [Offset(16UL)]
        public ulong Total { get => ReadHere<ulong>(nameof(Total)); set => WriteHere(nameof(Total), value); }

        public CounterReading(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CounterReading>();
        }
    }
}