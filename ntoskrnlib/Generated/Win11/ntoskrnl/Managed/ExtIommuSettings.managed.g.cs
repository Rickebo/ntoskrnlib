using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_SETTINGS")]
    public sealed class ExtIommuSettings : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag EnabledCapabilities { get => ReadStructure<UnnamedTag>(nameof(EnabledCapabilities)); set => WriteStructure(nameof(EnabledCapabilities), value); }

        [Offset(8UL)]
        public uint TranslationPolicy { get => ReadHere<uint>(nameof(TranslationPolicy)); set => WriteHere(nameof(TranslationPolicy), value); }

        [Offset(12UL)]
        public uint RemappingPolicy { get => ReadHere<uint>(nameof(RemappingPolicy)); set => WriteHere(nameof(RemappingPolicy), value); }

        [Offset(16UL)]
        public uint RemappingTableEntries { get => ReadHere<uint>(nameof(RemappingTableEntries)); set => WriteHere(nameof(RemappingTableEntries), value); }

        public ExtIommuSettings(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuSettings>();
        }
    }
}