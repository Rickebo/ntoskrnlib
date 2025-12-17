#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _EXT_IOMMU_DEVICE_ID_ACPI
    {
        [FieldOffset(0)]
        public IntPtr ObjectName;
    }
}