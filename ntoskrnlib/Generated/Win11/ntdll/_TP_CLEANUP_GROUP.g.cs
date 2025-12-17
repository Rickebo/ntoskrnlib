#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _TP_CLEANUP_GROUP
    {
        [FieldOffset(0)]
        public _TPP_REFCOUNT Refcount;
        [FieldOffset(4)]
        public int Released;
        [FieldOffset(8)]
        public _RTL_SRWLOCK MemberLock;
        [FieldOffset(16)]
        public _LIST_ENTRY MemberList;
        [FieldOffset(32)]
        public _TPP_BARRIER Barrier;
        [FieldOffset(56)]
        public _RTL_SRWLOCK CleanupLock;
        [FieldOffset(64)]
        public _LIST_ENTRY CleanupList;
    }
}