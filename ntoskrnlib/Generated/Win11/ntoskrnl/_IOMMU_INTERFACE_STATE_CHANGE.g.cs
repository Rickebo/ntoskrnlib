#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _IOMMU_INTERFACE_STATE_CHANGE
    {
        [FieldOffset(0)]
        public _IOMMU_INTERFACE_STATE_CHANGE_FIELDS PresentFields;
        [FieldOffset(4)]
        public uint AvailableDomainTypes;
    }
}