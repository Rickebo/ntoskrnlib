#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _EXT_IOMMU_DEVICE_ID_FLAGS
    {
        [FieldOffset(0)]
        public ushort AsUSHORT;
        [FieldOffset(0)]
        public ushort IsAliased;
        [FieldOffset(0)]
        public ushort Reserved;
    }
}