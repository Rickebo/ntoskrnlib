#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _IOMMU_DMA_LOGICAL_ALLOCATOR_OPERATIONS_V1
    {
        [FieldOffset(0)]
        public IntPtr AllocateLogicalAddress;
        [FieldOffset(8)]
        public IntPtr FreeLogicalAddress;
        [FieldOffset(16)]
        public IntPtr ReserveLogicalAddress;
        [FieldOffset(24)]
        public IntPtr QueryCapabilities;
        [FieldOffset(32)]
        public IntPtr CleanUp;
    }
}