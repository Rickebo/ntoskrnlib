using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_FLAGS_COUNT")]
    public sealed class TppFlagsCount : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Count { get => ReadHere<ulong>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(0UL)]
        public ulong Flags { get => ReadHere<ulong>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(0UL)]
        public long Data { get => ReadHere<long>(nameof(Data)); set => WriteHere(nameof(Data), value); }

        public TppFlagsCount(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppFlagsCount>();
        }
    }
}