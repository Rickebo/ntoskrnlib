#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _PROCESS_EXECUTION
    {
        [FieldOffset(0)]
        public int State;
        [FieldOffset(0)]
        public _PROCESS_EXECUTION_TRANSITION Transition;
        [FieldOffset(2)]
        public _PROCESS_EXECUTION_STATE Current;
        [FieldOffset(3)]
        public _PROCESS_EXECUTION_STATE Requested;
    }
}