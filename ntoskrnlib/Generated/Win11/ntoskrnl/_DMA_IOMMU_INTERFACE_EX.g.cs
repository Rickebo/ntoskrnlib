#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 232)]
    public partial struct _DMA_IOMMU_INTERFACE_EX
    {
        [FieldOffset(0)]
        public ulong Size;
        [FieldOffset(8)]
        public uint Version;
        [FieldOffset(16)]
        public _DMA_IOMMU_INTERFACE_V1 V1;
        [FieldOffset(16)]
        public _DMA_IOMMU_INTERFACE_V2 V2;
        [FieldOffset(16)]
        public _DMA_IOMMU_INTERFACE_V3 V3;
    }
}