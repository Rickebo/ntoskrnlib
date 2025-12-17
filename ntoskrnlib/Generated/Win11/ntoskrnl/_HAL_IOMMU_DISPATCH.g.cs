#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public partial struct _HAL_IOMMU_DISPATCH
    {
        [FieldOffset(0)]
        public IntPtr HalIommuSupportEnabled;
        [FieldOffset(8)]
        public IntPtr HalIommuGetConfiguration;
        [FieldOffset(16)]
        public IntPtr HalIommuGetLibraryContext;
        [FieldOffset(24)]
        public IntPtr HalIommuMapDevice;
        [FieldOffset(32)]
        public IntPtr HalIommuEnableDevicePasid;
        [FieldOffset(40)]
        public IntPtr HalIommuSetAddressSpace;
        [FieldOffset(48)]
        public IntPtr HalIommuDisableDevicePasid;
        [FieldOffset(56)]
        public IntPtr HalIommuUnmapDevice;
        [FieldOffset(64)]
        public IntPtr HalIommuFreeLibraryContext;
        [FieldOffset(72)]
        public IntPtr HalIommuFlushTb;
        [FieldOffset(80)]
        public IntPtr HalIommuFlushAllPasid;
        [FieldOffset(88)]
        public IntPtr HalIommuProcessPageRequestQueue;
        [FieldOffset(96)]
        public IntPtr HalIommuFaultRoutine;
        [FieldOffset(104)]
        public IntPtr HalIommuReferenceAsid;
        [FieldOffset(112)]
        public IntPtr HalIommuDereferenceAsid;
        [FieldOffset(120)]
        public IntPtr HalIommuServicePageFault;
        [FieldOffset(128)]
        public IntPtr HalIommuDevicePowerChange;
        [FieldOffset(136)]
        public IntPtr HalIommuBeginDeviceReset;
        [FieldOffset(144)]
        public IntPtr HalIommuFinalizeDeviceReset;
        [FieldOffset(152)]
        public IntPtr HalIommuGetAtsSettings;
        [FieldOffset(160)]
        public IntPtr HalIommuCreateAtsDevice;
        [FieldOffset(168)]
        public IntPtr HalIommuDeleteAtsDevice;
        [FieldOffset(176)]
        public IntPtr HalIommuGetDomainTransitionSupport;
        [FieldOffset(184)]
        public IntPtr HalIommuSetDeviceMpam;
        [FieldOffset(192)]
        public IntPtr HalIommuGetDeviceMpam;
    }
}