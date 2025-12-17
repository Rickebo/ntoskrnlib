#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _ETW_REPLY_QUEUE
    {
        [FieldOffset(0)]
        public _KQUEUE Queue;
        [FieldOffset(64)]
        public int EventsLost;
    }
}