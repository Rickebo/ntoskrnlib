using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MCI_ADDR")]
    public sealed class MciAddr : DynamicStructure
    {
        [Offset(0UL)]
        public uint Address { get => ReadHere<uint>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong QuadPart { get => ReadHere<ulong>(nameof(QuadPart)); set => WriteHere(nameof(QuadPart), value); }

        public MciAddr(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MciAddr>();
        }
    }
}