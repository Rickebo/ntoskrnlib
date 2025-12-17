#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _KI_AVAILABLE_CPUS_WORK_ITEM
    {
        [FieldOffset(0)]
        public _WORK_QUEUE_ITEM ExWorkItem;
        [FieldOffset(32)]
        public _EX_RUNDOWN_REF RundownRef;
        [FieldOffset(40)]
        public _KI_AVAILABLE_CPUS_WORK_STATE WorkState;
        [FieldOffset(48)]
        public IntPtr Callback;
        [FieldOffset(56)]
        public IntPtr Context;
    }
}