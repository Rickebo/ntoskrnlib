using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESS_EXTENDED_ENERGY_VALUES_V1")]
    public sealed class ProcessExtendedEnergyValuesV1 : DynamicStructure
    {
        [Offset(0UL)]
        public ProcessEnergyValues Base { get => ReadStructure<ProcessEnergyValues>(nameof(Base)); set => WriteStructure(nameof(Base), value); }

        [Offset(272UL)]
        public ProcessEnergyValuesExtension Extension { get => ReadStructure<ProcessEnergyValuesExtension>(nameof(Extension)); set => WriteStructure(nameof(Extension), value); }

        [Offset(432UL)]
        public ulong NpuWorkUnits { get => ReadHere<ulong>(nameof(NpuWorkUnits)); set => WriteHere(nameof(NpuWorkUnits), value); }

        public ProcessExtendedEnergyValuesV1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessExtendedEnergyValuesV1>();
        }
    }
}