#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PEP_CRASHDUMP_INFORMATION
    {
        [FieldOffset(0)]
        public IntPtr DeviceHandle;
        [FieldOffset(8)]
        public IntPtr DeviceContext;
    }
}