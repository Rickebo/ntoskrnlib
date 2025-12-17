#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_LDW_WORK_CONTEXT
    {
        [FieldOffset(0)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(32)]
        public IntPtr FileObject;
        [FieldOffset(40)]
        public int ErrorStatus;
        [FieldOffset(44)]
        public int Active;
        [FieldOffset(48)]
        public byte FreeWhenDone;
    }
}