#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MI_COMBINE_WORKITEM
    {
        [FieldOffset(0)]
        public IntPtr NextEntry;
        [FieldOffset(8)]
        public _WORK_QUEUE_ITEM WorkItem;
    }
}