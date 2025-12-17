#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _IOMMU_MAP_PHYSICAL_ADDRESS
    {
        [FieldOffset(0)]
        public uint MapType;
        [FieldOffset(8)]
        public _unnamed_tag_ Mdl;
        [FieldOffset(8)]
        public _unnamed_tag_ ContiguousRange;
        [FieldOffset(8)]
        public _unnamed_tag_ PfnArray;
    }
}