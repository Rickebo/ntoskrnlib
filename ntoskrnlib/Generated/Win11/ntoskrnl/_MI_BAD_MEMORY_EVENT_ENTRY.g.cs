#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_BAD_MEMORY_EVENT_ENTRY
    {
        [FieldOffset(0)]
        public uint BugCheckCode;
        [FieldOffset(4)]
        public int Active;
        [FieldOffset(8)]
        public uint Data;
        [FieldOffset(16)]
        public _LARGE_INTEGER PhysicalAddress;
        [FieldOffset(24)]
        public _WORK_QUEUE_ITEM WorkItem;
    }
}