using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_VERIFIER_TRIM_STATE")]
    public sealed class MiVerifierTrimState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong StartTime { get => ReadHere<ulong>(nameof(StartTime)); set => WriteHere(nameof(StartTime), value); }

        [Offset(8UL)]
        public ulong ActualTrimTime { get => ReadHere<ulong>(nameof(ActualTrimTime)); set => WriteHere(nameof(ActualTrimTime), value); }

        [Offset(16UL)]
        public ulong MaximumSingleTrimTimeReached { get => ReadHere<ulong>(nameof(MaximumSingleTrimTimeReached)); set => WriteHere(nameof(MaximumSingleTrimTimeReached), value); }

        [Offset(24UL)]
        public uint Instances { get => ReadHere<uint>(nameof(Instances)); set => WriteHere(nameof(Instances), value); }

        [Offset(28UL)]
        public int TrimInProgress { get => ReadHere<int>(nameof(TrimInProgress)); set => WriteHere(nameof(TrimInProgress), value); }

        public MiVerifierTrimState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiVerifierTrimState>();
        }
    }
}