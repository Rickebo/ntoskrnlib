#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _CACHED_KSTACK_LIST
    {
        [FieldOffset(0)]
        public _SLIST_HEADER SListHead;
        [FieldOffset(16)]
        public _MI_KSTACK_ALLOCATIONS Counters;
        [FieldOffset(32)]
        public uint CurrentIndex;
        [FieldOffset(36)]
        public uint InUseAtOnce;
        [FieldOffset(40)]
        public uint MinimumFree;
        [FieldOffset(44)]
        public byte NonIdealStacksPresent;
    }
}