#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _PO_NOTIFY_ORDER_LEVEL
    {
        [FieldOffset(0)]
        public uint DeviceCount;
        [FieldOffset(4)]
        public uint ActiveCount;
        [FieldOffset(8)]
        public _LIST_ENTRY WaitSleep;
        [FieldOffset(24)]
        public _LIST_ENTRY ReadySleep;
        [FieldOffset(40)]
        public _LIST_ENTRY ReadyS0;
        [FieldOffset(56)]
        public _LIST_ENTRY WaitS0;
    }
}