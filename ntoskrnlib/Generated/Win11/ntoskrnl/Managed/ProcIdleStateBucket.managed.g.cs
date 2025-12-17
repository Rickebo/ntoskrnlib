using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROC_IDLE_STATE_BUCKET")]
    public sealed class ProcIdleStateBucket : DynamicStructure
    {
        [Offset(0UL)]
        public ulong TotalTime { get => ReadHere<ulong>(nameof(TotalTime)); set => WriteHere(nameof(TotalTime), value); }

        [Offset(8UL)]
        public ulong MinTime { get => ReadHere<ulong>(nameof(MinTime)); set => WriteHere(nameof(MinTime), value); }

        [Offset(16UL)]
        public ulong MaxTime { get => ReadHere<ulong>(nameof(MaxTime)); set => WriteHere(nameof(MaxTime), value); }

        [Offset(24UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        public ProcIdleStateBucket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcIdleStateBucket>();
        }
    }
}