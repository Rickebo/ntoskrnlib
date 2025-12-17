using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMSUPPORT_AGGREGATION")]
    public sealed class MmsupportAggregation : DynamicStructure
    {
        [Offset(0UL)]
        public uint PageFaultCount { get => ReadHere<uint>(nameof(PageFaultCount)); set => WriteHere(nameof(PageFaultCount), value); }

        [Offset(8UL)]
        public ulong WorkingSetSize { get => ReadHere<ulong>(nameof(WorkingSetSize)); set => WriteHere(nameof(WorkingSetSize), value); }

        [Offset(16UL)]
        public ulong WorkingSetLeafSize { get => ReadHere<ulong>(nameof(WorkingSetLeafSize)); set => WriteHere(nameof(WorkingSetLeafSize), value); }

        [Offset(24UL)]
        public ulong PeakWorkingSetSize { get => ReadHere<ulong>(nameof(PeakWorkingSetSize)); set => WriteHere(nameof(PeakWorkingSetSize), value); }

        public MmsupportAggregation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsupportAggregation>();
        }
    }
}