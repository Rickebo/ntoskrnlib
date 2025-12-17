#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DEBUG_IOMMU_EFI_DATA
    {
        [FieldOffset(0)]
        public IntPtr PciIoProtocolHandle;
        [FieldOffset(8)]
        public IntPtr Mapping;
    }
}