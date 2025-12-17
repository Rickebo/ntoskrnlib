#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _POP_FX_DEVICE_DIRECTED_TRANSITION_STATE
    {
        [FieldOffset(0)]
        public IntPtr CompletionContext;
        [FieldOffset(8)]
        public int CompletionStatus;
        [FieldOffset(12)]
        public uint DIrpPending;
        [FieldOffset(12)]
        public uint DIrpCompleted;
    }
}