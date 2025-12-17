using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_NODE_IOMMU_EXTENSION")]
    public sealed class DeviceNodeIommuExtension : DynamicStructure
    {
        public DeviceNodeIommuExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceNodeIommuExtension>();
        }
    }
}