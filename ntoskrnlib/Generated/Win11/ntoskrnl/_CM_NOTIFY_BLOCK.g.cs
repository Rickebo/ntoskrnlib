#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _CM_NOTIFY_BLOCK
    {
        [FieldOffset(0)]
        public _LIST_ENTRY HiveList;
        [FieldOffset(16)]
        public _LIST_ENTRY PostList;
        [FieldOffset(32)]
        public IntPtr KeyControlBlock;
        [FieldOffset(40)]
        public IntPtr KeyBody;
        [FieldOffset(48)]
        public uint Filter;
        [FieldOffset(48)]
        public uint WatchTree;
        [FieldOffset(48)]
        public uint NotifyPending;
        [FieldOffset(56)]
        public _SECURITY_SUBJECT_CONTEXT SubjectContext;
    }
}