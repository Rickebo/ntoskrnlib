using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_HP_SEG_ALLOC_POLICY")]
    public sealed class RtlHpSegAllocPolicy : DynamicStructure
    {
        [Offset(0UL)]
        public ulong MinLargePages { get => ReadHere<ulong>(nameof(MinLargePages)); set => WriteHere(nameof(MinLargePages), value); }

        [Offset(8UL)]
        public ulong MaxLargePages { get => ReadHere<ulong>(nameof(MaxLargePages)); set => WriteHere(nameof(MaxLargePages), value); }

        [Offset(16UL)]
        public byte MinUtilization { get => ReadHere<byte>(nameof(MinUtilization)); set => WriteHere(nameof(MinUtilization), value); }

        public RtlHpSegAllocPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlHpSegAllocPolicy>();
        }
    }
}