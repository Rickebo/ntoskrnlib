#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public partial struct _IOMMU_DMA_DEVICE_INFORMATION
    {
        [FieldOffset(0)]
        public byte DefaultPasidEnabled;
        [FieldOffset(1)]
        public byte PasidTaggedDmaEnabled;
        [FieldOffset(2)]
        public byte PasidFaultsSuppressed;
    }
}