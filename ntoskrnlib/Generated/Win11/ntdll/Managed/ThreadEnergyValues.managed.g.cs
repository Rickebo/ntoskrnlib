using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_THREAD_ENERGY_VALUES")]
    public sealed class ThreadEnergyValues : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray Cycles { get => ReadStructure<DynamicArray>(nameof(Cycles)); set => WriteStructure(nameof(Cycles), value); }

        [Offset(64UL)]
        [Length(4)]
        public DynamicArray AttributedCycles { get => ReadStructure<DynamicArray>(nameof(AttributedCycles)); set => WriteStructure(nameof(AttributedCycles), value); }

        [Offset(128UL)]
        [Length(4)]
        public DynamicArray WorkOnBehalfCycles { get => ReadStructure<DynamicArray>(nameof(WorkOnBehalfCycles)); set => WriteStructure(nameof(WorkOnBehalfCycles), value); }

        [Offset(192UL)]
        public TimelineBitmap CpuTimeline { get => ReadStructure<TimelineBitmap>(nameof(CpuTimeline)); set => WriteStructure(nameof(CpuTimeline), value); }

        public ThreadEnergyValues(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ThreadEnergyValues>();
        }
    }
}