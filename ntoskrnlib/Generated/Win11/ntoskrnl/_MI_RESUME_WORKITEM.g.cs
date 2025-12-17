#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_RESUME_WORKITEM
    {
        [FieldOffset(0)]
        public _KEVENT ResumeCompleteEvent;
        [FieldOffset(24)]
        public _WORK_QUEUE_ITEM WorkItem;
    }
}