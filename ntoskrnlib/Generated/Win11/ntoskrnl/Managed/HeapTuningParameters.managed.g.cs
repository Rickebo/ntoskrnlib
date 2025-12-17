using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_TUNING_PARAMETERS")]
    public sealed class HeapTuningParameters : DynamicStructure
    {
        [Offset(0UL)]
        public uint CommittThresholdShift { get => ReadHere<uint>(nameof(CommittThresholdShift)); set => WriteHere(nameof(CommittThresholdShift), value); }

        [Offset(8UL)]
        public ulong MaxPreCommittThreshold { get => ReadHere<ulong>(nameof(MaxPreCommittThreshold)); set => WriteHere(nameof(MaxPreCommittThreshold), value); }

        public HeapTuningParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapTuningParameters>();
        }
    }
}