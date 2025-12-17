#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 90)]
    public partial struct _RTL_FUNCTION_OVERRIDE_CAPABILITIES
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 45)]
        public byte[] AMD64Capabilities;
        [FieldOffset(45)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 45)]
        public byte[] AMD64KernelCapabilities;
    }
}