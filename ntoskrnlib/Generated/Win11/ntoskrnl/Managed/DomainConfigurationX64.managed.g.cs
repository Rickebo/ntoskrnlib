using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DOMAIN_CONFIGURATION_X64")]
    public sealed class DomainConfigurationX64 : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger FirstLevelPageTableRoot { get => ReadStructure<LargeInteger>(nameof(FirstLevelPageTableRoot)); set => WriteStructure(nameof(FirstLevelPageTableRoot), value); }

        [Offset(8UL)]
        public byte TranslationEnabled { get => ReadHere<byte>(nameof(TranslationEnabled)); set => WriteHere(nameof(TranslationEnabled), value); }

        public DomainConfigurationX64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DomainConfigurationX64>();
        }
    }
}