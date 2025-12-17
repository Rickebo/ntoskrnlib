#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial struct _EXT_IOMMU_FUNCTION_TABLE_EXTENDED
    {
        [FieldOffset(0)]
        public IntPtr FindDevice;
        [FieldOffset(8)]
        public IntPtr SetDeviceSvmCapabilities;
        [FieldOffset(16)]
        public IntPtr SetDevicePasidTable;
        [FieldOffset(24)]
        public IntPtr GrowPasidTable;
        [FieldOffset(32)]
        public IntPtr SetPasidAddressSpace;
        [FieldOffset(40)]
        public IntPtr FlushTb;
        [FieldOffset(48)]
        public IntPtr FlushDeviceTbOnly;
        [FieldOffset(56)]
        public IntPtr DismissPageFault;
        [FieldOffset(64)]
        public IntPtr GetPageFault;
        [FieldOffset(72)]
        public IntPtr SetMessageInterruptRouting;
        [FieldOffset(80)]
        public IntPtr EnableInterrupt;
        [FieldOffset(88)]
        public IntPtr DisableInterrupt;
        [FieldOffset(96)]
        public IntPtr HandleInterrupt;
        [FieldOffset(104)]
        public IntPtr CheckForReservedRegion;
        [FieldOffset(112)]
        public IntPtr MarkHiberRegions;
        [FieldOffset(120)]
        public IntPtr DrainSvmPageRequests;
        [FieldOffset(128)]
        public IntPtr CancelPageRequests;
        [FieldOffset(136)]
        public IntPtr EnumerateReservedDevices;
        [FieldOffset(144)]
        public IntPtr ProcessReservedDomains;
        [FieldOffset(152)]
        public IntPtr QueryAcpiDeviceMapping;
        [FieldOffset(160)]
        public IntPtr GetRidAcpiMapCount;
        [FieldOffset(168)]
        public IntPtr ConfigureAts;
        [FieldOffset(176)]
        public IntPtr SetDeviceSvmCapabilitiesLegacy;
    }
}