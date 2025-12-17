using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE_ID_ACPI")]
    public sealed class ExtIommuDeviceIdAcpi : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ObjectName { get => ReadHere<IntPtr>(nameof(ObjectName)); set => WriteHere(nameof(ObjectName), value); }

        public ExtIommuDeviceIdAcpi(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuDeviceIdAcpi>();
        }
    }
}