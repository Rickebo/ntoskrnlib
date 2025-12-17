#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _TRIAGE_DEVICE_NODE
    {
        [FieldOffset(0)]
        public IntPtr Sibling;
        [FieldOffset(8)]
        public IntPtr Child;
        [FieldOffset(16)]
        public IntPtr Parent;
        [FieldOffset(24)]
        public IntPtr LastChild;
        [FieldOffset(32)]
        public IntPtr PhysicalDeviceObject;
        [FieldOffset(40)]
        public _UNICODE_STRING InstancePath;
        [FieldOffset(56)]
        public _UNICODE_STRING ServiceName;
        [FieldOffset(72)]
        public IntPtr PendingIrp;
        [FieldOffset(80)]
        public IntPtr FxDevice;
    }
}