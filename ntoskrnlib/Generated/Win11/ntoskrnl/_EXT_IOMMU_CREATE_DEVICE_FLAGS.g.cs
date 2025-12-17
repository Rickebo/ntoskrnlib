#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _EXT_IOMMU_CREATE_DEVICE_FLAGS
    {
        [FieldOffset(0)]
        public uint AsUINT32;
        [FieldOffset(0)]
        public uint WildCard;
        [FieldOffset(0)]
        public uint ForceCreate;
        [FieldOffset(0)]
        public uint LiveTraffic;
        [FieldOffset(0)]
        public uint DeviceIsReserved;
        [FieldOffset(0)]
        public uint Reserved;
    }
}