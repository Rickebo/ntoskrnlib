using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_HV_DMA_DOMAIN_CONFIG_X64")]
    public sealed class HalHvDmaDomainConfigX64 : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger FirstLevelPageTableRoot { get => ReadStructure<LargeInteger>(nameof(FirstLevelPageTableRoot)); set => WriteStructure(nameof(FirstLevelPageTableRoot), value); }

        [Offset(8UL)]
        public byte TranslationEnabled { get => ReadHere<byte>(nameof(TranslationEnabled)); set => WriteHere(nameof(TranslationEnabled), value); }

        [Offset(9UL)]
        public byte Blocked { get => ReadHere<byte>(nameof(Blocked)); set => WriteHere(nameof(Blocked), value); }

        public HalHvDmaDomainConfigX64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalHvDmaDomainConfigX64>();
        }
    }
}