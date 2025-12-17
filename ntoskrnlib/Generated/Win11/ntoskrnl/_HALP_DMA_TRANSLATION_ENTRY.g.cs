#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _HALP_DMA_TRANSLATION_ENTRY
    {
        [FieldOffset(0)]
        public ulong PhysicalAddress;
        [FieldOffset(8)]
        public IntPtr Next;
        [FieldOffset(16)]
        public uint MappedLength;
        [FieldOffset(24)]
        public _IOMMU_DMA_LOGICAL_ADDRESS_TOKEN_MAPPED_SEGMENT RemappingAddress;
        [FieldOffset(48)]
        public _unnamed_tag_ u;
        [FieldOffset(56)]
        public IntPtr NextMapping;
        [FieldOffset(64)]
        public byte LogicalBounceBufferPremapped;
    }
}