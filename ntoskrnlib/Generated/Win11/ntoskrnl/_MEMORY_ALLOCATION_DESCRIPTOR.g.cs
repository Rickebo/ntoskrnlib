#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _MEMORY_ALLOCATION_DESCRIPTOR
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE Node;
        [FieldOffset(24)]
        public uint MemoryType;
        [FieldOffset(32)]
        public ulong BasePage;
        [FieldOffset(40)]
        public ulong PageCount;
    }
}