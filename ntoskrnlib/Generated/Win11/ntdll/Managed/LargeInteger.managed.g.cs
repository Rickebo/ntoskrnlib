using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_LARGE_INTEGER")]
    public sealed class LargeInteger : DynamicStructure
    {
        [Offset(0UL)]
        public uint LowPart { get => ReadHere<uint>(nameof(LowPart)); set => WriteHere(nameof(LowPart), value); }

        [Offset(4UL)]
        public int HighPart { get => ReadHere<int>(nameof(HighPart)); set => WriteHere(nameof(HighPart), value); }

        [Offset(0UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(0UL)]
        public long QuadPart { get => ReadHere<long>(nameof(QuadPart)); set => WriteHere(nameof(QuadPart), value); }

        public LargeInteger(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LargeInteger>();
        }
    }
}