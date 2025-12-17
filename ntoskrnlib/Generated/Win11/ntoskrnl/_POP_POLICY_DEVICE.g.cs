#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _POP_POLICY_DEVICE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public uint DeviceType;
        [FieldOffset(24)]
        public IntPtr Notification;
        [FieldOffset(32)]
        public _UNICODE_STRING Name;
        [FieldOffset(48)]
        public IntPtr Device;
        [FieldOffset(56)]
        public IntPtr Irp;
    }
}