#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MI_REBUILD_LARGE_PAGE_TIMER
    {
        [FieldOffset(0)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(32)]
        public byte SecondsLeft;
        [FieldOffset(33)]
        public byte RebuildActive;
        [FieldOffset(34)]
        public byte NextPassDelta;
        [FieldOffset(35)]
        public byte LargeSubPagesActive;
    }
}