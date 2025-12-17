#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public partial struct _POP_COOLING_EXTENSION
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public _LIST_ENTRY RequestListHead;
        [FieldOffset(32)]
        public _POP_RW_LOCK Lock;
        [FieldOffset(48)]
        public IntPtr DeviceObject;
        [FieldOffset(56)]
        public IntPtr NotificationEntry;
        [FieldOffset(64)]
        public byte Enabled;
        [FieldOffset(65)]
        public byte ActiveEngaged;
        [FieldOffset(66)]
        public byte ThrottleLimit;
        [FieldOffset(67)]
        public byte UpdatingToCurrent;
        [FieldOffset(72)]
        public IntPtr RemovalFlushEvent;
        [FieldOffset(80)]
        public IntPtr PnpFlushEvent;
        [FieldOffset(88)]
        public _THERMAL_COOLING_INTERFACE Interface;
    }
}