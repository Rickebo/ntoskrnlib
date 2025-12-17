using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_OUTPUT_MAPPING")]
    public sealed class ExtIommuOutputMapping : DynamicStructure
    {
        [Offset(0UL)]
        public ulong OutputId { get => ReadHere<ulong>(nameof(OutputId)); set => WriteHere(nameof(OutputId), value); }

        public ExtIommuOutputMapping(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuOutputMapping>();
        }
    }
}