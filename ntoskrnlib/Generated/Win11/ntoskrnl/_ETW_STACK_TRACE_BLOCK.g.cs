#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public partial struct _ETW_STACK_TRACE_BLOCK
    {
        [FieldOffset(0)]
        public _ETW_APC_POOL ApcPool;
        [FieldOffset(192)]
        public int StackCaptureAttemptCount;
        [FieldOffset(196)]
        public int StackExpansionFailureCount;
    }
}