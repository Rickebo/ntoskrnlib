using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_S1_X64_DOMAIN_SETTINGS")]
    public sealed class ExtIommuS1X64DomainSettings : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public ulong PageTableRoot { get => ReadHere<ulong>(nameof(PageTableRoot)); set => WriteHere(nameof(PageTableRoot), value); }

        public ExtIommuS1X64DomainSettings(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuS1X64DomainSettings>();
        }
    }
}