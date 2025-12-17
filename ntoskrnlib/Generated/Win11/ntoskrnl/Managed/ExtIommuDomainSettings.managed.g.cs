using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DOMAIN_SETTINGS")]
    public sealed class ExtIommuDomainSettings : DynamicStructure
    {
        [Offset(0UL)]
        public ExtIommuS1X64DomainSettings S1 { get => ReadStructure<ExtIommuS1X64DomainSettings>(nameof(S1)); set => WriteStructure(nameof(S1), value); }

        [Offset(16UL)]
        public UnnamedTag S2 { get => ReadStructure<UnnamedTag>(nameof(S2)); set => WriteStructure(nameof(S2), value); }

        public ExtIommuDomainSettings(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuDomainSettings>();
        }
    }
}