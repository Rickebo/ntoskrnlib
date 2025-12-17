#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EXT_IOMMU_S1_X64_DOMAIN_SETTINGS
    {
        [FieldOffset(0)]
        public _unnamed_tag_ Flags;
        [FieldOffset(8)]
        public ulong PageTableRoot;
    }
}