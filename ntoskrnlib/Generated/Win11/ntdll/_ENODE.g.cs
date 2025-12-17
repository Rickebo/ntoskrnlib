#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 448)]
    public partial struct _ENODE
    {
        [FieldOffset(0)]
        public _KNODE Ncb;
        [FieldOffset(376)]
        public _WORK_QUEUE_ITEM HotAddProcessorWorkItem;
    }
}