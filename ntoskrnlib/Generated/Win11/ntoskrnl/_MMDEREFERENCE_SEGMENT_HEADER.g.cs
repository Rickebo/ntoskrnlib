#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MMDEREFERENCE_SEGMENT_HEADER
    {
        [FieldOffset(0)]
        public _KEVENT Event;
        [FieldOffset(24)]
        public _LIST_ENTRY ControlAreaDeleteListHead;
        [FieldOffset(40)]
        public _LIST_ENTRY UnusedSegmentDeleteListHead;
        [FieldOffset(56)]
        public _LIST_ENTRY PagefileExtensionListHead;
    }
}