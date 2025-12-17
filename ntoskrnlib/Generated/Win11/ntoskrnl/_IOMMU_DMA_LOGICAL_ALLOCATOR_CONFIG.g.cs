#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _IOMMU_DMA_LOGICAL_ALLOCATOR_CONFIG
    {
        [FieldOffset(0)]
        public uint LogicalAllocatorType;
        [FieldOffset(4)]
        public _unnamed_tag_ BuddyAllocatorConfig;
    }
}