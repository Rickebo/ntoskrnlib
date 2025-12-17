#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _IO_WORKITEM
    {
        [FieldOffset(0)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(32)]
        public IntPtr Routine;
        [FieldOffset(40)]
        public IntPtr IoObject;
        [FieldOffset(48)]
        public IntPtr Context;
        [FieldOffset(56)]
        public IntPtr WorkOnBehalfThread;
        [FieldOffset(64)]
        public uint Type;
        [FieldOffset(68)]
        public _GUID ActivityId;
    }
}