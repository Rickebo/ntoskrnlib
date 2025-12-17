#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MMMOD_WRITER_LISTHEAD
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListHead;
        [FieldOffset(16)]
        public _KEVENT Event;
    }
}