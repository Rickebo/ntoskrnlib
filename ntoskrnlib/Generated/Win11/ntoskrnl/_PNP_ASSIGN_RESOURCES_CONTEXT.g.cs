#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PNP_ASSIGN_RESOURCES_CONTEXT
    {
        [FieldOffset(0)]
        public uint IncludeFailedDevices;
        [FieldOffset(4)]
        public uint DeviceCount;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public IntPtr[] DeviceList;
    }
}