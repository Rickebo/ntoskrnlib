#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _HEAP_VIRTUAL_ALLOC_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Entry;
        [FieldOffset(16)]
        public _HEAP_ENTRY_EXTRA ExtraStuff;
        [FieldOffset(32)]
        public ulong CommitSize;
        [FieldOffset(40)]
        public ulong ReserveSize;
        [FieldOffset(48)]
        public _HEAP_ENTRY BusyBlock;
    }
}