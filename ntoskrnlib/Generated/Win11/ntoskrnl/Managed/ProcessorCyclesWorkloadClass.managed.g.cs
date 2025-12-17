using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_CYCLES_WORKLOAD_CLASS")]
    public sealed class ProcessorCyclesWorkloadClass : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray ProcessorCyclesClass { get => ReadStructure<DynamicArray>(nameof(ProcessorCyclesClass)); set => WriteStructure(nameof(ProcessorCyclesClass), value); }

        public ProcessorCyclesWorkloadClass(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorCyclesWorkloadClass>();
        }
    }
}