#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE
    {
        [FieldOffset(0)]
        public IntPtr DeviceHandle;
        [FieldOffset(8)]
        public uint CompletionFlags;
        [FieldOffset(12)]
        public int MethodStatus;
        [FieldOffset(16)]
        public IntPtr CompletionContext;
        [FieldOffset(24)]
        public ulong OutputArgumentSize;
        [FieldOffset(32)]
        public IntPtr OutputArguments;
    }
}