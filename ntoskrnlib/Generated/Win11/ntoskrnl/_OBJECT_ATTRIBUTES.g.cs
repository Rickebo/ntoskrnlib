#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _OBJECT_ATTRIBUTES
    {
        [FieldOffset(0)]
        public uint Length;
        [FieldOffset(8)]
        public IntPtr RootDirectory;
        [FieldOffset(16)]
        public IntPtr ObjectName;
        [FieldOffset(24)]
        public uint Attributes;
        [FieldOffset(32)]
        public IntPtr SecurityDescriptor;
        [FieldOffset(40)]
        public IntPtr SecurityQualityOfService;
    }
}