#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _PO_DEVICE_NOTIFY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public _LIST_ENTRY PowerChildren;
        [FieldOffset(32)]
        public _LIST_ENTRY PowerParents;
        [FieldOffset(48)]
        public IntPtr TargetDevice;
        [FieldOffset(56)]
        public byte OrderLevel;
        [FieldOffset(64)]
        public IntPtr DeviceObject;
        [FieldOffset(72)]
        public IntPtr DeviceName;
        [FieldOffset(80)]
        public IntPtr DriverName;
        [FieldOffset(88)]
        public uint ChildCount;
        [FieldOffset(92)]
        public uint ActiveChild;
        [FieldOffset(96)]
        public uint ParentCount;
        [FieldOffset(100)]
        public uint ActiveParent;
    }
}