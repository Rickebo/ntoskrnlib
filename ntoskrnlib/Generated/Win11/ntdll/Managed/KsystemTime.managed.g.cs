using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSYSTEM_TIME")]
    public sealed class KsystemTime : DynamicStructure
    {
        [Offset(0UL)]
        public uint LowPart { get => ReadHere<uint>(nameof(LowPart)); set => WriteHere(nameof(LowPart), value); }

        [Offset(4UL)]
        public int High1Time { get => ReadHere<int>(nameof(High1Time)); set => WriteHere(nameof(High1Time), value); }

        [Offset(8UL)]
        public int High2Time { get => ReadHere<int>(nameof(High2Time)); set => WriteHere(nameof(High2Time), value); }

        public KsystemTime(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsystemTime>();
        }
    }
}