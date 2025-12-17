#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EXT_IOMMU_DEVICE_ID_PCI
    {
        [FieldOffset(0)]
        public ulong AsUINT64;
        [FieldOffset(0)]
        public ushort PciSegmentNumber;
        [FieldOffset(2)]
        public ushort PhantomFunctionBits;
        [FieldOffset(2)]
        public ushort Reserved;
        [FieldOffset(2)]
        public ushort StartBusNumber;
        [FieldOffset(4)]
        public ushort Bdf;
        [FieldOffset(6)]
        public ushort DevicePathLength;
        [FieldOffset(8)]
        public IntPtr DevicePath;
    }
}