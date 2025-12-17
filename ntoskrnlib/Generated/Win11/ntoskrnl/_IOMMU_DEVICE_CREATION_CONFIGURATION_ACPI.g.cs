#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI
    {
        [FieldOffset(0)]
        public uint InputMappingBase;
        [FieldOffset(4)]
        public uint MappingsCount;
    }
}