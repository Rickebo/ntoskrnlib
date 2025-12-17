#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _WNF_DISPATCHER
    {
        [FieldOffset(0)]
        public _WNF_NODE_HEADER Header;
        [FieldOffset(8)]
        public _WORK_QUEUE_ITEM WorkItem;
        [FieldOffset(40)]
        public int State;
    }
}