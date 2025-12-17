using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DOMAIN_CONFIGURATION")]
    public sealed class DomainConfiguration : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(8UL)]
        public DomainConfigurationARM64 Arm64 { get => ReadStructure<DomainConfigurationARM64>(nameof(Arm64)); set => WriteStructure(nameof(Arm64), value); }

        [Offset(8UL)]
        public DomainConfigurationX64 X64 { get => ReadStructure<DomainConfigurationX64>(nameof(X64)); set => WriteStructure(nameof(X64), value); }

        public DomainConfiguration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DomainConfiguration>();
        }
    }
}