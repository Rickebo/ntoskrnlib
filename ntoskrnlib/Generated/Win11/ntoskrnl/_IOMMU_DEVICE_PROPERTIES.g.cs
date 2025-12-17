#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _IOMMU_DEVICE_PROPERTIES
    {
        [FieldOffset(0)]
        public uint IsThunderbolt;
        [FieldOffset(0)]
        public uint DmaCapableAtBoot;
        [FieldOffset(0)]
        public uint ForceDisableDmaRemapping;
        [FieldOffset(0)]
        public uint IsUntrustedPort;
        [FieldOffset(0)]
        public uint ForceEnableDmaRemapping;
        [FieldOffset(0)]
        public uint Rsvd;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}