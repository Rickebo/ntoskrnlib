#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 688)]
    public partial struct _TRIAGE_EX_WORK_QUEUE
    {
        [FieldOffset(0)]
        public _KPRIQUEUE WorkPriQueue;
    }
}