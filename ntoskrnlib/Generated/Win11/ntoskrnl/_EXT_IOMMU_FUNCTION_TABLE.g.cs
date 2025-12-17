#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial struct _EXT_IOMMU_FUNCTION_TABLE
    {
        [FieldOffset(0)]
        public IntPtr ConfigureSettings;
        [FieldOffset(8)]
        public IntPtr Initialize;
        [FieldOffset(16)]
        public IntPtr AllocateDomain;
        [FieldOffset(24)]
        public IntPtr FreeDomain;
        [FieldOffset(32)]
        public IntPtr CreateDevice;
        [FieldOffset(40)]
        public IntPtr DeleteDevice;
        [FieldOffset(48)]
        public IntPtr OwnDevice;
        [FieldOffset(56)]
        public IntPtr ConfigureDeviceFaultReporting;
        [FieldOffset(64)]
        public IntPtr AttachDeviceDomain;
        [FieldOffset(72)]
        public IntPtr DetachDeviceDomain;
        [FieldOffset(80)]
        public IntPtr FlushDomainTb;
        [FieldOffset(88)]
        public IntPtr SyncFlush;
        [FieldOffset(96)]
        public IntPtr CompleteFlush;
        [FieldOffset(104)]
        public IntPtr AllocateRemappingTableEntry;
        [FieldOffset(112)]
        public IntPtr FreeRemappingTableEntry;
        [FieldOffset(120)]
        public IntPtr UpdateRemappingTableEntry;
        [FieldOffset(128)]
        public IntPtr InvalidateRemappingTableEntry;
        [FieldOffset(136)]
        public IntPtr UpdateRemappingDestination;
        [FieldOffset(144)]
        public IntPtr CaptureGlobalCrashdumpState;
    }
}