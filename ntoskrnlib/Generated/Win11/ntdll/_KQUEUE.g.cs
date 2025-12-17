#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _KQUEUE
    {
        [FieldOffset(0)]
        public _DISPATCHER_HEADER Header;
        [FieldOffset(24)]
        public _LIST_ENTRY EntryListHead;
        [FieldOffset(40)]
        public uint CurrentCount;
        [FieldOffset(44)]
        public uint MaximumCount;
        [FieldOffset(48)]
        public _LIST_ENTRY ThreadListHead;
    }
}