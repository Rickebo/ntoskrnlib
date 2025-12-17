using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_DOMAIN_CONFIG")]
    public sealed class HalHvDmaDomainConfig : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(8UL)]
        public HalHvDmaDomainConfigARM64 Arm64 { get => ReadStructure<HalHvDmaDomainConfigARM64>(nameof(Arm64)); set => WriteStructure(nameof(Arm64), value); }

        [Offset(8UL)]
        public HalHvDmaDomainConfigX64 X64 { get => ReadStructure<HalHvDmaDomainConfigX64>(nameof(X64)); set => WriteStructure(nameof(X64), value); }

        public HalHvDmaDomainConfig(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalHvDmaDomainConfig>();
        }
    }
}