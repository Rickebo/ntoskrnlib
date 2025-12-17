#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _DMA_IOMMU_INTERFACE
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(8)]
        public IntPtr CreateDomain;
        [FieldOffset(16)]
        public IntPtr DeleteDomain;
        [FieldOffset(24)]
        public IntPtr AttachDevice;
        [FieldOffset(32)]
        public IntPtr DetachDevice;
        [FieldOffset(40)]
        public IntPtr FlushDomain;
        [FieldOffset(48)]
        public IntPtr FlushDomainByVaList;
        [FieldOffset(56)]
        public IntPtr QueryInputMappings;
        [FieldOffset(64)]
        public IntPtr MapLogicalRange;
        [FieldOffset(72)]
        public IntPtr UnmapLogicalRange;
        [FieldOffset(80)]
        public IntPtr MapIdentityRange;
        [FieldOffset(88)]
        public IntPtr UnmapIdentityRange;
        [FieldOffset(96)]
        public IntPtr SetDeviceFaultReporting;
        [FieldOffset(104)]
        public IntPtr ConfigureDomain;
    }
}