using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ISRDPCSTATS_SEQUENCE")]
    public sealed class IsrdpcstatsSequence : DynamicStructure
    {
        [Offset(0UL)]
        public uint SequenceNumber { get => ReadHere<uint>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        [Offset(8UL)]
        public ulong IsrTime { get => ReadHere<ulong>(nameof(IsrTime)); set => WriteHere(nameof(IsrTime), value); }

        [Offset(16UL)]
        public ulong IsrCount { get => ReadHere<ulong>(nameof(IsrCount)); set => WriteHere(nameof(IsrCount), value); }

        [Offset(24UL)]
        public ulong DpcTime { get => ReadHere<ulong>(nameof(DpcTime)); set => WriteHere(nameof(DpcTime), value); }

        [Offset(32UL)]
        public ulong DpcCount { get => ReadHere<ulong>(nameof(DpcCount)); set => WriteHere(nameof(DpcCount), value); }

        public IsrdpcstatsSequence(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IsrdpcstatsSequence>();
        }
    }
}