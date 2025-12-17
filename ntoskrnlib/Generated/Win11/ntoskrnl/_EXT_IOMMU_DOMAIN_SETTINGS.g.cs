#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _EXT_IOMMU_DOMAIN_SETTINGS
    {
        [FieldOffset(0)]
        public _EXT_IOMMU_S1_X64_DOMAIN_SETTINGS S1;
        [FieldOffset(16)]
        public _unnamed_tag_ S2;
    }
}