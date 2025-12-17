using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_VAD_SEQUENTIAL_INFO")]
    public sealed class MiVadSequentialInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Length { get => ReadHere<ulong>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(0UL)]
        public ulong Vpn { get => ReadHere<ulong>(nameof(Vpn)); set => WriteHere(nameof(Vpn), value); }

        [Offset(0UL)]
        public ulong MustBeZero { get => ReadHere<ulong>(nameof(MustBeZero)); set => WriteHere(nameof(MustBeZero), value); }

        [Offset(0UL)]
        public ulong EntireField { get => ReadHere<ulong>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MiVadSequentialInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiVadSequentialInfo>();
        }
    }
}