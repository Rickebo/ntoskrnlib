#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_ENTRY_EXTRA
    {
        [FieldOffset(0)]
        public ushort AllocatorBackTraceIndex;
        [FieldOffset(2)]
        public ushort TagIndex;
        [FieldOffset(8)]
        public ulong Settable;
        [FieldOffset(0)]
        public ulong ZeroInit;
        [FieldOffset(8)]
        public ulong ZeroInit1;
    }
}