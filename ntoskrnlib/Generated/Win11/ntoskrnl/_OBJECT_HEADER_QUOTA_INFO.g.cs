#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _OBJECT_HEADER_QUOTA_INFO
    {
        [FieldOffset(0)]
        public uint PagedPoolCharge;
        [FieldOffset(4)]
        public uint NonPagedPoolCharge;
        [FieldOffset(8)]
        public uint SecurityDescriptorCharge;
        [FieldOffset(12)]
        public uint Reserved1;
        [FieldOffset(16)]
        public IntPtr SecurityDescriptorQuotaBlock;
        [FieldOffset(24)]
        public ulong Reserved2;
    }
}