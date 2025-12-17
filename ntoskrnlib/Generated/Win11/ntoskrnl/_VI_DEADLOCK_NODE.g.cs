#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 208)]
    public partial struct _VI_DEADLOCK_NODE
    {
        [FieldOffset(0)]
        public IntPtr Parent;
        [FieldOffset(8)]
        public _LIST_ENTRY ChildrenList;
        [FieldOffset(24)]
        public _LIST_ENTRY SiblingsList;
        [FieldOffset(40)]
        public _LIST_ENTRY ResourceList;
        [FieldOffset(40)]
        public _LIST_ENTRY FreeListEntry;
        [FieldOffset(56)]
        public IntPtr Root;
        [FieldOffset(64)]
        public IntPtr ThreadEntry;
        [FieldOffset(72)]
        public _unnamed_tag_ u1;
        [FieldOffset(76)]
        public int ChildrenCount;
        [FieldOffset(80)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public IntPtr[] StackTrace;
        [FieldOffset(144)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public IntPtr[] ParentStackTrace;
    }
}