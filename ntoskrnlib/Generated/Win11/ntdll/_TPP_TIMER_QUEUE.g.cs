#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _TPP_TIMER_QUEUE
    {
        [FieldOffset(0)]
        public _RTL_SRWLOCK Lock;
        [FieldOffset(8)]
        public _TPP_TIMER_SUBQUEUE AbsoluteQueue;
        [FieldOffset(128)]
        public _TPP_TIMER_SUBQUEUE RelativeQueue;
        [FieldOffset(248)]
        public int AllocatedTimerCount;
    }
}