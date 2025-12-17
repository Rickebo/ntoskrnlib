#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PEP_WORK_ACPI_NOTIFY
    {
        [FieldOffset(0)]
        public IntPtr DeviceHandle;
        [FieldOffset(8)]
        public uint NotifyCode;
    }
}