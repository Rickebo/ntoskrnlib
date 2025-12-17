#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT
    {
        [FieldOffset(0)]
        public IntPtr OwningToken;
        [FieldOffset(8)]
        public ulong Offset;
        [FieldOffset(16)]
        public ulong Size;
    }
}