using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_DEVICE_INFORMATION")]
    public sealed class IommuDmaDeviceInformation : DynamicStructure
    {
        [Offset(0UL)]
        public byte DefaultPasidEnabled { get => ReadHere<byte>(nameof(DefaultPasidEnabled)); set => WriteHere(nameof(DefaultPasidEnabled), value); }

        [Offset(1UL)]
        public byte PasidTaggedDmaEnabled { get => ReadHere<byte>(nameof(PasidTaggedDmaEnabled)); set => WriteHere(nameof(PasidTaggedDmaEnabled), value); }

        [Offset(2UL)]
        public byte PasidFaultsSuppressed { get => ReadHere<byte>(nameof(PasidFaultsSuppressed)); set => WriteHere(nameof(PasidFaultsSuppressed), value); }

        public IommuDmaDeviceInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaDeviceInformation>();
        }
    }
}