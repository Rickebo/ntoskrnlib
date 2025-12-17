#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _KWAIT_CHAIN_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr Thread;
        [FieldOffset(24)]
        public _KEVENT Event;
        [FieldOffset(48)]
        public IntPtr AbLockHandle;
    }
}