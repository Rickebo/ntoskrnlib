using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID_TEST")]
    public sealed class ExtIommuDeviceIdTest : DynamicStructure
    {
        [Offset(0UL)]
        public ulong UniqueId { get => ReadHere<ulong>(nameof(UniqueId)); set => WriteHere(nameof(UniqueId), value); }

        public ExtIommuDeviceIdTest(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuDeviceIdTest>();
        }
    }
}