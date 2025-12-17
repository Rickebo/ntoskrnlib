#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _POP_FX_WORK_ORDER
    {
        [FieldOffset(0)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(32)]
        public int WorkCount;
        [FieldOffset(40)]
        public IntPtr Context;
        [FieldOffset(48)]
        public IntPtr WatchdogTimerInfo;
    }
}