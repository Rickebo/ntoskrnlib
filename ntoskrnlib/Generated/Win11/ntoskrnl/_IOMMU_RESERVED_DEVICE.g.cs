#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _IOMMU_RESERVED_DEVICE
    {
        [FieldOffset(0)]
        public IntPtr DeviceId;
        [FieldOffset(8)]
        public IntPtr PageTable;
        [FieldOffset(16)]
        public _LARGE_INTEGER PageTablePhysical;
        [FieldOffset(24)]
        public IntPtr ExtDevice;
        [FieldOffset(32)]
        public uint RegionCount;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _EXT_IOMMU_RESERVED_MEMORY_REGION[] Regions;
    }
}