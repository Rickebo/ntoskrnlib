using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_RESERVED_DEVICE_LIST")]
    public sealed class IommuReservedDeviceList : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Devices { get => ReadStructure<DynamicArray>(nameof(Devices)); set => WriteStructure(nameof(Devices), value); }

        public IommuReservedDeviceList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuReservedDeviceList>();
        }
    }
}