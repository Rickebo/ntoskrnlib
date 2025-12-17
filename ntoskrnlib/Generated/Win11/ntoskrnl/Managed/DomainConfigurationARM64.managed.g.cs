using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DOMAIN_CONFIGURATION_ARM64")]
    public sealed class DomainConfigurationARM64 : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger Ttbr0 { get => ReadStructure<LargeInteger>(nameof(Ttbr0)); set => WriteStructure(nameof(Ttbr0), value); }

        [Offset(8UL)]
        public LargeInteger Ttbr1 { get => ReadStructure<LargeInteger>(nameof(Ttbr1)); set => WriteStructure(nameof(Ttbr1), value); }

        [Offset(16UL)]
        public uint Mair0 { get => ReadHere<uint>(nameof(Mair0)); set => WriteHere(nameof(Mair0), value); }

        [Offset(20UL)]
        public uint Mair1 { get => ReadHere<uint>(nameof(Mair1)); set => WriteHere(nameof(Mair1), value); }

        [Offset(24UL)]
        public byte InputSize0 { get => ReadHere<byte>(nameof(InputSize0)); set => WriteHere(nameof(InputSize0), value); }

        [Offset(25UL)]
        public byte InputSize1 { get => ReadHere<byte>(nameof(InputSize1)); set => WriteHere(nameof(InputSize1), value); }

        [Offset(26UL)]
        public byte CoherentTableWalks { get => ReadHere<byte>(nameof(CoherentTableWalks)); set => WriteHere(nameof(CoherentTableWalks), value); }

        [Offset(27UL)]
        public byte TranslationEnabled { get => ReadHere<byte>(nameof(TranslationEnabled)); set => WriteHere(nameof(TranslationEnabled), value); }

        public DomainConfigurationARM64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DomainConfigurationARM64>();
        }
    }
}