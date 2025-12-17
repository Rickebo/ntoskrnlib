#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _VF_DRIVER_IO_CALLBACKS
    {
        [FieldOffset(0)]
        public IntPtr DriverInit;
        [FieldOffset(8)]
        public IntPtr DriverStartIo;
        [FieldOffset(16)]
        public IntPtr DriverUnload;
        [FieldOffset(24)]
        public IntPtr AddDevice;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public IntPtr[] MajorFunction;
    }
}