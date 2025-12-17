#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _POP_POWER_PLANE
    {
        [FieldOffset(0)]
        public _UNICODE_STRING PowerPlaneId;
        [FieldOffset(16)]
        public ulong Lock;
        [FieldOffset(24)]
        public byte OldIrql;
        [FieldOffset(28)]
        public int DevicePowerMw;
        [FieldOffset(32)]
        public IntPtr PmaxHandle;
        [FieldOffset(40)]
        public IntPtr NotifyDevicePowerDraw;
        [FieldOffset(48)]
        public ulong DeviceCount;
        [FieldOffset(56)]
        public IntPtr Devices;
    }
}