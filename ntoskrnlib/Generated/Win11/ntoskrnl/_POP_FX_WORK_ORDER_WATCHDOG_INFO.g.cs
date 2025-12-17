#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public partial struct _POP_FX_WORK_ORDER_WATCHDOG_INFO
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Link;
        [FieldOffset(16)]
        public _KTIMER Timer;
        [FieldOffset(80)]
        public _KDPC Dpc;
        [FieldOffset(144)]
        public IntPtr WorkOrder;
        [FieldOffset(152)]
        public IntPtr CurrentWorkInfo;
        [FieldOffset(160)]
        public ulong WatchdogStart;
        [FieldOffset(168)]
        public IntPtr WorkerThread;
    }
}