#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _POP_TRIGGER_WAIT
    {
        [FieldOffset(0)]
        public _KEVENT Event;
        [FieldOffset(24)]
        public int Status;
        [FieldOffset(32)]
        public _LIST_ENTRY Link;
        [FieldOffset(48)]
        public IntPtr Trigger;
    }
}