#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DEVICE_FAULT_CONFIGURATION
    {
        [FieldOffset(0)]
        public IntPtr FaultHandler;
        [FieldOffset(8)]
        public IntPtr FaultContext;
    }
}