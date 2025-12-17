using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_LUID")]
    public sealed class Luid : DynamicStructure
    {
        [Offset(0UL)]
        public uint LowPart { get => ReadHere<uint>(nameof(LowPart)); set => WriteHere(nameof(LowPart), value); }

        [Offset(4UL)]
        public int HighPart { get => ReadHere<int>(nameof(HighPart)); set => WriteHere(nameof(HighPart), value); }

        public Luid(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Luid>();
        }
    }
}