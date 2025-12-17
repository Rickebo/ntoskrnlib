using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ISRDPCSTATS")]
    public sealed class Isrdpcstats : DynamicStructure
    {
        [Offset(0UL)]
        public ulong IsrTime { get => ReadHere<ulong>(nameof(IsrTime)); set => WriteHere(nameof(IsrTime), value); }

        [Offset(8UL)]
        public ulong IsrTimeStart { get => ReadHere<ulong>(nameof(IsrTimeStart)); set => WriteHere(nameof(IsrTimeStart), value); }

        [Offset(16UL)]
        public ulong IsrCount { get => ReadHere<ulong>(nameof(IsrCount)); set => WriteHere(nameof(IsrCount), value); }

        [Offset(24UL)]
        public ulong DpcTime { get => ReadHere<ulong>(nameof(DpcTime)); set => WriteHere(nameof(DpcTime), value); }

        [Offset(32UL)]
        public ulong DpcTimeStart { get => ReadHere<ulong>(nameof(DpcTimeStart)); set => WriteHere(nameof(DpcTimeStart), value); }

        [Offset(40UL)]
        public ulong DpcCount { get => ReadHere<ulong>(nameof(DpcCount)); set => WriteHere(nameof(DpcCount), value); }

        [Offset(48UL)]
        public byte IsrActive { get => ReadHere<byte>(nameof(IsrActive)); set => WriteHere(nameof(IsrActive), value); }

        [Offset(49UL)]
        [Length(7)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(56UL)]
        public IsrdpcstatsSequence DpcWatchdog { get => ReadStructure<IsrdpcstatsSequence>(nameof(DpcWatchdog)); set => WriteStructure(nameof(DpcWatchdog), value); }

        public Isrdpcstats(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Isrdpcstats>();
        }
    }
}