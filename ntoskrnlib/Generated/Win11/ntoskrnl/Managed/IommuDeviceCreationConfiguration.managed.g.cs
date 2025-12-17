using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DEVICE_CREATION_CONFIGURATION")]
    public sealed class IommuDeviceCreationConfiguration : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry NextConfiguration { get => ReadStructure<ListEntry>(nameof(NextConfiguration)); set => WriteStructure(nameof(NextConfiguration), value); }

        [Offset(16UL)]
        public uint ConfigType { get => ReadHere<uint>(nameof(ConfigType)); set => WriteHere(nameof(ConfigType), value); }

        [Offset(24UL)]
        public IommuDeviceCreationConfigurationAcpi Acpi { get => ReadStructure<IommuDeviceCreationConfigurationAcpi>(nameof(Acpi)); set => WriteStructure(nameof(Acpi), value); }

        [Offset(24UL)]
        public IntPtr DeviceId { get => ReadHere<IntPtr>(nameof(DeviceId)); set => WriteHere(nameof(DeviceId), value); }

        [Offset(24UL)]
        public IommuDeviceCreationConfigurationPasid Pasid { get => ReadStructure<IommuDeviceCreationConfigurationPasid>(nameof(Pasid)); set => WriteStructure(nameof(Pasid), value); }

        public IommuDeviceCreationConfiguration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDeviceCreationConfiguration>();
        }
    }
}