#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _IOMMU_DEVICE_CREATION_CONFIGURATION
    {
        [FieldOffset(0)]
        public _LIST_ENTRY NextConfiguration;
        [FieldOffset(16)]
        public uint ConfigType;
        [FieldOffset(24)]
        public _IOMMU_DEVICE_CREATION_CONFIGURATION_ACPI Acpi;
        [FieldOffset(24)]
        public IntPtr DeviceId;
        [FieldOffset(24)]
        public _IOMMU_DEVICE_CREATION_CONFIGURATION_PASID Pasid;
    }
}