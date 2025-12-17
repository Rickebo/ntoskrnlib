#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KI_IDEAL_PROCESSOR_SET_BREAKPOINTS
    {
        [FieldOffset(0)]
        public _KI_PROCESS_CONCURRENCY_COUNT Low;
        [FieldOffset(4)]
        public _KI_PROCESS_CONCURRENCY_COUNT High;
    }
}