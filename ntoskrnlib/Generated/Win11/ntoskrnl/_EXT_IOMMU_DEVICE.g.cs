#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _EXT_IOMMU_DEVICE
    {
        [FieldOffset(0)]
        public IntPtr Context;
        [FieldOffset(8)]
        public IntPtr Iommu;
        [FieldOffset(16)]
        public IntPtr Domain;
        [FieldOffset(24)]
        public ulong AssociatedDomainId;
        [FieldOffset(32)]
        public ushort FirmwareDomainId;
        [FieldOffset(34)]
        public byte FaultReportingEnabled;
        [FieldOffset(35)]
        public byte IsReservedDevice;
    }
}