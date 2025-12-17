using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI")]
    public sealed class IommuDeviceCreationConfigurationAcpi : DynamicStructure
    {
        [Offset(0UL)]
        public uint InputMappingBase { get => ReadHere<uint>(nameof(InputMappingBase)); set => WriteHere(nameof(InputMappingBase), value); }

        [Offset(4UL)]
        public uint MappingsCount { get => ReadHere<uint>(nameof(MappingsCount)); set => WriteHere(nameof(MappingsCount), value); }

        public IommuDeviceCreationConfigurationAcpi(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDeviceCreationConfigurationAcpi>();
        }
    }
}