using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MCI_STATS")]
    public sealed class MciStats : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag MciStatus { get => ReadStructure<UnnamedTag>(nameof(MciStatus)); set => WriteStructure(nameof(MciStatus), value); }

        [Offset(0UL)]
        public ulong QuadPart { get => ReadHere<ulong>(nameof(QuadPart)); set => WriteHere(nameof(QuadPart), value); }

        public MciStats(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MciStats>();
        }
    }
}