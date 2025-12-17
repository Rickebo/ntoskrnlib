using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DEVICE_CREATION_CONFIGURATION_PASID")]
    public sealed class IommuDeviceCreationConfigurationPasid : DynamicStructure
    {
        [Offset(0UL)]
        public uint ConfigType { get => ReadHere<uint>(nameof(ConfigType)); set => WriteHere(nameof(ConfigType), value); }

        [Offset(4UL)]
        public byte SuppressPasidFaults { get => ReadHere<byte>(nameof(SuppressPasidFaults)); set => WriteHere(nameof(SuppressPasidFaults), value); }

        public IommuDeviceCreationConfigurationPasid(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDeviceCreationConfigurationPasid>();
        }
    }
}