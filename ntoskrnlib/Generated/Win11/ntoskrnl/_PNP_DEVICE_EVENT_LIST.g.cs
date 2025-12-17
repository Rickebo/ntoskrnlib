#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial struct _PNP_DEVICE_EVENT_LIST
    {
        [FieldOffset(0)]
        public int Status;
        [FieldOffset(8)]
        public _KMUTANT EventQueueMutex;
        [FieldOffset(64)]
        public _FAST_MUTEX Lock;
        [FieldOffset(120)]
        public _LIST_ENTRY List;
    }
}