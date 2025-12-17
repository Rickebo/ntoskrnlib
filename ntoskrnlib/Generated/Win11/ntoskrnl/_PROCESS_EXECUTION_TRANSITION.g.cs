#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _PROCESS_EXECUTION_TRANSITION
    {
        [FieldOffset(0)]
        public short TransitionState;
        [FieldOffset(0)]
        public ushort InProgress;
        [FieldOffset(0)]
        public ushort Reserved;
    }
}