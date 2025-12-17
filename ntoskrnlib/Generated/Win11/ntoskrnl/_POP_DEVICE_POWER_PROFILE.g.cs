#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _POP_DEVICE_POWER_PROFILE
    {
        [FieldOffset(0)]
        public _UNICODE_STRING DeviceId;
        [FieldOffset(16)]
        public IntPtr PowerPlane;
        [FieldOffset(24)]
        public IntPtr FxDevice;
        [FieldOffset(32)]
        public int PowerDrawMw;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _PO_POWER_PLANE_PROFILE[] DxPower;
        [FieldOffset(72)]
        public ulong ComponentCount;
        [FieldOffset(80)]
        public IntPtr Components;
    }
}