using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VSM_PERFORMANCE_DATA")]
    public sealed class VsmPerformanceData : DynamicStructure
    {
        [Offset(0UL)]
        [Length(8)]
        public DynamicArray LaunchVsmMark { get => ReadStructure<DynamicArray>(nameof(LaunchVsmMark)); set => WriteStructure(nameof(LaunchVsmMark), value); }

        public VsmPerformanceData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VsmPerformanceData>();
        }
    }
}