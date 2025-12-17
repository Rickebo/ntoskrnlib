#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _EXT_IOMMU_RESERVED_MEMORY_REGION
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER Base;
        [FieldOffset(8)]
        public _LARGE_INTEGER Limit;
        [FieldOffset(16)]
        public byte Ignored;
    }
}