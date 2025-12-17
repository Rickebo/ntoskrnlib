#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _EXT_IOMMU_DEVICE_ID
    {
        [FieldOffset(0)]
        public uint DeviceType;
        [FieldOffset(4)]
        public _EXT_IOMMU_DEVICE_ID_FLAGS Flags;
        [FieldOffset(8)]
        public _EXT_IOMMU_DEVICE_ID_PCI Pci;
        [FieldOffset(8)]
        public _EXT_IOMMU_DEVICE_ID_ACPI Acpi;
        [FieldOffset(8)]
        public byte IoApicId;
        [FieldOffset(8)]
        public ulong LogicalId;
        [FieldOffset(8)]
        public _EXT_IOMMU_DEVICE_ID_TEST Test;
    }
}