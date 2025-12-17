#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _HEAP_UCR_DESCRIPTOR
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public _LIST_ENTRY SegmentEntry;
        [FieldOffset(32)]
        public IntPtr Address;
        [FieldOffset(40)]
        public ulong Size;
    }
}