using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_HP_SUB_ALLOCATOR_CONFIGS")]
    public sealed class RtlHpSubAllocatorConfigs : DynamicStructure
    {
        [Offset(0UL)]
        public RtlHpLfhConfig LfhConfigs { get => ReadStructure<RtlHpLfhConfig>(nameof(LfhConfigs)); set => WriteStructure(nameof(LfhConfigs), value); }

        [Offset(4UL)]
        public RtlHpVsConfig VsConfigs { get => ReadStructure<RtlHpVsConfig>(nameof(VsConfigs)); set => WriteStructure(nameof(VsConfigs), value); }

        public RtlHpSubAllocatorConfigs(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlHpSubAllocatorConfigs>();
        }
    }
}