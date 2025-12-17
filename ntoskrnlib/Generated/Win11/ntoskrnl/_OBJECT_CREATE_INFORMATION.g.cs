#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _OBJECT_CREATE_INFORMATION
    {
        [FieldOffset(0)]
        public uint Attributes;
        [FieldOffset(8)]
        public IntPtr RootDirectory;
        [FieldOffset(16)]
        public sbyte ProbeMode;
        [FieldOffset(20)]
        public uint PagedPoolCharge;
        [FieldOffset(24)]
        public uint NonPagedPoolCharge;
        [FieldOffset(28)]
        public uint SecurityDescriptorCharge;
        [FieldOffset(32)]
        public IntPtr SecurityDescriptor;
        [FieldOffset(40)]
        public IntPtr SecurityQos;
        [FieldOffset(48)]
        public _SECURITY_QUALITY_OF_SERVICE SecurityQualityOfService;
    }
}