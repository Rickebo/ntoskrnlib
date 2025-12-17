#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public partial struct _OBP_SYSTEM_DOS_DEVICE_STATE
    {
        [FieldOffset(0)]
        public uint GlobalDeviceMap;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public uint[] LocalDeviceCount;
    }
}