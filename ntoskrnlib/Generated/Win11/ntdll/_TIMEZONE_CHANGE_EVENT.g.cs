#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _TIMEZONE_CHANGE_EVENT
    {
        [FieldOffset(0)]
        public _KDPC Dpc;
        [FieldOffset(64)]
        public _KTIMER Timer;
        [FieldOffset(128)]
        public _WORK_QUEUE_ITEM WorkItem;
    }
}