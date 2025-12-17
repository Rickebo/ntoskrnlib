using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ULARGE_INTEGER")]
    public sealed class UlargeInteger : DynamicStructure
    {
        [Offset(0UL)]
        public uint LowPart { get => ReadHere<uint>(nameof(LowPart)); set => WriteHere(nameof(LowPart), value); }

        [Offset(4UL)]
        public uint HighPart { get => ReadHere<uint>(nameof(HighPart)); set => WriteHere(nameof(HighPart), value); }

        [Offset(0UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(0UL)]
        public ulong QuadPart { get => ReadHere<ulong>(nameof(QuadPart)); set => WriteHere(nameof(QuadPart), value); }

        public UlargeInteger(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<UlargeInteger>();
        }
    }
}