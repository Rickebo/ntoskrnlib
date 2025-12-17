using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID")]
    public sealed class ExtIommuDeviceId : DynamicStructure
    {
        [Offset(0UL)]
        public uint DeviceType { get => ReadHere<uint>(nameof(DeviceType)); set => WriteHere(nameof(DeviceType), value); }

        [Offset(4UL)]
        public ExtIommuDeviceIdFlags Flags { get => ReadStructure<ExtIommuDeviceIdFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public ExtIommuDeviceIdPci Pci { get => ReadStructure<ExtIommuDeviceIdPci>(nameof(Pci)); set => WriteStructure(nameof(Pci), value); }

        [Offset(8UL)]
        public ExtIommuDeviceIdAcpi Acpi { get => ReadStructure<ExtIommuDeviceIdAcpi>(nameof(Acpi)); set => WriteStructure(nameof(Acpi), value); }

        [Offset(8UL)]
        public byte IoApicId { get => ReadHere<byte>(nameof(IoApicId)); set => WriteHere(nameof(IoApicId), value); }

        [Offset(8UL)]
        public ulong LogicalId { get => ReadHere<ulong>(nameof(LogicalId)); set => WriteHere(nameof(LogicalId), value); }

        [Offset(8UL)]
        public ExtIommuDeviceIdTest Test { get => ReadStructure<ExtIommuDeviceIdTest>(nameof(Test)); set => WriteStructure(nameof(Test), value); }

        public ExtIommuDeviceId(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuDeviceId>();
        }
    }
}