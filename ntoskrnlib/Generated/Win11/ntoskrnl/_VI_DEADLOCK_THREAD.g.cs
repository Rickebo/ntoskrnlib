#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _VI_DEADLOCK_THREAD
    {
        [FieldOffset(0)]
        public IntPtr Thread;
        [FieldOffset(8)]
        public IntPtr CurrentSpinNode;
        [FieldOffset(16)]
        public IntPtr CurrentOtherNode;
        [FieldOffset(24)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(24)]
        public _LIST_ENTRY FreeListEntry;
        [FieldOffset(40)]
        public uint NodeCount;
        [FieldOffset(44)]
        public uint PagingCount;
        [FieldOffset(48)]
        public byte ThreadUsesEresources;
    }
}