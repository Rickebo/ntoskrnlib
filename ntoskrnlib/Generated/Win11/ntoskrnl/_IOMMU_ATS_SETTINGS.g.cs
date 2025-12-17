#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _IOMMU_ATS_SETTINGS
    {
        [FieldOffset(0)]
        public byte AtsSupported;
        [FieldOffset(0)]
        public byte AtsRequired;
        [FieldOffset(0)]
        public byte Rsvd;
        [FieldOffset(0)]
        public byte AsUCHAR;
    }
}