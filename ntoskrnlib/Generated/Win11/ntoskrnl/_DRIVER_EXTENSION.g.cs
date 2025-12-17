#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _DRIVER_EXTENSION
    {
        [FieldOffset(0)]
        public IntPtr DriverObject;
        [FieldOffset(8)]
        public IntPtr AddDevice;
        [FieldOffset(16)]
        public uint Count;
        [FieldOffset(24)]
        public _UNICODE_STRING ServiceKeyName;
    }
}