#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _DMA_IOMMU_INTERFACE_V1
    {
        [FieldOffset(0)]
        public IntPtr CreateDomain;
        [FieldOffset(8)]
        public IntPtr DeleteDomain;
        [FieldOffset(16)]
        public IntPtr AttachDevice;
        [FieldOffset(24)]
        public IntPtr DetachDevice;
        [FieldOffset(32)]
        public IntPtr FlushDomain;
        [FieldOffset(40)]
        public IntPtr FlushDomainByVaList;
        [FieldOffset(48)]
        public IntPtr QueryInputMappings;
        [FieldOffset(56)]
        public IntPtr MapLogicalRange;
        [FieldOffset(64)]
        public IntPtr UnmapLogicalRange;
        [FieldOffset(72)]
        public IntPtr MapIdentityRange;
        [FieldOffset(80)]
        public IntPtr UnmapIdentityRange;
        [FieldOffset(88)]
        public IntPtr SetDeviceFaultReporting;
        [FieldOffset(96)]
        public IntPtr ConfigureDomain;
    }
}