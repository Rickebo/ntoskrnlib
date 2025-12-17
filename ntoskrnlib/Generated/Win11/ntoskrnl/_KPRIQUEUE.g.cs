#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 688)]
    public partial struct _KPRIQUEUE
    {
        [FieldOffset(0)]
        public _DISPATCHER_HEADER Header;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public _LIST_ENTRY[] EntryListHead;
        [FieldOffset(536)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public int[] CurrentCount;
        [FieldOffset(664)]
        public uint MaximumCount;
        [FieldOffset(672)]
        public _LIST_ENTRY ThreadListHead;
    }
}