#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _HIDDEN_PROCESSOR_POWER_INTERFACE
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(8)]
        public IntPtr ReadPerfMsr;
        [FieldOffset(16)]
        public IntPtr WritePerfMsr;
        [FieldOffset(24)]
        public IntPtr ReadPerfIoPort;
        [FieldOffset(32)]
        public IntPtr WritePerfIoPort;
    }
}