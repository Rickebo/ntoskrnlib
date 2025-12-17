#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _PEP_WORK_POWER_CONTROL
    {
        [FieldOffset(0)]
        public IntPtr DeviceHandle;
        [FieldOffset(8)]
        public IntPtr PowerControlCode;
        [FieldOffset(16)]
        public IntPtr RequestContext;
        [FieldOffset(24)]
        public IntPtr InBuffer;
        [FieldOffset(32)]
        public ulong InBufferSize;
        [FieldOffset(40)]
        public IntPtr OutBuffer;
        [FieldOffset(48)]
        public ulong OutBufferSize;
    }
}