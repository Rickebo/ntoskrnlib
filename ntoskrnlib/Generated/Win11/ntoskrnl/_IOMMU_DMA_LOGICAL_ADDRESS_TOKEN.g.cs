#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN
    {
        [FieldOffset(0)]
        public ulong LogicalAddressBase;
        [FieldOffset(8)]
        public ulong Size;
    }
}