#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial struct _WHEAP_WORK_QUEUE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListHead;
        [FieldOffset(16)]
        public ulong ListLock;
        [FieldOffset(24)]
        public int ItemCount;
        [FieldOffset(32)]
        public _KDPC Dpc;
        [FieldOffset(96)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(128)]
        public IntPtr WorkRoutine;
    }
}