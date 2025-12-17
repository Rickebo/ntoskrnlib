#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _POP_FX_WORK_POOL_ITEM
    {
        [FieldOffset(0)]
        public IntPtr WorkPool;
        [FieldOffset(8)]
        public _WORK_QUEUE_ITEM WorkItem;
    }
}