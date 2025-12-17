#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public partial struct _DMA_IOMMU_INTERFACE_V2
    {
        [FieldOffset(0)]
        public IntPtr CreateDomainEx;
        [FieldOffset(8)]
        public IntPtr DeleteDomain;
        [FieldOffset(16)]
        public IntPtr AttachDeviceEx;
        [FieldOffset(24)]
        public IntPtr DetachDeviceEx;
        [FieldOffset(32)]
        public IntPtr FlushDomain;
        [FieldOffset(40)]
        public IntPtr FlushDomainByVaList;
        [FieldOffset(48)]
        public IntPtr QueryInputMappings;
        [FieldOffset(56)]
        public IntPtr MapLogicalRangeEx;
        [FieldOffset(64)]
        public IntPtr UnmapLogicalRange;
        [FieldOffset(72)]
        public IntPtr MapIdentityRangeEx;
        [FieldOffset(80)]
        public IntPtr UnmapIdentityRangeEx;
        [FieldOffset(88)]
        public IntPtr SetDeviceFaultReportingEx;
        [FieldOffset(96)]
        public IntPtr ConfigureDomain;
        [FieldOffset(104)]
        public IntPtr QueryAvailableDomainTypes;
        [FieldOffset(112)]
        public IntPtr RegisterInterfaceStateChangeCallback;
        [FieldOffset(120)]
        public IntPtr UnregisterInterfaceStateChangeCallback;
        [FieldOffset(128)]
        public IntPtr ReserveLogicalAddressRange;
        [FieldOffset(136)]
        public IntPtr FreeReservedLogicalAddressRange;
        [FieldOffset(144)]
        public IntPtr MapReservedLogicalRange;
        [FieldOffset(152)]
        public IntPtr UnmapReservedLogicalRange;
        [FieldOffset(160)]
        public IntPtr CreateDevice;
        [FieldOffset(168)]
        public IntPtr DeleteDevice;
    }
}