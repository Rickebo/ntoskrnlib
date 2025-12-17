#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _IOMMU_BUS_INTERFACE
    {
        [FieldOffset(0)]
        public ushort Size;
        [FieldOffset(2)]
        public ushort Version;
        [FieldOffset(8)]
        public IntPtr Context;
        [FieldOffset(16)]
        public IntPtr InterfaceReference;
        [FieldOffset(24)]
        public IntPtr InterfaceDereference;
        [FieldOffset(32)]
        public IntPtr GetSvmCapabilities;
        [FieldOffset(40)]
        public IntPtr EnableSvmCapabilities;
        [FieldOffset(48)]
        public IntPtr DisableSvmCapabilities;
        [FieldOffset(56)]
        public IntPtr GetDeviceProperties;
        [FieldOffset(64)]
        public IntPtr GetDeviceId;
        [FieldOffset(72)]
        public IntPtr GetRootDevice;
    }
}