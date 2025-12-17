using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_TIMESTAMP")]
    public sealed class WheaTimestamp : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Seconds { get => ReadHere<ulong>(nameof(Seconds)); set => WriteHere(nameof(Seconds), value); }

        [Offset(0UL)]
        public ulong Minutes { get => ReadHere<ulong>(nameof(Minutes)); set => WriteHere(nameof(Minutes), value); }

        [Offset(0UL)]
        public ulong Hours { get => ReadHere<ulong>(nameof(Hours)); set => WriteHere(nameof(Hours), value); }

        [Offset(0UL)]
        public ulong Precise { get => ReadHere<ulong>(nameof(Precise)); set => WriteHere(nameof(Precise), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong Day { get => ReadHere<ulong>(nameof(Day)); set => WriteHere(nameof(Day), value); }

        [Offset(0UL)]
        public ulong Month { get => ReadHere<ulong>(nameof(Month)); set => WriteHere(nameof(Month), value); }

        [Offset(0UL)]
        public ulong Year { get => ReadHere<ulong>(nameof(Year)); set => WriteHere(nameof(Year), value); }

        [Offset(0UL)]
        public ulong Century { get => ReadHere<ulong>(nameof(Century)); set => WriteHere(nameof(Century), value); }

        [Offset(0UL)]
        public LargeInteger AsLARGE_INTEGER { get => ReadStructure<LargeInteger>(nameof(AsLARGE_INTEGER)); set => WriteStructure(nameof(AsLARGE_INTEGER), value); }

        public WheaTimestamp(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaTimestamp>();
        }
    }
}