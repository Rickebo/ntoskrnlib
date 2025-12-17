#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _PNP_DEVICE_COMPLETION_QUEUE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY DispatchedList;
        [FieldOffset(16)]
        public uint DispatchedCount;
        [FieldOffset(24)]
        public _LIST_ENTRY CompletedList;
        [FieldOffset(40)]
        public _KSEMAPHORE CompletedSemaphore;
        [FieldOffset(72)]
        public ulong SpinLock;
    }
}