#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 896)]
    public partial struct _ENODE
    {
        [FieldOffset(0)]
        public _KNODE Ncb;
        [FieldOffset(824)]
        public _WORK_QUEUE_ITEM HotAddProcessorWorkItem;
    }
}